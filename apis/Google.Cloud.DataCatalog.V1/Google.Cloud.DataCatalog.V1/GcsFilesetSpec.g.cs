// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/datacatalog/v1/gcs_fileset_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataCatalog.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/datacatalog/v1/gcs_fileset_spec.proto</summary>
  public static partial class GcsFilesetSpecReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/datacatalog/v1/gcs_fileset_spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GcsFilesetSpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvY2xvdWQvZGF0YWNhdGFsb2cvdjEvZ2NzX2ZpbGVzZXRfc3Bl",
            "Yy5wcm90bxIbZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGixnb29nbGUvY2xvdWQvZGF0YWNh",
            "dGFsb2cvdjEvdGltZXN0YW1wcy5wcm90byJ6Cg5HY3NGaWxlc2V0U3BlYxIa",
            "Cg1maWxlX3BhdHRlcm5zGAEgAygJQgPgQQISTAoVc2FtcGxlX2djc19maWxl",
            "X3NwZWNzGAIgAygLMiguZ29vZ2xlLmNsb3VkLmRhdGFjYXRhbG9nLnYxLkdj",
            "c0ZpbGVTcGVjQgPgQQMiigEKC0djc0ZpbGVTcGVjEhYKCWZpbGVfcGF0aBgB",
            "IAEoCUID4EECEkoKDmdjc190aW1lc3RhbXBzGAIgASgLMi0uZ29vZ2xlLmNs",
            "b3VkLmRhdGFjYXRhbG9nLnYxLlN5c3RlbVRpbWVzdGFtcHNCA+BBAxIXCgpz",
            "aXplX2J5dGVzGAQgASgDQgPgQQNCywEKH2NvbS5nb29nbGUuY2xvdWQuZGF0",
            "YWNhdGFsb2cudjFQAVpGZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9jbG91ZC9kYXRhY2F0YWxvZy92MTtkYXRhY2F0YWxvZ/gBAaoC",
            "G0dvb2dsZS5DbG91ZC5EYXRhQ2F0YWxvZy5WMcoCG0dvb2dsZVxDbG91ZFxE",
            "YXRhQ2F0YWxvZ1xWMeoCHkdvb2dsZTo6Q2xvdWQ6OkRhdGFDYXRhbG9nOjpW",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.DataCatalog.V1.TimestampsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.GcsFilesetSpec), global::Google.Cloud.DataCatalog.V1.GcsFilesetSpec.Parser, new[]{ "FilePatterns", "SampleGcsFileSpecs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataCatalog.V1.GcsFileSpec), global::Google.Cloud.DataCatalog.V1.GcsFileSpec.Parser, new[]{ "FilePath", "GcsTimestamps", "SizeBytes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes a Cloud Storage fileset entry.
  /// </summary>
  public sealed partial class GcsFilesetSpec : pb::IMessage<GcsFilesetSpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GcsFilesetSpec> _parser = new pb::MessageParser<GcsFilesetSpec>(() => new GcsFilesetSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GcsFilesetSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.GcsFilesetSpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcsFilesetSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcsFilesetSpec(GcsFilesetSpec other) : this() {
      filePatterns_ = other.filePatterns_.Clone();
      sampleGcsFileSpecs_ = other.sampleGcsFileSpecs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcsFilesetSpec Clone() {
      return new GcsFilesetSpec(this);
    }

    /// <summary>Field number for the "file_patterns" field.</summary>
    public const int FilePatternsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_filePatterns_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> filePatterns_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Required. Patterns to identify a set of files in Google Cloud Storage.
    /// See [Cloud Storage
    /// documentation](https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames)
    /// for more information. Note that bucket wildcards are currently not
    /// supported.
    ///
    /// Examples of valid file_patterns:
    ///
    ///  * `gs://bucket_name/dir/*`: matches all files within `bucket_name/dir`
    ///                              directory.
    ///  * `gs://bucket_name/dir/**`: matches all files in `bucket_name/dir`
    ///                               spanning all subdirectories.
    ///  * `gs://bucket_name/file*`: matches files prefixed by `file` in
    ///                              `bucket_name`
    ///  * `gs://bucket_name/??.txt`: matches files with two characters followed by
    ///                               `.txt` in `bucket_name`
    ///  * `gs://bucket_name/[aeiou].txt`: matches files that contain a single
    ///                                    vowel character followed by `.txt` in
    ///                                    `bucket_name`
    ///  * `gs://bucket_name/[a-m].txt`: matches files that contain `a`, `b`, ...
    ///                                  or `m` followed by `.txt` in `bucket_name`
    ///  * `gs://bucket_name/a/*/b`: matches all files in `bucket_name` that match
    ///                              `a/*/b` pattern, such as `a/c/b`, `a/d/b`
    ///  * `gs://another_bucket/a.txt`: matches `gs://another_bucket/a.txt`
    ///
    /// You can combine wildcards to provide more powerful matches, for example:
    ///
    ///  * `gs://bucket_name/[a-m]??.j*g`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FilePatterns {
      get { return filePatterns_; }
    }

    /// <summary>Field number for the "sample_gcs_file_specs" field.</summary>
    public const int SampleGcsFileSpecsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.DataCatalog.V1.GcsFileSpec> _repeated_sampleGcsFileSpecs_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.DataCatalog.V1.GcsFileSpec.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.DataCatalog.V1.GcsFileSpec> sampleGcsFileSpecs_ = new pbc::RepeatedField<global::Google.Cloud.DataCatalog.V1.GcsFileSpec>();
    /// <summary>
    /// Output only. Sample files contained in this fileset, not all files
    /// contained in this fileset are represented here.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.DataCatalog.V1.GcsFileSpec> SampleGcsFileSpecs {
      get { return sampleGcsFileSpecs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GcsFilesetSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GcsFilesetSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!filePatterns_.Equals(other.filePatterns_)) return false;
      if(!sampleGcsFileSpecs_.Equals(other.sampleGcsFileSpecs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= filePatterns_.GetHashCode();
      hash ^= sampleGcsFileSpecs_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      filePatterns_.WriteTo(output, _repeated_filePatterns_codec);
      sampleGcsFileSpecs_.WriteTo(output, _repeated_sampleGcsFileSpecs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      filePatterns_.WriteTo(ref output, _repeated_filePatterns_codec);
      sampleGcsFileSpecs_.WriteTo(ref output, _repeated_sampleGcsFileSpecs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += filePatterns_.CalculateSize(_repeated_filePatterns_codec);
      size += sampleGcsFileSpecs_.CalculateSize(_repeated_sampleGcsFileSpecs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GcsFilesetSpec other) {
      if (other == null) {
        return;
      }
      filePatterns_.Add(other.filePatterns_);
      sampleGcsFileSpecs_.Add(other.sampleGcsFileSpecs_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            filePatterns_.AddEntriesFrom(input, _repeated_filePatterns_codec);
            break;
          }
          case 18: {
            sampleGcsFileSpecs_.AddEntriesFrom(input, _repeated_sampleGcsFileSpecs_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            filePatterns_.AddEntriesFrom(ref input, _repeated_filePatterns_codec);
            break;
          }
          case 18: {
            sampleGcsFileSpecs_.AddEntriesFrom(ref input, _repeated_sampleGcsFileSpecs_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Specifications of a single file in Cloud Storage.
  /// </summary>
  public sealed partial class GcsFileSpec : pb::IMessage<GcsFileSpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GcsFileSpec> _parser = new pb::MessageParser<GcsFileSpec>(() => new GcsFileSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GcsFileSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataCatalog.V1.GcsFilesetSpecReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcsFileSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcsFileSpec(GcsFileSpec other) : this() {
      filePath_ = other.filePath_;
      gcsTimestamps_ = other.gcsTimestamps_ != null ? other.gcsTimestamps_.Clone() : null;
      sizeBytes_ = other.sizeBytes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcsFileSpec Clone() {
      return new GcsFileSpec(this);
    }

    /// <summary>Field number for the "file_path" field.</summary>
    public const int FilePathFieldNumber = 1;
    private string filePath_ = "";
    /// <summary>
    /// Required. The full file path. Example: `gs://bucket_name/a/b.txt`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FilePath {
      get { return filePath_; }
      set {
        filePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gcs_timestamps" field.</summary>
    public const int GcsTimestampsFieldNumber = 2;
    private global::Google.Cloud.DataCatalog.V1.SystemTimestamps gcsTimestamps_;
    /// <summary>
    /// Output only. Timestamps about the Cloud Storage file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataCatalog.V1.SystemTimestamps GcsTimestamps {
      get { return gcsTimestamps_; }
      set {
        gcsTimestamps_ = value;
      }
    }

    /// <summary>Field number for the "size_bytes" field.</summary>
    public const int SizeBytesFieldNumber = 4;
    private long sizeBytes_;
    /// <summary>
    /// Output only. The size of the file, in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SizeBytes {
      get { return sizeBytes_; }
      set {
        sizeBytes_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GcsFileSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GcsFileSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FilePath != other.FilePath) return false;
      if (!object.Equals(GcsTimestamps, other.GcsTimestamps)) return false;
      if (SizeBytes != other.SizeBytes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FilePath.Length != 0) hash ^= FilePath.GetHashCode();
      if (gcsTimestamps_ != null) hash ^= GcsTimestamps.GetHashCode();
      if (SizeBytes != 0L) hash ^= SizeBytes.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (FilePath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FilePath);
      }
      if (gcsTimestamps_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GcsTimestamps);
      }
      if (SizeBytes != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(SizeBytes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FilePath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FilePath);
      }
      if (gcsTimestamps_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GcsTimestamps);
      }
      if (SizeBytes != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(SizeBytes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FilePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FilePath);
      }
      if (gcsTimestamps_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GcsTimestamps);
      }
      if (SizeBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SizeBytes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GcsFileSpec other) {
      if (other == null) {
        return;
      }
      if (other.FilePath.Length != 0) {
        FilePath = other.FilePath;
      }
      if (other.gcsTimestamps_ != null) {
        if (gcsTimestamps_ == null) {
          GcsTimestamps = new global::Google.Cloud.DataCatalog.V1.SystemTimestamps();
        }
        GcsTimestamps.MergeFrom(other.GcsTimestamps);
      }
      if (other.SizeBytes != 0L) {
        SizeBytes = other.SizeBytes;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            FilePath = input.ReadString();
            break;
          }
          case 18: {
            if (gcsTimestamps_ == null) {
              GcsTimestamps = new global::Google.Cloud.DataCatalog.V1.SystemTimestamps();
            }
            input.ReadMessage(GcsTimestamps);
            break;
          }
          case 32: {
            SizeBytes = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            FilePath = input.ReadString();
            break;
          }
          case 18: {
            if (gcsTimestamps_ == null) {
              GcsTimestamps = new global::Google.Cloud.DataCatalog.V1.SystemTimestamps();
            }
            input.ReadMessage(GcsTimestamps);
            break;
          }
          case 32: {
            SizeBytes = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code