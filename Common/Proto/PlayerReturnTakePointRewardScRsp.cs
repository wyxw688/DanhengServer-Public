// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnTakePointRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnTakePointRewardScRsp.proto</summary>
  public static partial class PlayerReturnTakePointRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnTakePointRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnTakePointRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl",
            "bUxpc3QucHJvdG8ifQogUGxheWVyUmV0dXJuVGFrZVBvaW50UmV3YXJkU2NS",
            "c3ASDwoHcmV0Y29kZRgFIAEoDRITCgtDUERQSVBHUEVPRBgGIAEoDRIeCgtC",
            "SUJFTUpJTU1HRxgIIAEoCzIJLkl0ZW1MaXN0EhMKC0pJSkxORFBMSkJMGAIg",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp.Parser, new[]{ "Retcode", "CPDPIPGPEOD", "BIBEMJIMMGG", "JIJLNDPLJBL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnTakePointRewardScRsp : pb::IMessage<PlayerReturnTakePointRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnTakePointRewardScRsp> _parser = new pb::MessageParser<PlayerReturnTakePointRewardScRsp>(() => new PlayerReturnTakePointRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnTakePointRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp(PlayerReturnTakePointRewardScRsp other) : this() {
      retcode_ = other.retcode_;
      cPDPIPGPEOD_ = other.cPDPIPGPEOD_;
      bIBEMJIMMGG_ = other.bIBEMJIMMGG_ != null ? other.bIBEMJIMMGG_.Clone() : null;
      jIJLNDPLJBL_ = other.jIJLNDPLJBL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp Clone() {
      return new PlayerReturnTakePointRewardScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CPDPIPGPEOD" field.</summary>
    public const int CPDPIPGPEODFieldNumber = 6;
    private uint cPDPIPGPEOD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CPDPIPGPEOD {
      get { return cPDPIPGPEOD_; }
      set {
        cPDPIPGPEOD_ = value;
      }
    }

    /// <summary>Field number for the "BIBEMJIMMGG" field.</summary>
    public const int BIBEMJIMMGGFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ItemList bIBEMJIMMGG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList BIBEMJIMMGG {
      get { return bIBEMJIMMGG_; }
      set {
        bIBEMJIMMGG_ = value;
      }
    }

    /// <summary>Field number for the "JIJLNDPLJBL" field.</summary>
    public const int JIJLNDPLJBLFieldNumber = 2;
    private uint jIJLNDPLJBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JIJLNDPLJBL {
      get { return jIJLNDPLJBL_; }
      set {
        jIJLNDPLJBL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnTakePointRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnTakePointRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (CPDPIPGPEOD != other.CPDPIPGPEOD) return false;
      if (!object.Equals(BIBEMJIMMGG, other.BIBEMJIMMGG)) return false;
      if (JIJLNDPLJBL != other.JIJLNDPLJBL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CPDPIPGPEOD != 0) hash ^= CPDPIPGPEOD.GetHashCode();
      if (bIBEMJIMMGG_ != null) hash ^= BIBEMJIMMGG.GetHashCode();
      if (JIJLNDPLJBL != 0) hash ^= JIJLNDPLJBL.GetHashCode();
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
      if (JIJLNDPLJBL != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JIJLNDPLJBL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (CPDPIPGPEOD != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CPDPIPGPEOD);
      }
      if (bIBEMJIMMGG_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BIBEMJIMMGG);
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
      if (JIJLNDPLJBL != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JIJLNDPLJBL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (CPDPIPGPEOD != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CPDPIPGPEOD);
      }
      if (bIBEMJIMMGG_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BIBEMJIMMGG);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (CPDPIPGPEOD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CPDPIPGPEOD);
      }
      if (bIBEMJIMMGG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BIBEMJIMMGG);
      }
      if (JIJLNDPLJBL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JIJLNDPLJBL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnTakePointRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CPDPIPGPEOD != 0) {
        CPDPIPGPEOD = other.CPDPIPGPEOD;
      }
      if (other.bIBEMJIMMGG_ != null) {
        if (bIBEMJIMMGG_ == null) {
          BIBEMJIMMGG = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        BIBEMJIMMGG.MergeFrom(other.BIBEMJIMMGG);
      }
      if (other.JIJLNDPLJBL != 0) {
        JIJLNDPLJBL = other.JIJLNDPLJBL;
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
          case 16: {
            JIJLNDPLJBL = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            CPDPIPGPEOD = input.ReadUInt32();
            break;
          }
          case 66: {
            if (bIBEMJIMMGG_ == null) {
              BIBEMJIMMGG = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(BIBEMJIMMGG);
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
          case 16: {
            JIJLNDPLJBL = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            CPDPIPGPEOD = input.ReadUInt32();
            break;
          }
          case 66: {
            if (bIBEMJIMMGG_ == null) {
              BIBEMJIMMGG = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(BIBEMJIMMGG);
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
