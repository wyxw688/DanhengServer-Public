// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetTrialActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetTrialActivityDataScRsp.proto</summary>
  public static partial class GetTrialActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetTrialActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetTrialActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRUcmlhbEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhdUcmlhbEFjdGl2",
            "aXR5SW5mby5wcm90byJqChlHZXRUcmlhbEFjdGl2aXR5RGF0YVNjUnNwEhMK",
            "C0xFUExFQkZJT0JQGAggASgNEg8KB3JldGNvZGUYCSABKA0SJwoLQ01DUEdO",
            "UEFCTkQYCyADKAsyEi5UcmlhbEFjdGl2aXR5SW5mb0IeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TrialActivityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetTrialActivityDataScRsp), global::EggLink.DanhengServer.Proto.GetTrialActivityDataScRsp.Parser, new[]{ "LEPLEBFIOBP", "Retcode", "CMCPGNPABND" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetTrialActivityDataScRsp : pb::IMessage<GetTrialActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetTrialActivityDataScRsp> _parser = new pb::MessageParser<GetTrialActivityDataScRsp>(() => new GetTrialActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetTrialActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetTrialActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetTrialActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetTrialActivityDataScRsp(GetTrialActivityDataScRsp other) : this() {
      lEPLEBFIOBP_ = other.lEPLEBFIOBP_;
      retcode_ = other.retcode_;
      cMCPGNPABND_ = other.cMCPGNPABND_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetTrialActivityDataScRsp Clone() {
      return new GetTrialActivityDataScRsp(this);
    }

    /// <summary>Field number for the "LEPLEBFIOBP" field.</summary>
    public const int LEPLEBFIOBPFieldNumber = 8;
    private uint lEPLEBFIOBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LEPLEBFIOBP {
      get { return lEPLEBFIOBP_; }
      set {
        lEPLEBFIOBP_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CMCPGNPABND" field.</summary>
    public const int CMCPGNPABNDFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TrialActivityInfo> _repeated_cMCPGNPABND_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.TrialActivityInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrialActivityInfo> cMCPGNPABND_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrialActivityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TrialActivityInfo> CMCPGNPABND {
      get { return cMCPGNPABND_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetTrialActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetTrialActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LEPLEBFIOBP != other.LEPLEBFIOBP) return false;
      if (Retcode != other.Retcode) return false;
      if(!cMCPGNPABND_.Equals(other.cMCPGNPABND_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LEPLEBFIOBP != 0) hash ^= LEPLEBFIOBP.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= cMCPGNPABND_.GetHashCode();
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
      if (LEPLEBFIOBP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LEPLEBFIOBP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      cMCPGNPABND_.WriteTo(output, _repeated_cMCPGNPABND_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LEPLEBFIOBP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LEPLEBFIOBP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      cMCPGNPABND_.WriteTo(ref output, _repeated_cMCPGNPABND_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LEPLEBFIOBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LEPLEBFIOBP);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += cMCPGNPABND_.CalculateSize(_repeated_cMCPGNPABND_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetTrialActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.LEPLEBFIOBP != 0) {
        LEPLEBFIOBP = other.LEPLEBFIOBP;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      cMCPGNPABND_.Add(other.cMCPGNPABND_);
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
          case 64: {
            LEPLEBFIOBP = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            cMCPGNPABND_.AddEntriesFrom(input, _repeated_cMCPGNPABND_codec);
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
          case 64: {
            LEPLEBFIOBP = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            cMCPGNPABND_.AddEntriesFrom(ref input, _repeated_cMCPGNPABND_codec);
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
