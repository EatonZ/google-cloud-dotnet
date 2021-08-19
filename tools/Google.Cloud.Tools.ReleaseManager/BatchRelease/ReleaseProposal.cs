﻿// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.ReleaseManager.History;
using LibGit2Sharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    /// <summary>
    /// The details of what might be released.
    /// </summary>
    internal class ReleaseProposal
    {
        public string Id { get; }
        public StructuredVersion OldVersion { get; }
        public StructuredVersion NewVersion { get; }
        private HistoryFile ModifiedHistoryFile { get; }

        /// <summary>
        /// The history file section being added, or null if this API does not have a version history.
        /// </summary>
        public HistoryFile.Section NewHistorySection
        {
            get => ModifiedHistoryFile.Sections.Count > 1 ? ModifiedHistoryFile.Sections[1] : null;
            set
            {
                if (ModifiedHistoryFile.Sections.Count > 1)
                {
                    ModifiedHistoryFile.Sections[1] = value;
                }
                else
                {
                    throw new InvalidOperationException("Proposal has no new history section to replace");
                }
            }
        }

        // Handy for debugging
        public override string ToString() => $"Update {Id} from {OldVersion} to {NewVersion}";

        private ReleaseProposal(string id, StructuredVersion oldVersion, StructuredVersion newVersion, HistoryFile historyFile) =>
            (Id, OldVersion, NewVersion, ModifiedHistoryFile) = (id, oldVersion, newVersion, historyFile);

        public static ReleaseProposal CreateFromHistory(Repository repo, string id, StructuredVersion newVersion)
        {
            var catalog = ApiCatalog.Load();
            var api = catalog[id];
            var oldVersion = api.StructuredVersion;
            api.Version = newVersion.ToString();
            var releases = Release.LoadReleases(repo, catalog, api).ToList();
            string historyFilePath = HistoryFile.GetPathForPackage(api.Id);
            var historyFile = HistoryFile.Load(historyFilePath);
            if (!api.NoVersionHistory)
            {
                var sectionsInserted = historyFile.MergeReleases(releases);
                if (sectionsInserted.Count != 1)
                {
                    throw new UserErrorException($"API {api.Id} would have {sectionsInserted.Count} new history sections");
                }
            }
            return new ReleaseProposal(api.Id, oldVersion, newVersion, historyFile);
        }

        public void Execute(BatchReleaseConfig config)
        {
            Console.WriteLine(this);

            if (config.ShowHistory)
            {
                if (NewHistorySection is HistoryFile.Section section)
                {
                    Console.WriteLine("New history text:");
                    foreach (var line in section.Lines)
                    {
                        Console.WriteLine($"  {line}");
                    }
                }
                else
                {
                    Console.WriteLine("(No history text)");
                }
            }
            if (config.DryRun)
            {
                return;
            }

            if (config.ConfirmRelease)
            {
                if (!ConfirmRelease())
                {
                    Console.WriteLine();
                    return;
                }
            }

            var root = DirectoryLayout.DetermineRootDirectory();
            using var repo = new Repository(root);

            var original = repo.Head;

            // Create a new branch with the desired changes, targeting the primary branch (to make testing changes to batch releasing simpler).
            var branchName = $"release-{Id}-{NewVersion}";
            var releaseBranch = repo.CreateBranch(branchName, CommandBase.PrimaryBranch);
            Commands.Checkout(repo, releaseBranch);

            new SetVersionCommand().InternalExecute(Id, NewVersion.ToString(), quiet: true);
            ModifiedHistoryFile.Save(HistoryFile.GetPathForPackage(Id));
            new CommitCommand().InternalExecute();
            new PushCommand().InternalExecute();

            // Go back to our current branch
            Commands.Checkout(repo, original);
            Console.WriteLine();
        }

        /// <summary>
        /// Asks for confirmation, with optional editing.
        /// </summary>
        /// <returns>true if the release should go ahead; false to skip this release.</returns>
        private bool ConfirmRelease()
        {
            while (true)
            {
                Console.Write("Proceed with release? (y/n/edit) ");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    case "edit":
                        EditNewHistory();
                        break;
                    default:
                        Console.WriteLine($"Unexpected response '{response}'.");
                        continue;
                }
            }
        }

        /// <summary>
        /// Saves the new history section as a temporary file and invokes the editor stored in
        /// the VISUAL environment variable. Once the process has exited, the file is re-read
        /// and the changes are stored in both NewHistoryText and the first section of the history file.
        /// </summary>
        private void EditNewHistory()
        {
            if (NewHistorySection is null)
            {
                Console.WriteLine("No history to edit.");
                return;
            }
            var editor = Environment.GetEnvironmentVariable("VISUAL");
            if (string.IsNullOrEmpty(editor))
            {
                throw new UserErrorException("Unable to determine text editor. Please set the VISUAL environment variable");
            }
            string tempFile = Path.GetTempFileName();
            File.WriteAllLines(tempFile, NewHistorySection.Lines);
            var process = Process.Start(editor, tempFile);
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                Console.WriteLine($"Process exited with code {process.ExitCode}. Ignoring changes.");
            }
            var lines = File.ReadAllLines(tempFile).ToList();
            NewHistorySection = new HistoryFile.Section(NewVersion, lines);
            Console.WriteLine("New history text:");
            foreach (var line in lines)
            {
                Console.WriteLine($"  {line}");
            }
        }
    }
}
