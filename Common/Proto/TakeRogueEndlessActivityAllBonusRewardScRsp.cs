// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeRogueEndlessActivityAllBonusRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeRogueEndlessActivityAllBonusRewardScRsp.proto</summary>
  public static partial class TakeRogueEndlessActivityAllBonusRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeRogueEndlessActivityAllBonusRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeRogueEndlessActivityAllBonusRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFUYWtlUm9ndWVFbmRsZXNzQWN0aXZpdHlBbGxCb251c1Jld2FyZFNjUnNw",
            "LnByb3RvGg5JdGVtTGlzdC5wcm90byKDAQorVGFrZVJvZ3VlRW5kbGVzc0Fj",
            "dGl2aXR5QWxsQm9udXNSZXdhcmRTY1JzcBIPCgdyZXRjb2RlGAogASgNEhMK",
            "C0VNTEVGREtJQkpBGAcgASgNEhMKC0hMRE9NSkxPTUlBGAEgAygNEhkKBnJl",
            "d2FyZBgOIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeRogueEndlessActivityAllBonusRewardScRsp), global::EggLink.DanhengServer.Proto.TakeRogueEndlessActivityAllBonusRewardScRsp.Parser, new[]{ "Retcode", "EMLEFDKIBJA", "HLDOMJLOMIA", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeRogueEndlessActivityAllBonusRewardScRsp : pb::IMessage<TakeRogueEndlessActivityAllBonusRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> _parser = new pb::MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp>(() => new TakeRogueEndlessActivityAllBonusRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeRogueEndlessActivityAllBonusRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeRogueEndlessActivityAllBonusRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueEndlessActivityAllBonusRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueEndlessActivityAllBonusRewardScRsp(TakeRogueEndlessActivityAllBonusRewardScRsp other) : this() {
      retcode_ = other.retcode_;
      eMLEFDKIBJA_ = other.eMLEFDKIBJA_;
      hLDOMJLOMIA_ = other.hLDOMJLOMIA_.Clone();
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeRogueEndlessActivityAllBonusRewardScRsp Clone() {
      return new TakeRogueEndlessActivityAllBonusRewardScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "EMLEFDKIBJA" field.</summary>
    public const int EMLEFDKIBJAFieldNumber = 7;
    private uint eMLEFDKIBJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EMLEFDKIBJA {
      get { return eMLEFDKIBJA_; }
      set {
        eMLEFDKIBJA_ = value;
      }
    }

    /// <summary>Field number for the "HLDOMJLOMIA" field.</summary>
    public const int HLDOMJLOMIAFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_hLDOMJLOMIA_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> hLDOMJLOMIA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HLDOMJLOMIA {
      get { return hLDOMJLOMIA_; }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeRogueEndlessActivityAllBonusRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeRogueEndlessActivityAllBonusRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (EMLEFDKIBJA != other.EMLEFDKIBJA) return false;
      if(!hLDOMJLOMIA_.Equals(other.hLDOMJLOMIA_)) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (EMLEFDKIBJA != 0) hash ^= EMLEFDKIBJA.GetHashCode();
      hash ^= hLDOMJLOMIA_.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
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
      hLDOMJLOMIA_.WriteTo(output, _repeated_hLDOMJLOMIA_codec);
      if (EMLEFDKIBJA != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EMLEFDKIBJA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (reward_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Reward);
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
      hLDOMJLOMIA_.WriteTo(ref output, _repeated_hLDOMJLOMIA_codec);
      if (EMLEFDKIBJA != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EMLEFDKIBJA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (reward_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Reward);
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
      if (EMLEFDKIBJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EMLEFDKIBJA);
      }
      size += hLDOMJLOMIA_.CalculateSize(_repeated_hLDOMJLOMIA_codec);
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeRogueEndlessActivityAllBonusRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.EMLEFDKIBJA != 0) {
        EMLEFDKIBJA = other.EMLEFDKIBJA;
      }
      hLDOMJLOMIA_.Add(other.hLDOMJLOMIA_);
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
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
          case 10:
          case 8: {
            hLDOMJLOMIA_.AddEntriesFrom(input, _repeated_hLDOMJLOMIA_codec);
            break;
          }
          case 56: {
            EMLEFDKIBJA = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
          case 10:
          case 8: {
            hLDOMJLOMIA_.AddEntriesFrom(ref input, _repeated_hLDOMJLOMIA_codec);
            break;
          }
          case 56: {
            EMLEFDKIBJA = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
