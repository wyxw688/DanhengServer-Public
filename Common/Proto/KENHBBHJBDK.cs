// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KENHBBHJBDK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KENHBBHJBDK.proto</summary>
  public static partial class KENHBBHJBDKReflection {

    #region Descriptor
    /// <summary>File descriptor for KENHBBHJBDK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KENHBBHJBDKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLRU5IQkJISkJESy5wcm90bxoVUm9ndWVGaW5pc2hJbmZvLnByb3RvIkQK",
            "C0tFTkhCQkhKQkRLEiUKC2ZpbmlzaF9pbmZvGAwgASgLMhAuUm9ndWVGaW5p",
            "c2hJbmZvEg4KBm1hcF9pZBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueFinishInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KENHBBHJBDK), global::EggLink.DanhengServer.Proto.KENHBBHJBDK.Parser, new[]{ "FinishInfo", "MapId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KENHBBHJBDK : pb::IMessage<KENHBBHJBDK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KENHBBHJBDK> _parser = new pb::MessageParser<KENHBBHJBDK>(() => new KENHBBHJBDK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KENHBBHJBDK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KENHBBHJBDKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KENHBBHJBDK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KENHBBHJBDK(KENHBBHJBDK other) : this() {
      finishInfo_ = other.finishInfo_ != null ? other.finishInfo_.Clone() : null;
      mapId_ = other.mapId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KENHBBHJBDK Clone() {
      return new KENHBBHJBDK(this);
    }

    /// <summary>Field number for the "finish_info" field.</summary>
    public const int FinishInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueFinishInfo finishInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueFinishInfo FinishInfo {
      get { return finishInfo_; }
      set {
        finishInfo_ = value;
      }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 4;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KENHBBHJBDK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KENHBBHJBDK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FinishInfo, other.FinishInfo)) return false;
      if (MapId != other.MapId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (finishInfo_ != null) hash ^= FinishInfo.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
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
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MapId);
      }
      if (finishInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FinishInfo);
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
      if (MapId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MapId);
      }
      if (finishInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FinishInfo);
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
      if (finishInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinishInfo);
      }
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KENHBBHJBDK other) {
      if (other == null) {
        return;
      }
      if (other.finishInfo_ != null) {
        if (finishInfo_ == null) {
          FinishInfo = new global::EggLink.DanhengServer.Proto.RogueFinishInfo();
        }
        FinishInfo.MergeFrom(other.FinishInfo);
      }
      if (other.MapId != 0) {
        MapId = other.MapId;
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
            MapId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.RogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
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
            MapId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.RogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
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
