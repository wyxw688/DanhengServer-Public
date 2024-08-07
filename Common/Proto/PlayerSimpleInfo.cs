// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerSimpleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerSimpleInfo.proto</summary>
  public static partial class PlayerSimpleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerSimpleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerSimpleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvGhZBc3Npc3RTaW1wbGVJbmZvLnBy",
            "b3RvGhhGcmllbmRPbmxpbmVTdGF0dXMucHJvdG8aElBsYXRmb3JtVHlwZS5w",
            "cm90byLRAgoQUGxheWVyU2ltcGxlSW5mbxIYChBsYXN0X2FjdGl2ZV90aW1l",
            "GAggASgDEg0KBWxldmVsGAsgASgNEhYKDmNoYXRfYnViYmxlX2lkGAEgASgN",
            "EhMKC0FJT05BSVBBS0pDGA4gASgJEioKDW9ubGluZV9zdGF0dXMYCiABKA4y",
            "Ey5GcmllbmRPbmxpbmVTdGF0dXMSLQoSYXNzaXN0X3NpbXBsZV9saXN0GA8g",
            "AygLMhEuQXNzaXN0U2ltcGxlSW5mbxILCgN1aWQYBSABKA0SEQoJaXNfYmFu",
            "bmVkGAYgASgIEhMKC0VKS05ISkdBSUJNGAIgASgJEhEKCWhlYWRfaWNvbhgH",
            "IAEoDRIfCghwbGF0Zm9ybRgJIAEoDjINLlBsYXRmb3JtVHlwZRIRCglzaWdu",
            "YXR1cmUYAyABKAkSEAoIbmlja25hbWUYBCABKAlCHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AssistSimpleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.FriendOnlineStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerSimpleInfo), global::EggLink.DanhengServer.Proto.PlayerSimpleInfo.Parser, new[]{ "LastActiveTime", "Level", "ChatBubbleId", "AIONAIPAKJC", "OnlineStatus", "AssistSimpleList", "Uid", "IsBanned", "EJKNHJGAIBM", "HeadIcon", "Platform", "Signature", "Nickname" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerSimpleInfo : pb::IMessage<PlayerSimpleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerSimpleInfo> _parser = new pb::MessageParser<PlayerSimpleInfo>(() => new PlayerSimpleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerSimpleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerSimpleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSimpleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSimpleInfo(PlayerSimpleInfo other) : this() {
      lastActiveTime_ = other.lastActiveTime_;
      level_ = other.level_;
      chatBubbleId_ = other.chatBubbleId_;
      aIONAIPAKJC_ = other.aIONAIPAKJC_;
      onlineStatus_ = other.onlineStatus_;
      assistSimpleList_ = other.assistSimpleList_.Clone();
      uid_ = other.uid_;
      isBanned_ = other.isBanned_;
      eJKNHJGAIBM_ = other.eJKNHJGAIBM_;
      headIcon_ = other.headIcon_;
      platform_ = other.platform_;
      signature_ = other.signature_;
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerSimpleInfo Clone() {
      return new PlayerSimpleInfo(this);
    }

    /// <summary>Field number for the "last_active_time" field.</summary>
    public const int LastActiveTimeFieldNumber = 8;
    private long lastActiveTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LastActiveTime {
      get { return lastActiveTime_; }
      set {
        lastActiveTime_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 11;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "chat_bubble_id" field.</summary>
    public const int ChatBubbleIdFieldNumber = 1;
    private uint chatBubbleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChatBubbleId {
      get { return chatBubbleId_; }
      set {
        chatBubbleId_ = value;
      }
    }

    /// <summary>Field number for the "AIONAIPAKJC" field.</summary>
    public const int AIONAIPAKJCFieldNumber = 14;
    private string aIONAIPAKJC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AIONAIPAKJC {
      get { return aIONAIPAKJC_; }
      set {
        aIONAIPAKJC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "online_status" field.</summary>
    public const int OnlineStatusFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.FriendOnlineStatus onlineStatus_ = global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FriendOnlineStatus OnlineStatus {
      get { return onlineStatus_; }
      set {
        onlineStatus_ = value;
      }
    }

    /// <summary>Field number for the "assist_simple_list" field.</summary>
    public const int AssistSimpleListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AssistSimpleInfo> _repeated_assistSimpleList_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.AssistSimpleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistSimpleInfo> assistSimpleList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistSimpleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistSimpleInfo> AssistSimpleList {
      get { return assistSimpleList_; }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 5;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "is_banned" field.</summary>
    public const int IsBannedFieldNumber = 6;
    private bool isBanned_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBanned {
      get { return isBanned_; }
      set {
        isBanned_ = value;
      }
    }

    /// <summary>Field number for the "EJKNHJGAIBM" field.</summary>
    public const int EJKNHJGAIBMFieldNumber = 2;
    private string eJKNHJGAIBM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EJKNHJGAIBM {
      get { return eJKNHJGAIBM_; }
      set {
        eJKNHJGAIBM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "head_icon" field.</summary>
    public const int HeadIconFieldNumber = 7;
    private uint headIcon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadIcon {
      get { return headIcon_; }
      set {
        headIcon_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 3;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 4;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerSimpleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerSimpleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LastActiveTime != other.LastActiveTime) return false;
      if (Level != other.Level) return false;
      if (ChatBubbleId != other.ChatBubbleId) return false;
      if (AIONAIPAKJC != other.AIONAIPAKJC) return false;
      if (OnlineStatus != other.OnlineStatus) return false;
      if(!assistSimpleList_.Equals(other.assistSimpleList_)) return false;
      if (Uid != other.Uid) return false;
      if (IsBanned != other.IsBanned) return false;
      if (EJKNHJGAIBM != other.EJKNHJGAIBM) return false;
      if (HeadIcon != other.HeadIcon) return false;
      if (Platform != other.Platform) return false;
      if (Signature != other.Signature) return false;
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LastActiveTime != 0L) hash ^= LastActiveTime.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (ChatBubbleId != 0) hash ^= ChatBubbleId.GetHashCode();
      if (AIONAIPAKJC.Length != 0) hash ^= AIONAIPAKJC.GetHashCode();
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) hash ^= OnlineStatus.GetHashCode();
      hash ^= assistSimpleList_.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (IsBanned != false) hash ^= IsBanned.GetHashCode();
      if (EJKNHJGAIBM.Length != 0) hash ^= EJKNHJGAIBM.GetHashCode();
      if (HeadIcon != 0) hash ^= HeadIcon.GetHashCode();
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (ChatBubbleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChatBubbleId);
      }
      if (EJKNHJGAIBM.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EJKNHJGAIBM);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Signature);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (IsBanned != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsBanned);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HeadIcon);
      }
      if (LastActiveTime != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(LastActiveTime);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Platform);
      }
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        output.WriteRawTag(80);
        output.WriteEnum((int) OnlineStatus);
      }
      if (Level != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Level);
      }
      if (AIONAIPAKJC.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(AIONAIPAKJC);
      }
      assistSimpleList_.WriteTo(output, _repeated_assistSimpleList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChatBubbleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChatBubbleId);
      }
      if (EJKNHJGAIBM.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EJKNHJGAIBM);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Signature);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (IsBanned != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsBanned);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HeadIcon);
      }
      if (LastActiveTime != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(LastActiveTime);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Platform);
      }
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        output.WriteRawTag(80);
        output.WriteEnum((int) OnlineStatus);
      }
      if (Level != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Level);
      }
      if (AIONAIPAKJC.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(AIONAIPAKJC);
      }
      assistSimpleList_.WriteTo(ref output, _repeated_assistSimpleList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LastActiveTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastActiveTime);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (ChatBubbleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChatBubbleId);
      }
      if (AIONAIPAKJC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AIONAIPAKJC);
      }
      if (OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OnlineStatus);
      }
      size += assistSimpleList_.CalculateSize(_repeated_assistSimpleList_codec);
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (IsBanned != false) {
        size += 1 + 1;
      }
      if (EJKNHJGAIBM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EJKNHJGAIBM);
      }
      if (HeadIcon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadIcon);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerSimpleInfo other) {
      if (other == null) {
        return;
      }
      if (other.LastActiveTime != 0L) {
        LastActiveTime = other.LastActiveTime;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.ChatBubbleId != 0) {
        ChatBubbleId = other.ChatBubbleId;
      }
      if (other.AIONAIPAKJC.Length != 0) {
        AIONAIPAKJC = other.AIONAIPAKJC;
      }
      if (other.OnlineStatus != global::EggLink.DanhengServer.Proto.FriendOnlineStatus.Offline) {
        OnlineStatus = other.OnlineStatus;
      }
      assistSimpleList_.Add(other.assistSimpleList_);
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.IsBanned != false) {
        IsBanned = other.IsBanned;
      }
      if (other.EJKNHJGAIBM.Length != 0) {
        EJKNHJGAIBM = other.EJKNHJGAIBM;
      }
      if (other.HeadIcon != 0) {
        HeadIcon = other.HeadIcon;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
            ChatBubbleId = input.ReadUInt32();
            break;
          }
          case 18: {
            EJKNHJGAIBM = input.ReadString();
            break;
          }
          case 26: {
            Signature = input.ReadString();
            break;
          }
          case 34: {
            Nickname = input.ReadString();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            IsBanned = input.ReadBool();
            break;
          }
          case 56: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 64: {
            LastActiveTime = input.ReadInt64();
            break;
          }
          case 72: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 80: {
            OnlineStatus = (global::EggLink.DanhengServer.Proto.FriendOnlineStatus) input.ReadEnum();
            break;
          }
          case 88: {
            Level = input.ReadUInt32();
            break;
          }
          case 114: {
            AIONAIPAKJC = input.ReadString();
            break;
          }
          case 122: {
            assistSimpleList_.AddEntriesFrom(input, _repeated_assistSimpleList_codec);
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
            ChatBubbleId = input.ReadUInt32();
            break;
          }
          case 18: {
            EJKNHJGAIBM = input.ReadString();
            break;
          }
          case 26: {
            Signature = input.ReadString();
            break;
          }
          case 34: {
            Nickname = input.ReadString();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            IsBanned = input.ReadBool();
            break;
          }
          case 56: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 64: {
            LastActiveTime = input.ReadInt64();
            break;
          }
          case 72: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 80: {
            OnlineStatus = (global::EggLink.DanhengServer.Proto.FriendOnlineStatus) input.ReadEnum();
            break;
          }
          case 88: {
            Level = input.ReadUInt32();
            break;
          }
          case 114: {
            AIONAIPAKJC = input.ReadString();
            break;
          }
          case 122: {
            assistSimpleList_.AddEntriesFrom(ref input, _repeated_assistSimpleList_codec);
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
