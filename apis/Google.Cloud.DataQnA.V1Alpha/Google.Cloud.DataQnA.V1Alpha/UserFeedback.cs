// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dataqna/v1alpha/user_feedback.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DataQnA.V1Alpha {

  /// <summary>Holder for reflection information generated from google/cloud/dataqna/v1alpha/user_feedback.proto</summary>
  public static partial class UserFeedbackReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dataqna/v1alpha/user_feedback.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserFeedbackReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvZGF0YXFuYS92MWFscGhhL3VzZXJfZmVlZGJhY2su",
            "cHJvdG8SHGdvb2dsZS5jbG91ZC5kYXRhcW5hLnYxYWxwaGEaH2dvb2dsZS9h",
            "cGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2Uu",
            "cHJvdG8i2QIKDFVzZXJGZWVkYmFjaxIRCgRuYW1lGAEgASgJQgPgQQISGgoS",
            "ZnJlZV9mb3JtX2ZlZWRiYWNrGAIgASgJEk0KBnJhdGluZxgDIAEoDjI9Lmdv",
            "b2dsZS5jbG91ZC5kYXRhcW5hLnYxYWxwaGEuVXNlckZlZWRiYWNrLlVzZXJG",
            "ZWVkYmFja1JhdGluZyJWChJVc2VyRmVlZGJhY2tSYXRpbmcSJAogVVNFUl9G",
            "RUVEQkFDS19SQVRJTkdfVU5TUEVDSUZJRUQQABIMCghQT1NJVElWRRABEgwK",
            "CE5FR0FUSVZFEAI6c+pBcAojZGF0YXFuYS5nb29nbGVhcGlzLmNvbS9Vc2Vy",
            "RmVlZGJhY2sSSXByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0",
            "aW9ufS9xdWVzdGlvbnMve3F1ZXN0aW9ufS91c2VyRmVlZGJhY2tC3AEKIGNv",
            "bS5nb29nbGUuY2xvdWQuZGF0YXFuYS52MWFscGhhQhFVc2VyRmVlZGJhY2tQ",
            "cm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Nsb3VkL2RhdGFxbmEvdjFhbHBoYTtkYXRhcW5hqgIcR29vZ2xlLkNsb3Vk",
            "LkRhdGFRbkEuVjFBbHBoYcoCHEdvb2dsZVxDbG91ZFxEYXRhUW5BXFYxYWxw",
            "aGHqAh9Hb29nbGU6OkNsb3VkOjpEYXRhUW5BOjpWMWFscGhhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DataQnA.V1Alpha.UserFeedback), global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Parser, new[]{ "Name", "FreeFormFeedback", "Rating" }, null, new[]{ typeof(global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Feedback provided by a user.
  /// </summary>
  public sealed partial class UserFeedback : pb::IMessage<UserFeedback>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserFeedback> _parser = new pb::MessageParser<UserFeedback>(() => new UserFeedback());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserFeedback> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DataQnA.V1Alpha.UserFeedbackReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserFeedback() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserFeedback(UserFeedback other) : this() {
      name_ = other.name_;
      freeFormFeedback_ = other.freeFormFeedback_;
      rating_ = other.rating_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserFeedback Clone() {
      return new UserFeedback(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The unique identifier for the user feedback.
    /// User feedback is a singleton resource on a Question.
    /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "free_form_feedback" field.</summary>
    public const int FreeFormFeedbackFieldNumber = 2;
    private string freeFormFeedback_ = "";
    /// <summary>
    /// Free form user feedback, such as a text box.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FreeFormFeedback {
      get { return freeFormFeedback_; }
      set {
        freeFormFeedback_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rating" field.</summary>
    public const int RatingFieldNumber = 3;
    private global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating rating_ = global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating.Unspecified;
    /// <summary>
    /// The user feedback rating
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating Rating {
      get { return rating_; }
      set {
        rating_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserFeedback);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserFeedback other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (FreeFormFeedback != other.FreeFormFeedback) return false;
      if (Rating != other.Rating) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (FreeFormFeedback.Length != 0) hash ^= FreeFormFeedback.GetHashCode();
      if (Rating != global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating.Unspecified) hash ^= Rating.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (FreeFormFeedback.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FreeFormFeedback);
      }
      if (Rating != global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Rating);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (FreeFormFeedback.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FreeFormFeedback);
      }
      if (Rating != global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Rating);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (FreeFormFeedback.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FreeFormFeedback);
      }
      if (Rating != global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Rating);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserFeedback other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.FreeFormFeedback.Length != 0) {
        FreeFormFeedback = other.FreeFormFeedback;
      }
      if (other.Rating != global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating.Unspecified) {
        Rating = other.Rating;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            FreeFormFeedback = input.ReadString();
            break;
          }
          case 24: {
            Rating = (global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating) input.ReadEnum();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            FreeFormFeedback = input.ReadString();
            break;
          }
          case 24: {
            Rating = (global::Google.Cloud.DataQnA.V1Alpha.UserFeedback.Types.UserFeedbackRating) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the UserFeedback message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumeration of feedback ratings.
      /// </summary>
      public enum UserFeedbackRating {
        /// <summary>
        /// No rating was specified.
        /// </summary>
        [pbr::OriginalName("USER_FEEDBACK_RATING_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The user provided positive feedback.
        /// </summary>
        [pbr::OriginalName("POSITIVE")] Positive = 1,
        /// <summary>
        /// The user provided negative feedback.
        /// </summary>
        [pbr::OriginalName("NEGATIVE")] Negative = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code