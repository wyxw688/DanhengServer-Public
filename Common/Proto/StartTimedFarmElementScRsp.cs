// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartTimedFarmElementScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartTimedFarmElementScRsp.proto</summary>
  public static partial class StartTimedFarmElementScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartTimedFarmElementScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartTimedFarmElementScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTdGFydFRpbWVkRmFybUVsZW1lbnRTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
            "bGVJbmZvLnByb3RvIn4KGlN0YXJ0VGltZWRGYXJtRWxlbWVudFNjUnNwEhMK",
            "C3dvcmxkX2xldmVsGAkgASgNEhMKC0xGRkNDSURPT0VKGAQgASgNEg8KB3Jl",
            "dGNvZGUYCiABKA0SJQoLYmF0dGxlX2luZm8YDiABKAsyEC5TY2VuZUJhdHRs",
            "ZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartTimedFarmElementScRsp), global::EggLink.DanhengServer.Proto.StartTimedFarmElementScRsp.Parser, new[]{ "WorldLevel", "LFFCCIDOOEJ", "Retcode", "BattleInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartTimedFarmElementScRsp : pb::IMessage<StartTimedFarmElementScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartTimedFarmElementScRsp> _parser = new pb::MessageParser<StartTimedFarmElementScRsp>(() => new StartTimedFarmElementScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartTimedFarmElementScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartTimedFarmElementScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTimedFarmElementScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTimedFarmElementScRsp(StartTimedFarmElementScRsp other) : this() {
      worldLevel_ = other.worldLevel_;
      lFFCCIDOOEJ_ = other.lFFCCIDOOEJ_;
      retcode_ = other.retcode_;
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTimedFarmElementScRsp Clone() {
      return new StartTimedFarmElementScRsp(this);
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 9;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "LFFCCIDOOEJ" field.</summary>
    public const int LFFCCIDOOEJFieldNumber = 4;
    private uint lFFCCIDOOEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LFFCCIDOOEJ {
      get { return lFFCCIDOOEJ_; }
      set {
        lFFCCIDOOEJ_ = value;
      }
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

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.SceneBattleInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneBattleInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartTimedFarmElementScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartTimedFarmElementScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorldLevel != other.WorldLevel) return false;
      if (LFFCCIDOOEJ != other.LFFCCIDOOEJ) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (LFFCCIDOOEJ != 0) hash ^= LFFCCIDOOEJ.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
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
      if (LFFCCIDOOEJ != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LFFCCIDOOEJ);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(WorldLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(BattleInfo);
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
      if (LFFCCIDOOEJ != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LFFCCIDOOEJ);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(WorldLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(BattleInfo);
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
      if (LFFCCIDOOEJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LFFCCIDOOEJ);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartTimedFarmElementScRsp other) {
      if (other == null) {
        return;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.LFFCCIDOOEJ != 0) {
        LFFCCIDOOEJ = other.LFFCCIDOOEJ;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
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
          case 32: {
            LFFCCIDOOEJ = input.ReadUInt32();
            break;
          }
          case 72: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
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
          case 32: {
            LFFCCIDOOEJ = input.ReadUInt32();
            break;
          }
          case 72: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.SceneBattleInfo();
            }
            input.ReadMessage(BattleInfo);
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
