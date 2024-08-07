// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueGetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueGetInfo.proto</summary>
  public static partial class ChessRogueGetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueGetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueGetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDaGVzc1JvZ3VlR2V0SW5mby5wcm90bxoaQ2hlc3NSb2d1ZVRhbGVudElu",
            "Zm8ucHJvdG8aIkNoZXNzUm9ndWVRdWVyeURpZmZjdWx0eUluZm8ucHJvdG8a",
            "HUNoZXNzUm9ndWVRdWVyeUFlb25JbmZvLnByb3RvGh1DaGVzc1JvZ3VlUXVl",
            "cnlEaWNlSW5mby5wcm90byKYAgoRQ2hlc3NSb2d1ZUdldEluZm8SPAoVcm9n",
            "dWVfZGlmZmljdWx0eV9pbmZvGAQgASgLMh0uQ2hlc3NSb2d1ZVF1ZXJ5RGlm",
            "ZmN1bHR5SW5mbxIxCg9jaGVzc19hZW9uX2luZm8YCyABKAsyGC5DaGVzc1Jv",
            "Z3VlUXVlcnlBZW9uSW5mbxIUCgxhcmVhX2lkX2xpc3QYCiADKA0SKwoJZGlj",
            "ZV9pbmZvGAEgASgLMhguQ2hlc3NSb2d1ZVF1ZXJ5RGljZUluZm8SMAoRcm9n",
            "dWVfdGFsZW50X2luZm8YAyABKAsyFS5DaGVzc1JvZ3VlVGFsZW50SW5mbxId",
            "ChVleHBsb3JlZF9hcmVhX2lkX2xpc3QYDyADKA1CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueTalentInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueGetInfo), global::EggLink.DanhengServer.Proto.ChessRogueGetInfo.Parser, new[]{ "RogueDifficultyInfo", "ChessAeonInfo", "AreaIdList", "DiceInfo", "RogueTalentInfo", "ExploredAreaIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueGetInfo : pb::IMessage<ChessRogueGetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueGetInfo> _parser = new pb::MessageParser<ChessRogueGetInfo>(() => new ChessRogueGetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueGetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueGetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGetInfo(ChessRogueGetInfo other) : this() {
      rogueDifficultyInfo_ = other.rogueDifficultyInfo_ != null ? other.rogueDifficultyInfo_.Clone() : null;
      chessAeonInfo_ = other.chessAeonInfo_ != null ? other.chessAeonInfo_.Clone() : null;
      areaIdList_ = other.areaIdList_.Clone();
      diceInfo_ = other.diceInfo_ != null ? other.diceInfo_.Clone() : null;
      rogueTalentInfo_ = other.rogueTalentInfo_ != null ? other.rogueTalentInfo_.Clone() : null;
      exploredAreaIdList_ = other.exploredAreaIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGetInfo Clone() {
      return new ChessRogueGetInfo(this);
    }

    /// <summary>Field number for the "rogue_difficulty_info" field.</summary>
    public const int RogueDifficultyInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo rogueDifficultyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo RogueDifficultyInfo {
      get { return rogueDifficultyInfo_; }
      set {
        rogueDifficultyInfo_ = value;
      }
    }

    /// <summary>Field number for the "chess_aeon_info" field.</summary>
    public const int ChessAeonInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo chessAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo ChessAeonInfo {
      get { return chessAeonInfo_; }
      set {
        chessAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "area_id_list" field.</summary>
    public const int AreaIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_areaIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> areaIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AreaIdList {
      get { return areaIdList_; }
    }

    /// <summary>Field number for the "dice_info" field.</summary>
    public const int DiceInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo diceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo DiceInfo {
      get { return diceInfo_; }
      set {
        diceInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_talent_info" field.</summary>
    public const int RogueTalentInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo rogueTalentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo RogueTalentInfo {
      get { return rogueTalentInfo_; }
      set {
        rogueTalentInfo_ = value;
      }
    }

    /// <summary>Field number for the "explored_area_id_list" field.</summary>
    public const int ExploredAreaIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_exploredAreaIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> exploredAreaIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExploredAreaIdList {
      get { return exploredAreaIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueGetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueGetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueDifficultyInfo, other.RogueDifficultyInfo)) return false;
      if (!object.Equals(ChessAeonInfo, other.ChessAeonInfo)) return false;
      if(!areaIdList_.Equals(other.areaIdList_)) return false;
      if (!object.Equals(DiceInfo, other.DiceInfo)) return false;
      if (!object.Equals(RogueTalentInfo, other.RogueTalentInfo)) return false;
      if(!exploredAreaIdList_.Equals(other.exploredAreaIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueDifficultyInfo_ != null) hash ^= RogueDifficultyInfo.GetHashCode();
      if (chessAeonInfo_ != null) hash ^= ChessAeonInfo.GetHashCode();
      hash ^= areaIdList_.GetHashCode();
      if (diceInfo_ != null) hash ^= DiceInfo.GetHashCode();
      if (rogueTalentInfo_ != null) hash ^= RogueTalentInfo.GetHashCode();
      hash ^= exploredAreaIdList_.GetHashCode();
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
      if (diceInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DiceInfo);
      }
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueTalentInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueDifficultyInfo);
      }
      areaIdList_.WriteTo(output, _repeated_areaIdList_codec);
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ChessAeonInfo);
      }
      exploredAreaIdList_.WriteTo(output, _repeated_exploredAreaIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (diceInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DiceInfo);
      }
      if (rogueTalentInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueTalentInfo);
      }
      if (rogueDifficultyInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueDifficultyInfo);
      }
      areaIdList_.WriteTo(ref output, _repeated_areaIdList_codec);
      if (chessAeonInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ChessAeonInfo);
      }
      exploredAreaIdList_.WriteTo(ref output, _repeated_exploredAreaIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (rogueDifficultyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDifficultyInfo);
      }
      if (chessAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChessAeonInfo);
      }
      size += areaIdList_.CalculateSize(_repeated_areaIdList_codec);
      if (diceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DiceInfo);
      }
      if (rogueTalentInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTalentInfo);
      }
      size += exploredAreaIdList_.CalculateSize(_repeated_exploredAreaIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueGetInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueDifficultyInfo_ != null) {
        if (rogueDifficultyInfo_ == null) {
          RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
        }
        RogueDifficultyInfo.MergeFrom(other.RogueDifficultyInfo);
      }
      if (other.chessAeonInfo_ != null) {
        if (chessAeonInfo_ == null) {
          ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
        }
        ChessAeonInfo.MergeFrom(other.ChessAeonInfo);
      }
      areaIdList_.Add(other.areaIdList_);
      if (other.diceInfo_ != null) {
        if (diceInfo_ == null) {
          DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
        }
        DiceInfo.MergeFrom(other.DiceInfo);
      }
      if (other.rogueTalentInfo_ != null) {
        if (rogueTalentInfo_ == null) {
          RogueTalentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
        }
        RogueTalentInfo.MergeFrom(other.RogueTalentInfo);
      }
      exploredAreaIdList_.Add(other.exploredAreaIdList_);
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
            if (diceInfo_ == null) {
              DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
            }
            input.ReadMessage(DiceInfo);
            break;
          }
          case 26: {
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
            }
            input.ReadMessage(RogueTalentInfo);
            break;
          }
          case 34: {
            if (rogueDifficultyInfo_ == null) {
              RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
            }
            input.ReadMessage(RogueDifficultyInfo);
            break;
          }
          case 82:
          case 80: {
            areaIdList_.AddEntriesFrom(input, _repeated_areaIdList_codec);
            break;
          }
          case 90: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 122:
          case 120: {
            exploredAreaIdList_.AddEntriesFrom(input, _repeated_exploredAreaIdList_codec);
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
            if (diceInfo_ == null) {
              DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiceInfo();
            }
            input.ReadMessage(DiceInfo);
            break;
          }
          case 26: {
            if (rogueTalentInfo_ == null) {
              RogueTalentInfo = new global::EggLink.DanhengServer.Proto.ChessRogueTalentInfo();
            }
            input.ReadMessage(RogueTalentInfo);
            break;
          }
          case 34: {
            if (rogueDifficultyInfo_ == null) {
              RogueDifficultyInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryDiffcultyInfo();
            }
            input.ReadMessage(RogueDifficultyInfo);
            break;
          }
          case 82:
          case 80: {
            areaIdList_.AddEntriesFrom(ref input, _repeated_areaIdList_codec);
            break;
          }
          case 90: {
            if (chessAeonInfo_ == null) {
              ChessAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryAeonInfo();
            }
            input.ReadMessage(ChessAeonInfo);
            break;
          }
          case 122:
          case 120: {
            exploredAreaIdList_.AddEntriesFrom(ref input, _repeated_exploredAreaIdList_codec);
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
