// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BEDDPMJHDJB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BEDDPMJHDJB.proto</summary>
  public static partial class BEDDPMJHDJBReflection {

    #region Descriptor
    /// <summary>File descriptor for BEDDPMJHDJB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BEDDPMJHDJBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCRUREUE1KSERKQi5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvIqwBCgtC",
            "RUREUE1KSERKQhILCgN1aWQYASABKA0SDQoFbGV2ZWwYAiABKA0SEAoIbmlj",
            "a25hbWUYAyABKAkSEwoLUEROQUpNQ0xDTlAYBCABKA0SHwoIcGxhdGZvcm0Y",
            "BSABKA4yDS5QbGF0Zm9ybVR5cGUSEwoLQUlPTkFJUEFLSkMYBiABKAkSEwoL",
            "S0JDTlBGRUJHSEoYByABKAkSDwoHdmVyc2lvbhgIIAEoBEIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BEDDPMJHDJB), global::EggLink.DanhengServer.Proto.BEDDPMJHDJB.Parser, new[]{ "Uid", "Level", "Nickname", "PDNAJMCLCNP", "Platform", "AIONAIPAKJC", "KBCNPFEBGHJ", "Version" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BEDDPMJHDJB : pb::IMessage<BEDDPMJHDJB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BEDDPMJHDJB> _parser = new pb::MessageParser<BEDDPMJHDJB>(() => new BEDDPMJHDJB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BEDDPMJHDJB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BEDDPMJHDJBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BEDDPMJHDJB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BEDDPMJHDJB(BEDDPMJHDJB other) : this() {
      uid_ = other.uid_;
      level_ = other.level_;
      nickname_ = other.nickname_;
      pDNAJMCLCNP_ = other.pDNAJMCLCNP_;
      platform_ = other.platform_;
      aIONAIPAKJC_ = other.aIONAIPAKJC_;
      kBCNPFEBGHJ_ = other.kBCNPFEBGHJ_;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BEDDPMJHDJB Clone() {
      return new BEDDPMJHDJB(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 3;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PDNAJMCLCNP" field.</summary>
    public const int PDNAJMCLCNPFieldNumber = 4;
    private uint pDNAJMCLCNP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PDNAJMCLCNP {
      get { return pDNAJMCLCNP_; }
      set {
        pDNAJMCLCNP_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "AIONAIPAKJC" field.</summary>
    public const int AIONAIPAKJCFieldNumber = 6;
    private string aIONAIPAKJC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AIONAIPAKJC {
      get { return aIONAIPAKJC_; }
      set {
        aIONAIPAKJC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "KBCNPFEBGHJ" field.</summary>
    public const int KBCNPFEBGHJFieldNumber = 7;
    private string kBCNPFEBGHJ_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KBCNPFEBGHJ {
      get { return kBCNPFEBGHJ_; }
      set {
        kBCNPFEBGHJ_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 8;
    private ulong version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BEDDPMJHDJB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BEDDPMJHDJB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Level != other.Level) return false;
      if (Nickname != other.Nickname) return false;
      if (PDNAJMCLCNP != other.PDNAJMCLCNP) return false;
      if (Platform != other.Platform) return false;
      if (AIONAIPAKJC != other.AIONAIPAKJC) return false;
      if (KBCNPFEBGHJ != other.KBCNPFEBGHJ) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (PDNAJMCLCNP != 0) hash ^= PDNAJMCLCNP.GetHashCode();
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      if (AIONAIPAKJC.Length != 0) hash ^= AIONAIPAKJC.GetHashCode();
      if (KBCNPFEBGHJ.Length != 0) hash ^= KBCNPFEBGHJ.GetHashCode();
      if (Version != 0UL) hash ^= Version.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (PDNAJMCLCNP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PDNAJMCLCNP);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Platform);
      }
      if (AIONAIPAKJC.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AIONAIPAKJC);
      }
      if (KBCNPFEBGHJ.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(KBCNPFEBGHJ);
      }
      if (Version != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Version);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (PDNAJMCLCNP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PDNAJMCLCNP);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Platform);
      }
      if (AIONAIPAKJC.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AIONAIPAKJC);
      }
      if (KBCNPFEBGHJ.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(KBCNPFEBGHJ);
      }
      if (Version != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Version);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (PDNAJMCLCNP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PDNAJMCLCNP);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (AIONAIPAKJC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AIONAIPAKJC);
      }
      if (KBCNPFEBGHJ.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KBCNPFEBGHJ);
      }
      if (Version != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BEDDPMJHDJB other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.PDNAJMCLCNP != 0) {
        PDNAJMCLCNP = other.PDNAJMCLCNP;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      if (other.AIONAIPAKJC.Length != 0) {
        AIONAIPAKJC = other.AIONAIPAKJC;
      }
      if (other.KBCNPFEBGHJ.Length != 0) {
        KBCNPFEBGHJ = other.KBCNPFEBGHJ;
      }
      if (other.Version != 0UL) {
        Version = other.Version;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            PDNAJMCLCNP = input.ReadUInt32();
            break;
          }
          case 40: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 50: {
            AIONAIPAKJC = input.ReadString();
            break;
          }
          case 58: {
            KBCNPFEBGHJ = input.ReadString();
            break;
          }
          case 64: {
            Version = input.ReadUInt64();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            PDNAJMCLCNP = input.ReadUInt32();
            break;
          }
          case 40: {
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 50: {
            AIONAIPAKJC = input.ReadString();
            break;
          }
          case 58: {
            KBCNPFEBGHJ = input.ReadString();
            break;
          }
          case 64: {
            Version = input.ReadUInt64();
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
