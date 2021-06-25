// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/prediction/classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/prediction/classification.proto</summary>
  public static partial class ClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/prediction/classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9w",
            "cmVkaWN0aW9uL2NsYXNzaWZpY2F0aW9uLnByb3RvEjRnb29nbGUuY2xvdWQu",
            "YWlwbGF0Zm9ybS52MS5zY2hlbWEucHJlZGljdC5wcmVkaWN0aW9uGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIlkKHkNsYXNzaWZpY2F0aW9uUHJl",
            "ZGljdGlvblJlc3VsdBILCgNpZHMYASADKAMSFQoNZGlzcGxheV9uYW1lcxgC",
            "IAMoCRITCgtjb25maWRlbmNlcxgDIAMoAkLsAgo4Y29tLmdvb2dsZS5jbG91",
            "ZC5haXBsYXRmb3JtLnYxLnNjaGVtYS5wcmVkaWN0LnByZWRpY3Rpb25CI0Ns",
            "YXNzaWZpY2F0aW9uUHJlZGljdGlvblJlc3VsdFByb3RvUAFaXmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0Zm9y",
            "bS92MS9zY2hlbWEvcHJlZGljdC9wcmVkaWN0aW9uO3ByZWRpY3Rpb26qAjRH",
            "b29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMS5TY2hlbWEuUHJlZGljdC5QcmVk",
            "aWN0aW9uygI0R29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjFcU2NoZW1hXFBy",
            "ZWRpY3RcUHJlZGljdGlvbuoCOkdvb2dsZTo6Q2xvdWQ6OkFJUGxhdGZvcm06",
            "OlYxOjpTY2hlbWE6OlByZWRpY3Q6OlByZWRpY3Rpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.ClassificationPredictionResult), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.ClassificationPredictionResult.Parser, new[]{ "Ids", "DisplayNames", "Confidences" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction output format for Image and Text Classification.
  /// </summary>
  public sealed partial class ClassificationPredictionResult : pb::IMessage<ClassificationPredictionResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClassificationPredictionResult> _parser = new pb::MessageParser<ClassificationPredictionResult>(() => new ClassificationPredictionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClassificationPredictionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Prediction.ClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassificationPredictionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassificationPredictionResult(ClassificationPredictionResult other) : this() {
      ids_ = other.ids_.Clone();
      displayNames_ = other.displayNames_.Clone();
      confidences_ = other.confidences_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassificationPredictionResult Clone() {
      return new ClassificationPredictionResult(this);
    }

    /// <summary>Field number for the "ids" field.</summary>
    public const int IdsFieldNumber = 1;
    private static readonly pb::FieldCodec<long> _repeated_ids_codec
        = pb::FieldCodec.ForInt64(10);
    private readonly pbc::RepeatedField<long> ids_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// The resource IDs of the AnnotationSpecs that had been identified, ordered
    /// by the confidence score descendingly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> Ids {
      get { return ids_; }
    }

    /// <summary>Field number for the "display_names" field.</summary>
    public const int DisplayNamesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_displayNames_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> displayNames_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The display names of the AnnotationSpecs that had been identified, order
    /// matches the IDs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DisplayNames {
      get { return displayNames_; }
    }

    /// <summary>Field number for the "confidences" field.</summary>
    public const int ConfidencesFieldNumber = 3;
    private static readonly pb::FieldCodec<float> _repeated_confidences_codec
        = pb::FieldCodec.ForFloat(26);
    private readonly pbc::RepeatedField<float> confidences_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// The Model's confidences in correctness of the predicted IDs, higher value
    /// means higher confidence. Order matches the Ids.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Confidences {
      get { return confidences_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClassificationPredictionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClassificationPredictionResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!ids_.Equals(other.ids_)) return false;
      if(!displayNames_.Equals(other.displayNames_)) return false;
      if(!confidences_.Equals(other.confidences_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ids_.GetHashCode();
      hash ^= displayNames_.GetHashCode();
      hash ^= confidences_.GetHashCode();
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
      ids_.WriteTo(output, _repeated_ids_codec);
      displayNames_.WriteTo(output, _repeated_displayNames_codec);
      confidences_.WriteTo(output, _repeated_confidences_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      ids_.WriteTo(ref output, _repeated_ids_codec);
      displayNames_.WriteTo(ref output, _repeated_displayNames_codec);
      confidences_.WriteTo(ref output, _repeated_confidences_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += ids_.CalculateSize(_repeated_ids_codec);
      size += displayNames_.CalculateSize(_repeated_displayNames_codec);
      size += confidences_.CalculateSize(_repeated_confidences_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClassificationPredictionResult other) {
      if (other == null) {
        return;
      }
      ids_.Add(other.ids_);
      displayNames_.Add(other.displayNames_);
      confidences_.Add(other.confidences_);
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
          case 10:
          case 8: {
            ids_.AddEntriesFrom(input, _repeated_ids_codec);
            break;
          }
          case 18: {
            displayNames_.AddEntriesFrom(input, _repeated_displayNames_codec);
            break;
          }
          case 26:
          case 29: {
            confidences_.AddEntriesFrom(input, _repeated_confidences_codec);
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
          case 10:
          case 8: {
            ids_.AddEntriesFrom(ref input, _repeated_ids_codec);
            break;
          }
          case 18: {
            displayNames_.AddEntriesFrom(ref input, _repeated_displayNames_codec);
            break;
          }
          case 26:
          case 29: {
            confidences_.AddEntriesFrom(ref input, _repeated_confidences_codec);
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
