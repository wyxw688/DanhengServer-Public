// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DressRelicAvatarCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DressRelicAvatarCsReq.proto</summary>
  public static partial class DressRelicAvatarCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DressRelicAvatarCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DressRelicAvatarCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtEcmVzc1JlbGljQXZhdGFyQ3NSZXEucHJvdG8aFURyZXNzUmVsaWNQYXJh",
            "bS5wcm90byJXChVEcmVzc1JlbGljQXZhdGFyQ3NSZXESFwoPZHJlc3NfYXZh",
            "dGFyX2lkGAIgASgNEiUKC3N3aXRjaF9saXN0GAEgAygLMhAuRHJlc3NSZWxp",
            "Y1BhcmFtQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DressRelicParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DressRelicAvatarCsReq), global::EggLink.DanhengServer.Proto.DressRelicAvatarCsReq.Parser, new[]{ "DressAvatarId", "SwitchList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DressRelicAvatarCsReq : pb::IMessage<DressRelicAvatarCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DressRelicAvatarCsReq> _parser = new pb::MessageParser<DressRelicAvatarCsReq>(() => new DressRelicAvatarCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DressRelicAvatarCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DressRelicAvatarCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DressRelicAvatarCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DressRelicAvatarCsReq(DressRelicAvatarCsReq other) : this() {
      dressAvatarId_ = other.dressAvatarId_;
      switchList_ = other.switchList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DressRelicAvatarCsReq Clone() {
      return new DressRelicAvatarCsReq(this);
    }

    /// <summary>Field number for the "dress_avatar_id" field.</summary>
    public const int DressAvatarIdFieldNumber = 2;
    private uint dressAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DressAvatarId {
      get { return dressAvatarId_; }
      set {
        dressAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "switch_list" field.</summary>
    public const int SwitchListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DressRelicParam> _repeated_switchList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.DressRelicParam.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DressRelicParam> switchList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DressRelicParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DressRelicParam> SwitchList {
      get { return switchList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DressRelicAvatarCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DressRelicAvatarCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DressAvatarId != other.DressAvatarId) return false;
      if(!switchList_.Equals(other.switchList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DressAvatarId != 0) hash ^= DressAvatarId.GetHashCode();
      hash ^= switchList_.GetHashCode();
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
      switchList_.WriteTo(output, _repeated_switchList_codec);
      if (DressAvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DressAvatarId);
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
      switchList_.WriteTo(ref output, _repeated_switchList_codec);
      if (DressAvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DressAvatarId);
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
      if (DressAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DressAvatarId);
      }
      size += switchList_.CalculateSize(_repeated_switchList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DressRelicAvatarCsReq other) {
      if (other == null) {
        return;
      }
      if (other.DressAvatarId != 0) {
        DressAvatarId = other.DressAvatarId;
      }
      switchList_.Add(other.switchList_);
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
            switchList_.AddEntriesFrom(input, _repeated_switchList_codec);
            break;
          }
          case 16: {
            DressAvatarId = input.ReadUInt32();
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
            switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
            break;
          }
          case 16: {
            DressAvatarId = input.ReadUInt32();
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
