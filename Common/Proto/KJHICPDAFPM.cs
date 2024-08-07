// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KJHICPDAFPM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KJHICPDAFPM.proto</summary>
  public static partial class KJHICPDAFPMReflection {

    #region Descriptor
    /// <summary>File descriptor for KJHICPDAFPM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KJHICPDAFPMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLSkhJQ1BEQUZQTS5wcm90byKGAQoLS0pISUNQREFGUE0SEwoLd29ybGRf",
            "bGV2ZWwYBCABKA0SEgoKbW9uc3Rlcl9pZBgPIAEoDRIRCgl0aW1lc3RhbXAY",
            "AyABKAMSEQoJY29uZmlnX2lkGAYgASgNEhMKC09OT09NT0hOR0FFGAIgASgN",
            "EhMKC0NKQ0pOQ05GQ0dGGA4gASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KJHICPDAFPM), global::EggLink.DanhengServer.Proto.KJHICPDAFPM.Parser, new[]{ "WorldLevel", "MonsterId", "Timestamp", "ConfigId", "ONOOMOHNGAE", "CJCJNCNFCGF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KJHICPDAFPM : pb::IMessage<KJHICPDAFPM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KJHICPDAFPM> _parser = new pb::MessageParser<KJHICPDAFPM>(() => new KJHICPDAFPM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KJHICPDAFPM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KJHICPDAFPMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KJHICPDAFPM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KJHICPDAFPM(KJHICPDAFPM other) : this() {
      worldLevel_ = other.worldLevel_;
      monsterId_ = other.monsterId_;
      timestamp_ = other.timestamp_;
      configId_ = other.configId_;
      oNOOMOHNGAE_ = other.oNOOMOHNGAE_;
      cJCJNCNFCGF_ = other.cJCJNCNFCGF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KJHICPDAFPM Clone() {
      return new KJHICPDAFPM(this);
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 4;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 15;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private long timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 6;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "ONOOMOHNGAE" field.</summary>
    public const int ONOOMOHNGAEFieldNumber = 2;
    private uint oNOOMOHNGAE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ONOOMOHNGAE {
      get { return oNOOMOHNGAE_; }
      set {
        oNOOMOHNGAE_ = value;
      }
    }

    /// <summary>Field number for the "CJCJNCNFCGF" field.</summary>
    public const int CJCJNCNFCGFFieldNumber = 14;
    private bool cJCJNCNFCGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CJCJNCNFCGF {
      get { return cJCJNCNFCGF_; }
      set {
        cJCJNCNFCGF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KJHICPDAFPM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KJHICPDAFPM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorldLevel != other.WorldLevel) return false;
      if (MonsterId != other.MonsterId) return false;
      if (Timestamp != other.Timestamp) return false;
      if (ConfigId != other.ConfigId) return false;
      if (ONOOMOHNGAE != other.ONOOMOHNGAE) return false;
      if (CJCJNCNFCGF != other.CJCJNCNFCGF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (ONOOMOHNGAE != 0) hash ^= ONOOMOHNGAE.GetHashCode();
      if (CJCJNCNFCGF != false) hash ^= CJCJNCNFCGF.GetHashCode();
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
      if (ONOOMOHNGAE != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ONOOMOHNGAE);
      }
      if (Timestamp != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Timestamp);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WorldLevel);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ConfigId);
      }
      if (CJCJNCNFCGF != false) {
        output.WriteRawTag(112);
        output.WriteBool(CJCJNCNFCGF);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MonsterId);
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
      if (ONOOMOHNGAE != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ONOOMOHNGAE);
      }
      if (Timestamp != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Timestamp);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WorldLevel);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ConfigId);
      }
      if (CJCJNCNFCGF != false) {
        output.WriteRawTag(112);
        output.WriteBool(CJCJNCNFCGF);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MonsterId);
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
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (Timestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (ONOOMOHNGAE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ONOOMOHNGAE);
      }
      if (CJCJNCNFCGF != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KJHICPDAFPM other) {
      if (other == null) {
        return;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.Timestamp != 0L) {
        Timestamp = other.Timestamp;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.ONOOMOHNGAE != 0) {
        ONOOMOHNGAE = other.ONOOMOHNGAE;
      }
      if (other.CJCJNCNFCGF != false) {
        CJCJNCNFCGF = other.CJCJNCNFCGF;
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
            ONOOMOHNGAE = input.ReadUInt32();
            break;
          }
          case 24: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 32: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 112: {
            CJCJNCNFCGF = input.ReadBool();
            break;
          }
          case 120: {
            MonsterId = input.ReadUInt32();
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
            ONOOMOHNGAE = input.ReadUInt32();
            break;
          }
          case 24: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 32: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 112: {
            CJCJNCNFCGF = input.ReadBool();
            break;
          }
          case 120: {
            MonsterId = input.ReadUInt32();
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
