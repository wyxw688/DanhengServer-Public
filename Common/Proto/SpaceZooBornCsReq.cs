// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooBornCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooBornCsReq.proto</summary>
  public static partial class SpaceZooBornCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooBornCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooBornCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTcGFjZVpvb0Jvcm5Dc1JlcS5wcm90byI9ChFTcGFjZVpvb0Jvcm5Dc1Jl",
            "cRITCgtJT0ZLQkxKTUtFQRgCIAMoDRITCgtFTkFFREJLQUtFTBgBIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooBornCsReq), global::EggLink.DanhengServer.Proto.SpaceZooBornCsReq.Parser, new[]{ "IOFKBLJMKEA", "ENAEDBKAKEL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooBornCsReq : pb::IMessage<SpaceZooBornCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooBornCsReq> _parser = new pb::MessageParser<SpaceZooBornCsReq>(() => new SpaceZooBornCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooBornCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooBornCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornCsReq(SpaceZooBornCsReq other) : this() {
      iOFKBLJMKEA_ = other.iOFKBLJMKEA_.Clone();
      eNAEDBKAKEL_ = other.eNAEDBKAKEL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooBornCsReq Clone() {
      return new SpaceZooBornCsReq(this);
    }

    /// <summary>Field number for the "IOFKBLJMKEA" field.</summary>
    public const int IOFKBLJMKEAFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_iOFKBLJMKEA_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> iOFKBLJMKEA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IOFKBLJMKEA {
      get { return iOFKBLJMKEA_; }
    }

    /// <summary>Field number for the "ENAEDBKAKEL" field.</summary>
    public const int ENAEDBKAKELFieldNumber = 1;
    private uint eNAEDBKAKEL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ENAEDBKAKEL {
      get { return eNAEDBKAKEL_; }
      set {
        eNAEDBKAKEL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooBornCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooBornCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!iOFKBLJMKEA_.Equals(other.iOFKBLJMKEA_)) return false;
      if (ENAEDBKAKEL != other.ENAEDBKAKEL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= iOFKBLJMKEA_.GetHashCode();
      if (ENAEDBKAKEL != 0) hash ^= ENAEDBKAKEL.GetHashCode();
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
      if (ENAEDBKAKEL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ENAEDBKAKEL);
      }
      iOFKBLJMKEA_.WriteTo(output, _repeated_iOFKBLJMKEA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ENAEDBKAKEL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ENAEDBKAKEL);
      }
      iOFKBLJMKEA_.WriteTo(ref output, _repeated_iOFKBLJMKEA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += iOFKBLJMKEA_.CalculateSize(_repeated_iOFKBLJMKEA_codec);
      if (ENAEDBKAKEL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ENAEDBKAKEL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooBornCsReq other) {
      if (other == null) {
        return;
      }
      iOFKBLJMKEA_.Add(other.iOFKBLJMKEA_);
      if (other.ENAEDBKAKEL != 0) {
        ENAEDBKAKEL = other.ENAEDBKAKEL;
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
            ENAEDBKAKEL = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            iOFKBLJMKEA_.AddEntriesFrom(input, _repeated_iOFKBLJMKEA_codec);
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
            ENAEDBKAKEL = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            iOFKBLJMKEA_.AddEntriesFrom(ref input, _repeated_iOFKBLJMKEA_codec);
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
