// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/weatherForecast.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServiceDemo {

  /// <summary>Holder for reflection information generated from Protos/weatherForecast.proto</summary>
  public static partial class WeatherForecastReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/weatherForecast.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherForecastReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQcm90b3Mvd2VhdGhlckZvcmVjYXN0LnByb3RvEg53ZWF0aGVyRm9yY2Fz",
            "dBofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxobZ29vZ2xlL3By",
            "b3RvYnVmL2VtcHR5LnByb3RvIkcKFFdlYXRoZXJGb3JlY2FzdFJlcGx5Ei8K",
            "BlJlc3VsdBgBIAMoCzIfLndlYXRoZXJGb3JjYXN0LldlYXRoZXJGb3JlY2Fz",
            "dCJ4Cg9XZWF0aGVyRm9yZWNhc3QSKAoERGF0ZRgBIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5UaW1lc3RhbXASFAoMVGVtcGVyYXR1cmVDGAIgASgFEhQKDFRl",
            "bXBlcmF0dXJlRhgDIAEoBRIPCgdTdW1tYXJ5GAQgASgJIh4KDVN0cmVhbU1l",
            "c3NhZ2USDQoFaW5kZXgYASABKAUy6QMKDldlYXRoZXJGb3JjYXN0ElIKEkdl",
            "dFdlYXRoZXJGb3JlY2FzdBIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRokLndl",
            "YXRoZXJGb3JjYXN0LldlYXRoZXJGb3JlY2FzdFJlcGx5El0KGUdldFdlYXRo",
            "ZXJGb3JlY2FzdEZvckRhdGUSGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "GiQud2VhdGhlckZvcmNhc3QuV2VhdGhlckZvcmVjYXN0UmVwbHkSVQoYR2V0",
            "V2VhdGhlckZvcmVjYXN0U3RyZWFtEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
            "Gh8ud2VhdGhlckZvcmNhc3QuV2VhdGhlckZvcmVjYXN0MAESZwoeR2V0V2Vh",
            "dGhlckZvcmVjYXN0Q2xpZW50U3RyZWFtEh0ud2VhdGhlckZvcmNhc3QuU3Ry",
            "ZWFtTWVzc2FnZRokLndlYXRoZXJGb3JjYXN0LldlYXRoZXJGb3JlY2FzdFJl",
            "cGx5KAESZAoeR2V0V2VhdGhlckZvcmVjYXN0RHVwbGV4U3RyZWFtEh0ud2Vh",
            "dGhlckZvcmNhc3QuU3RyZWFtTWVzc2FnZRofLndlYXRoZXJGb3JjYXN0Lldl",
            "YXRoZXJGb3JlY2FzdCgBMAFCEqoCD0dycGNTZXJ2aWNlRGVtb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceDemo.WeatherForecastReply), global::GrpcServiceDemo.WeatherForecastReply.Parser, new[]{ "Result" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceDemo.WeatherForecast), global::GrpcServiceDemo.WeatherForecast.Parser, new[]{ "Date", "TemperatureC", "TemperatureF", "Summary" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServiceDemo.StreamMessage), global::GrpcServiceDemo.StreamMessage.Parser, new[]{ "Index" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The response message containing the weather information.
  /// </summary>
  public sealed partial class WeatherForecastReply : pb::IMessage<WeatherForecastReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeatherForecastReply> _parser = new pb::MessageParser<WeatherForecastReply>(() => new WeatherForecastReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WeatherForecastReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceDemo.WeatherForecastReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeatherForecastReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeatherForecastReply(WeatherForecastReply other) : this() {
      result_ = other.result_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeatherForecastReply Clone() {
      return new WeatherForecastReply(this);
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcServiceDemo.WeatherForecast> _repeated_result_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcServiceDemo.WeatherForecast.Parser);
    private readonly pbc::RepeatedField<global::GrpcServiceDemo.WeatherForecast> result_ = new pbc::RepeatedField<global::GrpcServiceDemo.WeatherForecast>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::GrpcServiceDemo.WeatherForecast> Result {
      get { return result_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WeatherForecastReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WeatherForecastReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!result_.Equals(other.result_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= result_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      result_.WriteTo(output, _repeated_result_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      result_.WriteTo(ref output, _repeated_result_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += result_.CalculateSize(_repeated_result_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WeatherForecastReply other) {
      if (other == null) {
        return;
      }
      result_.Add(other.result_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            result_.AddEntriesFrom(input, _repeated_result_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            result_.AddEntriesFrom(ref input, _repeated_result_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class WeatherForecast : pb::IMessage<WeatherForecast>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeatherForecast> _parser = new pb::MessageParser<WeatherForecast>(() => new WeatherForecast());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WeatherForecast> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceDemo.WeatherForecastReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeatherForecast() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeatherForecast(WeatherForecast other) : this() {
      date_ = other.date_ != null ? other.date_.Clone() : null;
      temperatureC_ = other.temperatureC_;
      temperatureF_ = other.temperatureF_;
      summary_ = other.summary_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeatherForecast Clone() {
      return new WeatherForecast(this);
    }

    /// <summary>Field number for the "Date" field.</summary>
    public const int DateFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "TemperatureC" field.</summary>
    public const int TemperatureCFieldNumber = 2;
    private int temperatureC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TemperatureC {
      get { return temperatureC_; }
      set {
        temperatureC_ = value;
      }
    }

    /// <summary>Field number for the "TemperatureF" field.</summary>
    public const int TemperatureFFieldNumber = 3;
    private int temperatureF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TemperatureF {
      get { return temperatureF_; }
      set {
        temperatureF_ = value;
      }
    }

    /// <summary>Field number for the "Summary" field.</summary>
    public const int SummaryFieldNumber = 4;
    private string summary_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Summary {
      get { return summary_; }
      set {
        summary_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WeatherForecast);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WeatherForecast other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Date, other.Date)) return false;
      if (TemperatureC != other.TemperatureC) return false;
      if (TemperatureF != other.TemperatureF) return false;
      if (Summary != other.Summary) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (date_ != null) hash ^= Date.GetHashCode();
      if (TemperatureC != 0) hash ^= TemperatureC.GetHashCode();
      if (TemperatureF != 0) hash ^= TemperatureF.GetHashCode();
      if (Summary.Length != 0) hash ^= Summary.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (date_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Date);
      }
      if (TemperatureC != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TemperatureC);
      }
      if (TemperatureF != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TemperatureF);
      }
      if (Summary.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Summary);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (date_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Date);
      }
      if (TemperatureC != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TemperatureC);
      }
      if (TemperatureF != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TemperatureF);
      }
      if (Summary.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Summary);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      if (TemperatureC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TemperatureC);
      }
      if (TemperatureF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TemperatureF);
      }
      if (Summary.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Summary);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WeatherForecast other) {
      if (other == null) {
        return;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Date.MergeFrom(other.Date);
      }
      if (other.TemperatureC != 0) {
        TemperatureC = other.TemperatureC;
      }
      if (other.TemperatureF != 0) {
        TemperatureF = other.TemperatureF;
      }
      if (other.Summary.Length != 0) {
        Summary = other.Summary;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            if (date_ == null) {
              Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Date);
            break;
          }
          case 16: {
            TemperatureC = input.ReadInt32();
            break;
          }
          case 24: {
            TemperatureF = input.ReadInt32();
            break;
          }
          case 34: {
            Summary = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (date_ == null) {
              Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Date);
            break;
          }
          case 16: {
            TemperatureC = input.ReadInt32();
            break;
          }
          case 24: {
            TemperatureF = input.ReadInt32();
            break;
          }
          case 34: {
            Summary = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class StreamMessage : pb::IMessage<StreamMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StreamMessage> _parser = new pb::MessageParser<StreamMessage>(() => new StreamMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StreamMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServiceDemo.WeatherForecastReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StreamMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StreamMessage(StreamMessage other) : this() {
      index_ = other.index_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StreamMessage Clone() {
      return new StreamMessage(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StreamMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StreamMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StreamMessage other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 8: {
            Index = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Index = input.ReadInt32();
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