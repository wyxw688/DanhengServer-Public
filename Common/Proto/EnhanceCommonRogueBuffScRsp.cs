// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnhanceCommonRogueBuffScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnhanceCommonRogueBuffScRsp.proto</summary>
  public static partial class EnhanceCommonRogueBuffScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnhanceCommonRogueBuffScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnhanceCommonRogueBuffScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbmhhbmNlQ29tbW9uUm9ndWVCdWZmU2NSc3AucHJvdG8aFVJvZ3VlQ29t",
            "bW9uQnVmZi5wcm90byJoChtFbmhhbmNlQ29tbW9uUm9ndWVCdWZmU2NSc3AS",
            "EgoKaXNfc3VjY2VzcxgOIAEoCBIPCgdyZXRjb2RlGAwgASgNEiQKCnJvZ3Vl",
            "X2J1ZmYYBiABKAsyEC5Sb2d1ZUNvbW1vbkJ1ZmZCHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnhanceCommonRogueBuffScRsp), global::EggLink.DanhengServer.Proto.EnhanceCommonRogueBuffScRsp.Parser, new[]{ "IsSuccess", "Retcode", "RogueBuff" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnhanceCommonRogueBuffScRsp : pb::IMessage<EnhanceCommonRogueBuffScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnhanceCommonRogueBuffScRsp> _parser = new pb::MessageParser<EnhanceCommonRogueBuffScRsp>(() => new EnhanceCommonRogueBuffScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnhanceCommonRogueBuffScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnhanceCommonRogueBuffScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnhanceCommonRogueBuffScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnhanceCommonRogueBuffScRsp(EnhanceCommonRogueBuffScRsp other) : this() {
      isSuccess_ = other.isSuccess_;
      retcode_ = other.retcode_;
      rogueBuff_ = other.rogueBuff_ != null ? other.rogueBuff_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnhanceCommonRogueBuffScRsp Clone() {
      return new EnhanceCommonRogueBuffScRsp(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 14;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_buff" field.</summary>
    public const int RogueBuffFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueCommonBuff rogueBuff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonBuff RogueBuff {
      get { return rogueBuff_; }
      set {
        rogueBuff_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnhanceCommonRogueBuffScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnhanceCommonRogueBuffScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RogueBuff, other.RogueBuff)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rogueBuff_ != null) hash ^= RogueBuff.GetHashCode();
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
      if (rogueBuff_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuff);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsSuccess);
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
      if (rogueBuff_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuff);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsSuccess);
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
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (rogueBuff_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuff);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnhanceCommonRogueBuffScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rogueBuff_ != null) {
        if (rogueBuff_ == null) {
          RogueBuff = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
        }
        RogueBuff.MergeFrom(other.RogueBuff);
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
          case 50: {
            if (rogueBuff_ == null) {
              RogueBuff = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
            }
            input.ReadMessage(RogueBuff);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            IsSuccess = input.ReadBool();
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
          case 50: {
            if (rogueBuff_ == null) {
              RogueBuff = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
            }
            input.ReadMessage(RogueBuff);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 112: {
            IsSuccess = input.ReadBool();
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
