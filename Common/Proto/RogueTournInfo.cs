// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournInfo.proto</summary>
  public static partial class RogueTournInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRSb2d1ZVRvdXJuSW5mby5wcm90bxoYUm9ndWVUb3VybkFyZWFJbmZvLnBy",
            "b3RvGhxJbnNwaXJhdGlvbkNpcmN1aXRJbmZvLnByb3RvGhxSb2d1ZVRvdXJu",
            "SGFuZGJvb2tJbmZvLnByb3RvGhRFeHRyYVNjb3JlSW5mby5wcm90bxoaUm9n",
            "dWVUb3VyblNlYXNvbkluZm8ucHJvdG8aHlJvZ3VlVG91cm5EaWZmaWN1bHR5",
            "SW5mby5wcm90bxoYUm9ndWVUb3VyblNhdmVMaXN0LnByb3RvGhdSb2d1ZVRv",
            "dXJuRXhwSW5mby5wcm90byK6AwoOUm9ndWVUb3VybkluZm8SMgoVcm9ndWVf",
            "dG91cm5fc2F2ZV9saXN0GAsgAygLMhMuUm9ndWVUb3VyblNhdmVMaXN0EjIK",
            "FXJvZ3VlX3RvdXJuX2FyZWFfaW5mbxgKIAMoCzITLlJvZ3VlVG91cm5BcmVh",
            "SW5mbxI0ChNpbnNwaXJhdGlvbl9jaXJjdWl0GAIgASgLMhcuSW5zcGlyYXRp",
            "b25DaXJjdWl0SW5mbxI2Chdyb2d1ZV90b3Vybl9zZWFzb25faW5mbxgEIAEo",
            "CzIVLlJvZ3VlVG91cm5TZWFzb25JbmZvEikKEGV4dHJhX3Njb3JlX2luZm8Y",
            "DiABKAsyDy5FeHRyYVNjb3JlSW5mbxIwChRyb2d1ZV90b3Vybl9leHBfaW5m",
            "bxgDIAEoCzISLlJvZ3VlVG91cm5FeHBJbmZvEjUKFHJvZ3VlX3RvdXJuX2hh",
            "bmRib29rGAggASgLMhcuUm9ndWVUb3VybkhhbmRib29rSW5mbxI+Chtyb2d1",
            "ZV90b3Vybl9kaWZmaWN1bHR5X2luZm8YCSADKAsyGS5Sb2d1ZVRvdXJuRGlm",
            "ZmljdWx0eUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTournAreaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.InspirationCircuitInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournHandbookInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ExtraScoreInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournSeasonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournDifficultyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournSaveListReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournExpInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournInfo), global::EggLink.DanhengServer.Proto.RogueTournInfo.Parser, new[]{ "RogueTournSaveList", "RogueTournAreaInfo", "InspirationCircuit", "RogueTournSeasonInfo", "ExtraScoreInfo", "RogueTournExpInfo", "RogueTournHandbook", "RogueTournDifficultyInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournInfo : pb::IMessage<RogueTournInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournInfo> _parser = new pb::MessageParser<RogueTournInfo>(() => new RogueTournInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournInfo(RogueTournInfo other) : this() {
      rogueTournSaveList_ = other.rogueTournSaveList_.Clone();
      rogueTournAreaInfo_ = other.rogueTournAreaInfo_.Clone();
      inspirationCircuit_ = other.inspirationCircuit_ != null ? other.inspirationCircuit_.Clone() : null;
      rogueTournSeasonInfo_ = other.rogueTournSeasonInfo_ != null ? other.rogueTournSeasonInfo_.Clone() : null;
      extraScoreInfo_ = other.extraScoreInfo_ != null ? other.extraScoreInfo_.Clone() : null;
      rogueTournExpInfo_ = other.rogueTournExpInfo_ != null ? other.rogueTournExpInfo_.Clone() : null;
      rogueTournHandbook_ = other.rogueTournHandbook_ != null ? other.rogueTournHandbook_.Clone() : null;
      rogueTournDifficultyInfo_ = other.rogueTournDifficultyInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournInfo Clone() {
      return new RogueTournInfo(this);
    }

    /// <summary>Field number for the "rogue_tourn_save_list" field.</summary>
    public const int RogueTournSaveListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueTournSaveList> _repeated_rogueTournSaveList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.RogueTournSaveList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournSaveList> rogueTournSaveList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournSaveList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournSaveList> RogueTournSaveList {
      get { return rogueTournSaveList_; }
    }

    /// <summary>Field number for the "rogue_tourn_area_info" field.</summary>
    public const int RogueTournAreaInfoFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueTournAreaInfo> _repeated_rogueTournAreaInfo_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.RogueTournAreaInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournAreaInfo> rogueTournAreaInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournAreaInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournAreaInfo> RogueTournAreaInfo {
      get { return rogueTournAreaInfo_; }
    }

    /// <summary>Field number for the "inspiration_circuit" field.</summary>
    public const int InspirationCircuitFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.InspirationCircuitInfo inspirationCircuit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.InspirationCircuitInfo InspirationCircuit {
      get { return inspirationCircuit_; }
      set {
        inspirationCircuit_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_season_info" field.</summary>
    public const int RogueTournSeasonInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueTournSeasonInfo rogueTournSeasonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournSeasonInfo RogueTournSeasonInfo {
      get { return rogueTournSeasonInfo_; }
      set {
        rogueTournSeasonInfo_ = value;
      }
    }

    /// <summary>Field number for the "extra_score_info" field.</summary>
    public const int ExtraScoreInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ExtraScoreInfo extraScoreInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraScoreInfo ExtraScoreInfo {
      get { return extraScoreInfo_; }
      set {
        extraScoreInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_exp_info" field.</summary>
    public const int RogueTournExpInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.RogueTournExpInfo rogueTournExpInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournExpInfo RogueTournExpInfo {
      get { return rogueTournExpInfo_; }
      set {
        rogueTournExpInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_handbook" field.</summary>
    public const int RogueTournHandbookFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.RogueTournHandbookInfo rogueTournHandbook_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournHandbookInfo RogueTournHandbook {
      get { return rogueTournHandbook_; }
      set {
        rogueTournHandbook_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_difficulty_info" field.</summary>
    public const int RogueTournDifficultyInfoFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueTournDifficultyInfo> _repeated_rogueTournDifficultyInfo_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.RogueTournDifficultyInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournDifficultyInfo> rogueTournDifficultyInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournDifficultyInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueTournDifficultyInfo> RogueTournDifficultyInfo {
      get { return rogueTournDifficultyInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rogueTournSaveList_.Equals(other.rogueTournSaveList_)) return false;
      if(!rogueTournAreaInfo_.Equals(other.rogueTournAreaInfo_)) return false;
      if (!object.Equals(InspirationCircuit, other.InspirationCircuit)) return false;
      if (!object.Equals(RogueTournSeasonInfo, other.RogueTournSeasonInfo)) return false;
      if (!object.Equals(ExtraScoreInfo, other.ExtraScoreInfo)) return false;
      if (!object.Equals(RogueTournExpInfo, other.RogueTournExpInfo)) return false;
      if (!object.Equals(RogueTournHandbook, other.RogueTournHandbook)) return false;
      if(!rogueTournDifficultyInfo_.Equals(other.rogueTournDifficultyInfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rogueTournSaveList_.GetHashCode();
      hash ^= rogueTournAreaInfo_.GetHashCode();
      if (inspirationCircuit_ != null) hash ^= InspirationCircuit.GetHashCode();
      if (rogueTournSeasonInfo_ != null) hash ^= RogueTournSeasonInfo.GetHashCode();
      if (extraScoreInfo_ != null) hash ^= ExtraScoreInfo.GetHashCode();
      if (rogueTournExpInfo_ != null) hash ^= RogueTournExpInfo.GetHashCode();
      if (rogueTournHandbook_ != null) hash ^= RogueTournHandbook.GetHashCode();
      hash ^= rogueTournDifficultyInfo_.GetHashCode();
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
      if (inspirationCircuit_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(InspirationCircuit);
      }
      if (rogueTournExpInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueTournExpInfo);
      }
      if (rogueTournSeasonInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueTournSeasonInfo);
      }
      if (rogueTournHandbook_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueTournHandbook);
      }
      rogueTournDifficultyInfo_.WriteTo(output, _repeated_rogueTournDifficultyInfo_codec);
      rogueTournAreaInfo_.WriteTo(output, _repeated_rogueTournAreaInfo_codec);
      rogueTournSaveList_.WriteTo(output, _repeated_rogueTournSaveList_codec);
      if (extraScoreInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(ExtraScoreInfo);
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
      if (inspirationCircuit_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(InspirationCircuit);
      }
      if (rogueTournExpInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueTournExpInfo);
      }
      if (rogueTournSeasonInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueTournSeasonInfo);
      }
      if (rogueTournHandbook_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueTournHandbook);
      }
      rogueTournDifficultyInfo_.WriteTo(ref output, _repeated_rogueTournDifficultyInfo_codec);
      rogueTournAreaInfo_.WriteTo(ref output, _repeated_rogueTournAreaInfo_codec);
      rogueTournSaveList_.WriteTo(ref output, _repeated_rogueTournSaveList_codec);
      if (extraScoreInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(ExtraScoreInfo);
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
      size += rogueTournSaveList_.CalculateSize(_repeated_rogueTournSaveList_codec);
      size += rogueTournAreaInfo_.CalculateSize(_repeated_rogueTournAreaInfo_codec);
      if (inspirationCircuit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InspirationCircuit);
      }
      if (rogueTournSeasonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournSeasonInfo);
      }
      if (extraScoreInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExtraScoreInfo);
      }
      if (rogueTournExpInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournExpInfo);
      }
      if (rogueTournHandbook_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournHandbook);
      }
      size += rogueTournDifficultyInfo_.CalculateSize(_repeated_rogueTournDifficultyInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournInfo other) {
      if (other == null) {
        return;
      }
      rogueTournSaveList_.Add(other.rogueTournSaveList_);
      rogueTournAreaInfo_.Add(other.rogueTournAreaInfo_);
      if (other.inspirationCircuit_ != null) {
        if (inspirationCircuit_ == null) {
          InspirationCircuit = new global::EggLink.DanhengServer.Proto.InspirationCircuitInfo();
        }
        InspirationCircuit.MergeFrom(other.InspirationCircuit);
      }
      if (other.rogueTournSeasonInfo_ != null) {
        if (rogueTournSeasonInfo_ == null) {
          RogueTournSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueTournSeasonInfo();
        }
        RogueTournSeasonInfo.MergeFrom(other.RogueTournSeasonInfo);
      }
      if (other.extraScoreInfo_ != null) {
        if (extraScoreInfo_ == null) {
          ExtraScoreInfo = new global::EggLink.DanhengServer.Proto.ExtraScoreInfo();
        }
        ExtraScoreInfo.MergeFrom(other.ExtraScoreInfo);
      }
      if (other.rogueTournExpInfo_ != null) {
        if (rogueTournExpInfo_ == null) {
          RogueTournExpInfo = new global::EggLink.DanhengServer.Proto.RogueTournExpInfo();
        }
        RogueTournExpInfo.MergeFrom(other.RogueTournExpInfo);
      }
      if (other.rogueTournHandbook_ != null) {
        if (rogueTournHandbook_ == null) {
          RogueTournHandbook = new global::EggLink.DanhengServer.Proto.RogueTournHandbookInfo();
        }
        RogueTournHandbook.MergeFrom(other.RogueTournHandbook);
      }
      rogueTournDifficultyInfo_.Add(other.rogueTournDifficultyInfo_);
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
          case 18: {
            if (inspirationCircuit_ == null) {
              InspirationCircuit = new global::EggLink.DanhengServer.Proto.InspirationCircuitInfo();
            }
            input.ReadMessage(InspirationCircuit);
            break;
          }
          case 26: {
            if (rogueTournExpInfo_ == null) {
              RogueTournExpInfo = new global::EggLink.DanhengServer.Proto.RogueTournExpInfo();
            }
            input.ReadMessage(RogueTournExpInfo);
            break;
          }
          case 34: {
            if (rogueTournSeasonInfo_ == null) {
              RogueTournSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueTournSeasonInfo();
            }
            input.ReadMessage(RogueTournSeasonInfo);
            break;
          }
          case 66: {
            if (rogueTournHandbook_ == null) {
              RogueTournHandbook = new global::EggLink.DanhengServer.Proto.RogueTournHandbookInfo();
            }
            input.ReadMessage(RogueTournHandbook);
            break;
          }
          case 74: {
            rogueTournDifficultyInfo_.AddEntriesFrom(input, _repeated_rogueTournDifficultyInfo_codec);
            break;
          }
          case 82: {
            rogueTournAreaInfo_.AddEntriesFrom(input, _repeated_rogueTournAreaInfo_codec);
            break;
          }
          case 90: {
            rogueTournSaveList_.AddEntriesFrom(input, _repeated_rogueTournSaveList_codec);
            break;
          }
          case 114: {
            if (extraScoreInfo_ == null) {
              ExtraScoreInfo = new global::EggLink.DanhengServer.Proto.ExtraScoreInfo();
            }
            input.ReadMessage(ExtraScoreInfo);
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
          case 18: {
            if (inspirationCircuit_ == null) {
              InspirationCircuit = new global::EggLink.DanhengServer.Proto.InspirationCircuitInfo();
            }
            input.ReadMessage(InspirationCircuit);
            break;
          }
          case 26: {
            if (rogueTournExpInfo_ == null) {
              RogueTournExpInfo = new global::EggLink.DanhengServer.Proto.RogueTournExpInfo();
            }
            input.ReadMessage(RogueTournExpInfo);
            break;
          }
          case 34: {
            if (rogueTournSeasonInfo_ == null) {
              RogueTournSeasonInfo = new global::EggLink.DanhengServer.Proto.RogueTournSeasonInfo();
            }
            input.ReadMessage(RogueTournSeasonInfo);
            break;
          }
          case 66: {
            if (rogueTournHandbook_ == null) {
              RogueTournHandbook = new global::EggLink.DanhengServer.Proto.RogueTournHandbookInfo();
            }
            input.ReadMessage(RogueTournHandbook);
            break;
          }
          case 74: {
            rogueTournDifficultyInfo_.AddEntriesFrom(ref input, _repeated_rogueTournDifficultyInfo_codec);
            break;
          }
          case 82: {
            rogueTournAreaInfo_.AddEntriesFrom(ref input, _repeated_rogueTournAreaInfo_codec);
            break;
          }
          case 90: {
            rogueTournSaveList_.AddEntriesFrom(ref input, _repeated_rogueTournSaveList_codec);
            break;
          }
          case 114: {
            if (extraScoreInfo_ == null) {
              ExtraScoreInfo = new global::EggLink.DanhengServer.Proto.ExtraScoreInfo();
            }
            input.ReadMessage(ExtraScoreInfo);
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
