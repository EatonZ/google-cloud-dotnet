// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/data_item.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/data_item.proto</summary>
  public static partial class DataItemReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/data_item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9kYXRhX2l0ZW0ucHJvdG8S",
            "Gmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGhxn",
            "b29nbGUvcHJvdG9idWYvc3RydWN0LnByb3RvGh9nb29nbGUvcHJvdG9idWYv",
            "dGltZXN0YW1wLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "IrsDCghEYXRhSXRlbRIRCgRuYW1lGAEgASgJQgPgQQMSNAoLY3JlYXRlX3Rp",
            "bWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSNAoL",
            "dXBkYXRlX3RpbWUYBiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "QgPgQQMSRQoGbGFiZWxzGAMgAygLMjAuZ29vZ2xlLmNsb3VkLmFpcGxhdGZv",
            "cm0udjEuRGF0YUl0ZW0uTGFiZWxzRW50cnlCA+BBARIsCgdwYXlsb2FkGAQg",
            "ASgLMhYuZ29vZ2xlLnByb3RvYnVmLlZhbHVlQgPgQQISEQoEZXRhZxgHIAEo",
            "CUID4EEBGi0KC0xhYmVsc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgC",
            "IAEoCToCOAE6eepBdgoiYWlwbGF0Zm9ybS5nb29nbGVhcGlzLmNvbS9EYXRh",
            "SXRlbRJQcHJvamVjdHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9jYXRpb259",
            "L2RhdGFzZXRzL3tkYXRhc2V0fS9kYXRhSXRlbXMve2RhdGFfaXRlbX1C0QEK",
            "HmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUINRGF0YUl0ZW1Qcm90",
            "b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL2FpcGxhdGZvcm0vdjE7YWlwbGF0Zm9ybaoCGkdvb2dsZS5DbG91ZC5B",
            "SVBsYXRmb3JtLlYxygIaR29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjHqAh1H",
            "b29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.DataItem), global::Google.Cloud.AIPlatform.V1.DataItem.Parser, new[]{ "Name", "CreateTime", "UpdateTime", "Labels", "Payload", "Etag" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A piece of data in a Dataset. Could be an image, a video, a document or plain
  /// text.
  /// </summary>
  public sealed partial class DataItem : pb::IMessage<DataItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataItem> _parser = new pb::MessageParser<DataItem>(() => new DataItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DataItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.DataItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataItem(DataItem other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      etag_ = other.etag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataItem Clone() {
      return new DataItem(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the DataItem.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this DataItem was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this DataItem was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 26);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your DataItems.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// No more than 64 user labels can be associated with one DataItem(System
    /// labels are excluded).
    ///
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// System reserved label keys are prefixed with "aiplatform.googleapis.com/"
    /// and are immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Value payload_;
    /// <summary>
    /// Required. The data that the DataItem represents (for example, an image or a text
    /// snippet). The schema of the payload is stored in the parent Dataset's
    /// [metadata schema's][google.cloud.aiplatform.v1.Dataset.metadata_schema_uri] dataItemSchemaUri field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Value Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 7;
    private string etag_ = "";
    /// <summary>
    /// Optional. Used to perform consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DataItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DataItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      if (Etag != other.Etag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
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
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (payload_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Payload);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
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
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (payload_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Payload);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Etag);
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
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DataItem other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      labels_.Add(other.labels_);
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::Google.Protobuf.WellKnownTypes.Value();
        }
        Payload.MergeFrom(other.Payload);
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 34: {
            if (payload_ == null) {
              Payload = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Payload);
            break;
          }
          case 50: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 58: {
            Etag = input.ReadString();
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 34: {
            if (payload_ == null) {
              Payload = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Payload);
            break;
          }
          case 50: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 58: {
            Etag = input.ReadString();
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
