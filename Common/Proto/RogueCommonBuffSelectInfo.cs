// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonBuffSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonBuffSelectInfo.proto</summary>
  public static partial class RogueCommonBuffSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonBuffSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonBuffSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2d1ZUNvbW1vbkJ1ZmZTZWxlY3RJbmZvLnByb3RvGhJJdGVtQ29zdERh",
            "dGEucHJvdG8aJVJvZ3VlQ29tbW9uQnVmZlNlbGVjdFNvdXJjZVR5cGUucHJv",
            "dG8aFVJvZ3VlQ29tbW9uQnVmZi5wcm90byKiAwoZUm9ndWVDb21tb25CdWZm",
            "U2VsZWN0SW5mbxIqChNyb2xsX2J1ZmZfY29zdF9kYXRhGA4gASgLMg0uSXRl",
            "bUNvc3REYXRhEhYKDnNvdXJjZV9oaW50X2lkGAogASgNEhgKEHNvdXJjZV9j",
            "dXJfY291bnQYByABKA0SGwoTcm9sbF9idWZmX21heF9jb3VudBgCIAEoDRIa",
            "ChJzb3VyY2VfdG90YWxfY291bnQYBSABKA0SEAoIY2FuX3JvbGwYBiABKAgS",
            "HAoUZmlyc3RfYnVmZl90eXBlX2xpc3QYBCADKA0SFwoPcm9sbF9idWZmX2Nv",
            "dW50GAsgASgNEhwKFHJvbGxfYnVmZl9mcmVlX2NvdW50GAMgASgNEioKEHNl",
            "bGVjdF9idWZmX2xpc3QYDCADKAsyEC5Sb2d1ZUNvbW1vbkJ1ZmYSNQoLc291",
            "cmNlX3R5cGUYDSABKA4yIC5Sb2d1ZUNvbW1vbkJ1ZmZTZWxlY3RTb3VyY2VU",
            "eXBlEiQKHGhhbmRib29rX3VubG9ja19idWZmX2lkX2xpc3QYCCADKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectInfo), global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectInfo.Parser, new[]{ "RollBuffCostData", "SourceHintId", "SourceCurCount", "RollBuffMaxCount", "SourceTotalCount", "CanRoll", "FirstBuffTypeList", "RollBuffCount", "RollBuffFreeCount", "SelectBuffList", "SourceType", "HandbookUnlockBuffIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonBuffSelectInfo : pb::IMessage<RogueCommonBuffSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonBuffSelectInfo> _parser = new pb::MessageParser<RogueCommonBuffSelectInfo>(() => new RogueCommonBuffSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonBuffSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffSelectInfo(RogueCommonBuffSelectInfo other) : this() {
      rollBuffCostData_ = other.rollBuffCostData_ != null ? other.rollBuffCostData_.Clone() : null;
      sourceHintId_ = other.sourceHintId_;
      sourceCurCount_ = other.sourceCurCount_;
      rollBuffMaxCount_ = other.rollBuffMaxCount_;
      sourceTotalCount_ = other.sourceTotalCount_;
      canRoll_ = other.canRoll_;
      firstBuffTypeList_ = other.firstBuffTypeList_.Clone();
      rollBuffCount_ = other.rollBuffCount_;
      rollBuffFreeCount_ = other.rollBuffFreeCount_;
      selectBuffList_ = other.selectBuffList_.Clone();
      sourceType_ = other.sourceType_;
      handbookUnlockBuffIdList_ = other.handbookUnlockBuffIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffSelectInfo Clone() {
      return new RogueCommonBuffSelectInfo(this);
    }

    /// <summary>Field number for the "roll_buff_cost_data" field.</summary>
    public const int RollBuffCostDataFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ItemCostData rollBuffCostData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData RollBuffCostData {
      get { return rollBuffCostData_; }
      set {
        rollBuffCostData_ = value;
      }
    }

    /// <summary>Field number for the "source_hint_id" field.</summary>
    public const int SourceHintIdFieldNumber = 10;
    private uint sourceHintId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceHintId {
      get { return sourceHintId_; }
      set {
        sourceHintId_ = value;
      }
    }

    /// <summary>Field number for the "source_cur_count" field.</summary>
    public const int SourceCurCountFieldNumber = 7;
    private uint sourceCurCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceCurCount {
      get { return sourceCurCount_; }
      set {
        sourceCurCount_ = value;
      }
    }

    /// <summary>Field number for the "roll_buff_max_count" field.</summary>
    public const int RollBuffMaxCountFieldNumber = 2;
    private uint rollBuffMaxCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffMaxCount {
      get { return rollBuffMaxCount_; }
      set {
        rollBuffMaxCount_ = value;
      }
    }

    /// <summary>Field number for the "source_total_count" field.</summary>
    public const int SourceTotalCountFieldNumber = 5;
    private uint sourceTotalCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceTotalCount {
      get { return sourceTotalCount_; }
      set {
        sourceTotalCount_ = value;
      }
    }

    /// <summary>Field number for the "can_roll" field.</summary>
    public const int CanRollFieldNumber = 6;
    private bool canRoll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CanRoll {
      get { return canRoll_; }
      set {
        canRoll_ = value;
      }
    }

    /// <summary>Field number for the "first_buff_type_list" field.</summary>
    public const int FirstBuffTypeListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_firstBuffTypeList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> firstBuffTypeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FirstBuffTypeList {
      get { return firstBuffTypeList_; }
    }

    /// <summary>Field number for the "roll_buff_count" field.</summary>
    public const int RollBuffCountFieldNumber = 11;
    private uint rollBuffCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffCount {
      get { return rollBuffCount_; }
      set {
        rollBuffCount_ = value;
      }
    }

    /// <summary>Field number for the "roll_buff_free_count" field.</summary>
    public const int RollBuffFreeCountFieldNumber = 3;
    private uint rollBuffFreeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffFreeCount {
      get { return rollBuffFreeCount_; }
      set {
        rollBuffFreeCount_ = value;
      }
    }

    /// <summary>Field number for the "select_buff_list" field.</summary>
    public const int SelectBuffListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonBuff> _repeated_selectBuffList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.RogueCommonBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> selectBuffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> SelectBuffList {
      get { return selectBuffList_; }
    }

    /// <summary>Field number for the "source_type" field.</summary>
    public const int SourceTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType sourceType_ = global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType SourceType {
      get { return sourceType_; }
      set {
        sourceType_ = value;
      }
    }

    /// <summary>Field number for the "handbook_unlock_buff_id_list" field.</summary>
    public const int HandbookUnlockBuffIdListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_handbookUnlockBuffIdList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> handbookUnlockBuffIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HandbookUnlockBuffIdList {
      get { return handbookUnlockBuffIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonBuffSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonBuffSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RollBuffCostData, other.RollBuffCostData)) return false;
      if (SourceHintId != other.SourceHintId) return false;
      if (SourceCurCount != other.SourceCurCount) return false;
      if (RollBuffMaxCount != other.RollBuffMaxCount) return false;
      if (SourceTotalCount != other.SourceTotalCount) return false;
      if (CanRoll != other.CanRoll) return false;
      if(!firstBuffTypeList_.Equals(other.firstBuffTypeList_)) return false;
      if (RollBuffCount != other.RollBuffCount) return false;
      if (RollBuffFreeCount != other.RollBuffFreeCount) return false;
      if(!selectBuffList_.Equals(other.selectBuffList_)) return false;
      if (SourceType != other.SourceType) return false;
      if(!handbookUnlockBuffIdList_.Equals(other.handbookUnlockBuffIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rollBuffCostData_ != null) hash ^= RollBuffCostData.GetHashCode();
      if (SourceHintId != 0) hash ^= SourceHintId.GetHashCode();
      if (SourceCurCount != 0) hash ^= SourceCurCount.GetHashCode();
      if (RollBuffMaxCount != 0) hash ^= RollBuffMaxCount.GetHashCode();
      if (SourceTotalCount != 0) hash ^= SourceTotalCount.GetHashCode();
      if (CanRoll != false) hash ^= CanRoll.GetHashCode();
      hash ^= firstBuffTypeList_.GetHashCode();
      if (RollBuffCount != 0) hash ^= RollBuffCount.GetHashCode();
      if (RollBuffFreeCount != 0) hash ^= RollBuffFreeCount.GetHashCode();
      hash ^= selectBuffList_.GetHashCode();
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) hash ^= SourceType.GetHashCode();
      hash ^= handbookUnlockBuffIdList_.GetHashCode();
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
      if (RollBuffMaxCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RollBuffMaxCount);
      }
      if (RollBuffFreeCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RollBuffFreeCount);
      }
      firstBuffTypeList_.WriteTo(output, _repeated_firstBuffTypeList_codec);
      if (SourceTotalCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SourceTotalCount);
      }
      if (CanRoll != false) {
        output.WriteRawTag(48);
        output.WriteBool(CanRoll);
      }
      if (SourceCurCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SourceCurCount);
      }
      handbookUnlockBuffIdList_.WriteTo(output, _repeated_handbookUnlockBuffIdList_codec);
      if (SourceHintId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SourceHintId);
      }
      if (RollBuffCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RollBuffCount);
      }
      selectBuffList_.WriteTo(output, _repeated_selectBuffList_codec);
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) SourceType);
      }
      if (rollBuffCostData_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RollBuffCostData);
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
      if (RollBuffMaxCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RollBuffMaxCount);
      }
      if (RollBuffFreeCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RollBuffFreeCount);
      }
      firstBuffTypeList_.WriteTo(ref output, _repeated_firstBuffTypeList_codec);
      if (SourceTotalCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SourceTotalCount);
      }
      if (CanRoll != false) {
        output.WriteRawTag(48);
        output.WriteBool(CanRoll);
      }
      if (SourceCurCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SourceCurCount);
      }
      handbookUnlockBuffIdList_.WriteTo(ref output, _repeated_handbookUnlockBuffIdList_codec);
      if (SourceHintId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SourceHintId);
      }
      if (RollBuffCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RollBuffCount);
      }
      selectBuffList_.WriteTo(ref output, _repeated_selectBuffList_codec);
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) SourceType);
      }
      if (rollBuffCostData_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RollBuffCostData);
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
      if (rollBuffCostData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RollBuffCostData);
      }
      if (SourceHintId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceHintId);
      }
      if (SourceCurCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceCurCount);
      }
      if (RollBuffMaxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffMaxCount);
      }
      if (SourceTotalCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceTotalCount);
      }
      if (CanRoll != false) {
        size += 1 + 1;
      }
      size += firstBuffTypeList_.CalculateSize(_repeated_firstBuffTypeList_codec);
      if (RollBuffCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffCount);
      }
      if (RollBuffFreeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffFreeCount);
      }
      size += selectBuffList_.CalculateSize(_repeated_selectBuffList_codec);
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SourceType);
      }
      size += handbookUnlockBuffIdList_.CalculateSize(_repeated_handbookUnlockBuffIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonBuffSelectInfo other) {
      if (other == null) {
        return;
      }
      if (other.rollBuffCostData_ != null) {
        if (rollBuffCostData_ == null) {
          RollBuffCostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        RollBuffCostData.MergeFrom(other.RollBuffCostData);
      }
      if (other.SourceHintId != 0) {
        SourceHintId = other.SourceHintId;
      }
      if (other.SourceCurCount != 0) {
        SourceCurCount = other.SourceCurCount;
      }
      if (other.RollBuffMaxCount != 0) {
        RollBuffMaxCount = other.RollBuffMaxCount;
      }
      if (other.SourceTotalCount != 0) {
        SourceTotalCount = other.SourceTotalCount;
      }
      if (other.CanRoll != false) {
        CanRoll = other.CanRoll;
      }
      firstBuffTypeList_.Add(other.firstBuffTypeList_);
      if (other.RollBuffCount != 0) {
        RollBuffCount = other.RollBuffCount;
      }
      if (other.RollBuffFreeCount != 0) {
        RollBuffFreeCount = other.RollBuffFreeCount;
      }
      selectBuffList_.Add(other.selectBuffList_);
      if (other.SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        SourceType = other.SourceType;
      }
      handbookUnlockBuffIdList_.Add(other.handbookUnlockBuffIdList_);
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
            RollBuffMaxCount = input.ReadUInt32();
            break;
          }
          case 24: {
            RollBuffFreeCount = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            firstBuffTypeList_.AddEntriesFrom(input, _repeated_firstBuffTypeList_codec);
            break;
          }
          case 40: {
            SourceTotalCount = input.ReadUInt32();
            break;
          }
          case 48: {
            CanRoll = input.ReadBool();
            break;
          }
          case 56: {
            SourceCurCount = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            handbookUnlockBuffIdList_.AddEntriesFrom(input, _repeated_handbookUnlockBuffIdList_codec);
            break;
          }
          case 80: {
            SourceHintId = input.ReadUInt32();
            break;
          }
          case 88: {
            RollBuffCount = input.ReadUInt32();
            break;
          }
          case 98: {
            selectBuffList_.AddEntriesFrom(input, _repeated_selectBuffList_codec);
            break;
          }
          case 104: {
            SourceType = (global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType) input.ReadEnum();
            break;
          }
          case 114: {
            if (rollBuffCostData_ == null) {
              RollBuffCostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(RollBuffCostData);
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
            RollBuffMaxCount = input.ReadUInt32();
            break;
          }
          case 24: {
            RollBuffFreeCount = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            firstBuffTypeList_.AddEntriesFrom(ref input, _repeated_firstBuffTypeList_codec);
            break;
          }
          case 40: {
            SourceTotalCount = input.ReadUInt32();
            break;
          }
          case 48: {
            CanRoll = input.ReadBool();
            break;
          }
          case 56: {
            SourceCurCount = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            handbookUnlockBuffIdList_.AddEntriesFrom(ref input, _repeated_handbookUnlockBuffIdList_codec);
            break;
          }
          case 80: {
            SourceHintId = input.ReadUInt32();
            break;
          }
          case 88: {
            RollBuffCount = input.ReadUInt32();
            break;
          }
          case 98: {
            selectBuffList_.AddEntriesFrom(ref input, _repeated_selectBuffList_codec);
            break;
          }
          case 104: {
            SourceType = (global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType) input.ReadEnum();
            break;
          }
          case 114: {
            if (rollBuffCostData_ == null) {
              RollBuffCostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(RollBuffCostData);
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
