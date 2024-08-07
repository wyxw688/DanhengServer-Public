// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueCellUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueCellUpdateNotify.proto</summary>
  public static partial class ChessRogueCellUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueCellUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueCellUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBDaGVzc1JvZ3VlQ2VsbFVwZGF0ZU5vdGlmeS5wcm90bxodUm9ndWVNb2Rp",
            "ZmllclNvdXJjZVR5cGUucHJvdG8aEUJIQUFDSU1PSkRGLnByb3RvGhRDaGVz",
            "c1JvZ3VlQ2VsbC5wcm90byKfAQoaQ2hlc3NSb2d1ZUNlbGxVcGRhdGVOb3Rp",
            "ZnkSIgoJY2VsbF9saXN0GAsgAygLMg8uQ2hlc3NSb2d1ZUNlbGwSEAoIYm9h",
            "cmRfaWQYAiABKA0SLQoLQk9JUEZLTEdNTkEYDyABKA4yGC5Sb2d1ZU1vZGlm",
            "aWVyU291cmNlVHlwZRIcCgZyZWFzb24YCSABKA4yDC5CSEFBQ0lNT0pERkIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueModifierSourceTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.BHAACIMOJDFReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueCellReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueCellUpdateNotify), global::EggLink.DanhengServer.Proto.ChessRogueCellUpdateNotify.Parser, new[]{ "CellList", "BoardId", "BOIPFKLGMNA", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueCellUpdateNotify : pb::IMessage<ChessRogueCellUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueCellUpdateNotify> _parser = new pb::MessageParser<ChessRogueCellUpdateNotify>(() => new ChessRogueCellUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueCellUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueCellUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCellUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCellUpdateNotify(ChessRogueCellUpdateNotify other) : this() {
      cellList_ = other.cellList_.Clone();
      boardId_ = other.boardId_;
      bOIPFKLGMNA_ = other.bOIPFKLGMNA_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCellUpdateNotify Clone() {
      return new ChessRogueCellUpdateNotify(this);
    }

    /// <summary>Field number for the "cell_list" field.</summary>
    public const int CellListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueCell> _repeated_cellList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.ChessRogueCell.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueCell> cellList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueCell>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueCell> CellList {
      get { return cellList_; }
    }

    /// <summary>Field number for the "board_id" field.</summary>
    public const int BoardIdFieldNumber = 2;
    private uint boardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BoardId {
      get { return boardId_; }
      set {
        boardId_ = value;
      }
    }

    /// <summary>Field number for the "BOIPFKLGMNA" field.</summary>
    public const int BOIPFKLGMNAFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueModifierSourceType bOIPFKLGMNA_ = global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifierSourceType BOIPFKLGMNA {
      get { return bOIPFKLGMNA_; }
      set {
        bOIPFKLGMNA_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.BHAACIMOJDF reason_ = global::EggLink.DanhengServer.Proto.BHAACIMOJDF.ChessRogueCellUpdateReasonNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BHAACIMOJDF Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueCellUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueCellUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cellList_.Equals(other.cellList_)) return false;
      if (BoardId != other.BoardId) return false;
      if (BOIPFKLGMNA != other.BOIPFKLGMNA) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cellList_.GetHashCode();
      if (BoardId != 0) hash ^= BoardId.GetHashCode();
      if (BOIPFKLGMNA != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) hash ^= BOIPFKLGMNA.GetHashCode();
      if (Reason != global::EggLink.DanhengServer.Proto.BHAACIMOJDF.ChessRogueCellUpdateReasonNone) hash ^= Reason.GetHashCode();
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
      if (BoardId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BoardId);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BHAACIMOJDF.ChessRogueCellUpdateReasonNone) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Reason);
      }
      cellList_.WriteTo(output, _repeated_cellList_codec);
      if (BOIPFKLGMNA != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        output.WriteRawTag(120);
        output.WriteEnum((int) BOIPFKLGMNA);
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
      if (BoardId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BoardId);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BHAACIMOJDF.ChessRogueCellUpdateReasonNone) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Reason);
      }
      cellList_.WriteTo(ref output, _repeated_cellList_codec);
      if (BOIPFKLGMNA != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        output.WriteRawTag(120);
        output.WriteEnum((int) BOIPFKLGMNA);
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
      size += cellList_.CalculateSize(_repeated_cellList_codec);
      if (BoardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoardId);
      }
      if (BOIPFKLGMNA != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BOIPFKLGMNA);
      }
      if (Reason != global::EggLink.DanhengServer.Proto.BHAACIMOJDF.ChessRogueCellUpdateReasonNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueCellUpdateNotify other) {
      if (other == null) {
        return;
      }
      cellList_.Add(other.cellList_);
      if (other.BoardId != 0) {
        BoardId = other.BoardId;
      }
      if (other.BOIPFKLGMNA != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        BOIPFKLGMNA = other.BOIPFKLGMNA;
      }
      if (other.Reason != global::EggLink.DanhengServer.Proto.BHAACIMOJDF.ChessRogueCellUpdateReasonNone) {
        Reason = other.Reason;
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
            BoardId = input.ReadUInt32();
            break;
          }
          case 72: {
            Reason = (global::EggLink.DanhengServer.Proto.BHAACIMOJDF) input.ReadEnum();
            break;
          }
          case 90: {
            cellList_.AddEntriesFrom(input, _repeated_cellList_codec);
            break;
          }
          case 120: {
            BOIPFKLGMNA = (global::EggLink.DanhengServer.Proto.RogueModifierSourceType) input.ReadEnum();
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
            BoardId = input.ReadUInt32();
            break;
          }
          case 72: {
            Reason = (global::EggLink.DanhengServer.Proto.BHAACIMOJDF) input.ReadEnum();
            break;
          }
          case 90: {
            cellList_.AddEntriesFrom(ref input, _repeated_cellList_codec);
            break;
          }
          case 120: {
            BOIPFKLGMNA = (global::EggLink.DanhengServer.Proto.RogueModifierSourceType) input.ReadEnum();
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
