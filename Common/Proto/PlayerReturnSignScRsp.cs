// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnSignScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnSignScRsp.proto</summary>
  public static partial class PlayerReturnSignScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnSignScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnSignScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJSZXR1cm5TaWduU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
            "InIKFVBsYXllclJldHVyblNpZ25TY1JzcBIeCgtKREJITkZGRlBHRxgOIAMo",
            "CzIJLkl0ZW1MaXN0EhMKC0NEQUdFREpLQkxOGAEgASgNEhMKC1BHTExHR05K",
            "TklDGAwgAygNEg8KB3JldGNvZGUYDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnSignScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnSignScRsp.Parser, new[]{ "JDBHNFFFPGG", "CDAGEDJKBLN", "PGLLGGNJNIC", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnSignScRsp : pb::IMessage<PlayerReturnSignScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnSignScRsp> _parser = new pb::MessageParser<PlayerReturnSignScRsp>(() => new PlayerReturnSignScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnSignScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnSignScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp(PlayerReturnSignScRsp other) : this() {
      jDBHNFFFPGG_ = other.jDBHNFFFPGG_.Clone();
      cDAGEDJKBLN_ = other.cDAGEDJKBLN_;
      pGLLGGNJNIC_ = other.pGLLGGNJNIC_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp Clone() {
      return new PlayerReturnSignScRsp(this);
    }

    /// <summary>Field number for the "JDBHNFFFPGG" field.</summary>
    public const int JDBHNFFFPGGFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ItemList> _repeated_jDBHNFFFPGG_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.ItemList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> jDBHNFFFPGG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> JDBHNFFFPGG {
      get { return jDBHNFFFPGG_; }
    }

    /// <summary>Field number for the "CDAGEDJKBLN" field.</summary>
    public const int CDAGEDJKBLNFieldNumber = 1;
    private uint cDAGEDJKBLN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDAGEDJKBLN {
      get { return cDAGEDJKBLN_; }
      set {
        cDAGEDJKBLN_ = value;
      }
    }

    /// <summary>Field number for the "PGLLGGNJNIC" field.</summary>
    public const int PGLLGGNJNICFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_pGLLGGNJNIC_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> pGLLGGNJNIC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PGLLGGNJNIC {
      get { return pGLLGGNJNIC_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnSignScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnSignScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jDBHNFFFPGG_.Equals(other.jDBHNFFFPGG_)) return false;
      if (CDAGEDJKBLN != other.CDAGEDJKBLN) return false;
      if(!pGLLGGNJNIC_.Equals(other.pGLLGGNJNIC_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jDBHNFFFPGG_.GetHashCode();
      if (CDAGEDJKBLN != 0) hash ^= CDAGEDJKBLN.GetHashCode();
      hash ^= pGLLGGNJNIC_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (CDAGEDJKBLN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CDAGEDJKBLN);
      }
      pGLLGGNJNIC_.WriteTo(output, _repeated_pGLLGGNJNIC_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      jDBHNFFFPGG_.WriteTo(output, _repeated_jDBHNFFFPGG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CDAGEDJKBLN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CDAGEDJKBLN);
      }
      pGLLGGNJNIC_.WriteTo(ref output, _repeated_pGLLGGNJNIC_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      jDBHNFFFPGG_.WriteTo(ref output, _repeated_jDBHNFFFPGG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += jDBHNFFFPGG_.CalculateSize(_repeated_jDBHNFFFPGG_codec);
      if (CDAGEDJKBLN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDAGEDJKBLN);
      }
      size += pGLLGGNJNIC_.CalculateSize(_repeated_pGLLGGNJNIC_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnSignScRsp other) {
      if (other == null) {
        return;
      }
      jDBHNFFFPGG_.Add(other.jDBHNFFFPGG_);
      if (other.CDAGEDJKBLN != 0) {
        CDAGEDJKBLN = other.CDAGEDJKBLN;
      }
      pGLLGGNJNIC_.Add(other.pGLLGGNJNIC_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            CDAGEDJKBLN = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            pGLLGGNJNIC_.AddEntriesFrom(input, _repeated_pGLLGGNJNIC_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            jDBHNFFFPGG_.AddEntriesFrom(input, _repeated_jDBHNFFFPGG_codec);
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
            CDAGEDJKBLN = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            pGLLGGNJNIC_.AddEntriesFrom(ref input, _repeated_pGLLGGNJNIC_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            jDBHNFFFPGG_.AddEntriesFrom(ref input, _repeated_jDBHNFFFPGG_codec);
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
