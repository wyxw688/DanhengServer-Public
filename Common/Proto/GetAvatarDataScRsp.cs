// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAvatarDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAvatarDataScRsp.proto</summary>
  public static partial class GetAvatarDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAvatarDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAvatarDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHZXRBdmF0YXJEYXRhU2NSc3AucHJvdG8aDEF2YXRhci5wcm90byJsChJH",
            "ZXRBdmF0YXJEYXRhU2NSc3ASEwoLREJFSkpLTU5PUEYYBSADKA0SEgoKaXNf",
            "Z2V0X2FsbBgDIAEoCBIPCgdyZXRjb2RlGAcgASgNEhwKC2F2YXRhcl9saXN0",
            "GAkgAygLMgcuQXZhdGFyQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAvatarDataScRsp), global::EggLink.DanhengServer.Proto.GetAvatarDataScRsp.Parser, new[]{ "DBEJJKMNOPF", "IsGetAll", "Retcode", "AvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAvatarDataScRsp : pb::IMessage<GetAvatarDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAvatarDataScRsp> _parser = new pb::MessageParser<GetAvatarDataScRsp>(() => new GetAvatarDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAvatarDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAvatarDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAvatarDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAvatarDataScRsp(GetAvatarDataScRsp other) : this() {
      dBEJJKMNOPF_ = other.dBEJJKMNOPF_.Clone();
      isGetAll_ = other.isGetAll_;
      retcode_ = other.retcode_;
      avatarList_ = other.avatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAvatarDataScRsp Clone() {
      return new GetAvatarDataScRsp(this);
    }

    /// <summary>Field number for the "DBEJJKMNOPF" field.</summary>
    public const int DBEJJKMNOPFFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_dBEJJKMNOPF_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> dBEJJKMNOPF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DBEJJKMNOPF {
      get { return dBEJJKMNOPF_; }
    }

    /// <summary>Field number for the "is_get_all" field.</summary>
    public const int IsGetAllFieldNumber = 3;
    private bool isGetAll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGetAll {
      get { return isGetAll_; }
      set {
        isGetAll_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Avatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.Avatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Avatar> avatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Avatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Avatar> AvatarList {
      get { return avatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAvatarDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAvatarDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!dBEJJKMNOPF_.Equals(other.dBEJJKMNOPF_)) return false;
      if (IsGetAll != other.IsGetAll) return false;
      if (Retcode != other.Retcode) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= dBEJJKMNOPF_.GetHashCode();
      if (IsGetAll != false) hash ^= IsGetAll.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= avatarList_.GetHashCode();
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
      if (IsGetAll != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsGetAll);
      }
      dBEJJKMNOPF_.WriteTo(output, _repeated_dBEJJKMNOPF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsGetAll != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsGetAll);
      }
      dBEJJKMNOPF_.WriteTo(ref output, _repeated_dBEJJKMNOPF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += dBEJJKMNOPF_.CalculateSize(_repeated_dBEJJKMNOPF_codec);
      if (IsGetAll != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAvatarDataScRsp other) {
      if (other == null) {
        return;
      }
      dBEJJKMNOPF_.Add(other.dBEJJKMNOPF_);
      if (other.IsGetAll != false) {
        IsGetAll = other.IsGetAll;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      avatarList_.Add(other.avatarList_);
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
          case 24: {
            IsGetAll = input.ReadBool();
            break;
          }
          case 42:
          case 40: {
            dBEJJKMNOPF_.AddEntriesFrom(input, _repeated_dBEJJKMNOPF_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
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
          case 24: {
            IsGetAll = input.ReadBool();
            break;
          }
          case 42:
          case 40: {
            dBEJJKMNOPF_.AddEntriesFrom(ref input, _repeated_dBEJJKMNOPF_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
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
