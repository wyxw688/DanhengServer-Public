// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoryLineInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StoryLineInfoScNotify.proto</summary>
  public static partial class StoryLineInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for StoryLineInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoryLineInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtTdG9yeUxpbmVJbmZvU2NOb3RpZnkucHJvdG8idAoVU3RvcnlMaW5lSW5m",
            "b1NjTm90aWZ5EiIKGnJ1bm5pbmdfc3RvcnlfbGluZV9pZF9saXN0GAEgAygN",
            "EhwKFHRyaWFsX2F2YXRhcl9pZF9saXN0GA4gAygNEhkKEWN1cl9zdG9yeV9s",
            "aW5lX2lkGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StoryLineInfoScNotify), global::EggLink.DanhengServer.Proto.StoryLineInfoScNotify.Parser, new[]{ "RunningStoryLineIdList", "TrialAvatarIdList", "CurStoryLineId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StoryLineInfoScNotify : pb::IMessage<StoryLineInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StoryLineInfoScNotify> _parser = new pb::MessageParser<StoryLineInfoScNotify>(() => new StoryLineInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StoryLineInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StoryLineInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoryLineInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoryLineInfoScNotify(StoryLineInfoScNotify other) : this() {
      runningStoryLineIdList_ = other.runningStoryLineIdList_.Clone();
      trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
      curStoryLineId_ = other.curStoryLineId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoryLineInfoScNotify Clone() {
      return new StoryLineInfoScNotify(this);
    }

    /// <summary>Field number for the "running_story_line_id_list" field.</summary>
    public const int RunningStoryLineIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_runningStoryLineIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> runningStoryLineIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RunningStoryLineIdList {
      get { return runningStoryLineIdList_; }
    }

    /// <summary>Field number for the "trial_avatar_id_list" field.</summary>
    public const int TrialAvatarIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_trialAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> trialAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TrialAvatarIdList {
      get { return trialAvatarIdList_; }
    }

    /// <summary>Field number for the "cur_story_line_id" field.</summary>
    public const int CurStoryLineIdFieldNumber = 8;
    private uint curStoryLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurStoryLineId {
      get { return curStoryLineId_; }
      set {
        curStoryLineId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StoryLineInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StoryLineInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!runningStoryLineIdList_.Equals(other.runningStoryLineIdList_)) return false;
      if(!trialAvatarIdList_.Equals(other.trialAvatarIdList_)) return false;
      if (CurStoryLineId != other.CurStoryLineId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= runningStoryLineIdList_.GetHashCode();
      hash ^= trialAvatarIdList_.GetHashCode();
      if (CurStoryLineId != 0) hash ^= CurStoryLineId.GetHashCode();
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
      runningStoryLineIdList_.WriteTo(output, _repeated_runningStoryLineIdList_codec);
      if (CurStoryLineId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CurStoryLineId);
      }
      trialAvatarIdList_.WriteTo(output, _repeated_trialAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      runningStoryLineIdList_.WriteTo(ref output, _repeated_runningStoryLineIdList_codec);
      if (CurStoryLineId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CurStoryLineId);
      }
      trialAvatarIdList_.WriteTo(ref output, _repeated_trialAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += runningStoryLineIdList_.CalculateSize(_repeated_runningStoryLineIdList_codec);
      size += trialAvatarIdList_.CalculateSize(_repeated_trialAvatarIdList_codec);
      if (CurStoryLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurStoryLineId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StoryLineInfoScNotify other) {
      if (other == null) {
        return;
      }
      runningStoryLineIdList_.Add(other.runningStoryLineIdList_);
      trialAvatarIdList_.Add(other.trialAvatarIdList_);
      if (other.CurStoryLineId != 0) {
        CurStoryLineId = other.CurStoryLineId;
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
            runningStoryLineIdList_.AddEntriesFrom(input, _repeated_runningStoryLineIdList_codec);
            break;
          }
          case 64: {
            CurStoryLineId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            trialAvatarIdList_.AddEntriesFrom(input, _repeated_trialAvatarIdList_codec);
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
            runningStoryLineIdList_.AddEntriesFrom(ref input, _repeated_runningStoryLineIdList_codec);
            break;
          }
          case 64: {
            CurStoryLineId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            trialAvatarIdList_.AddEntriesFrom(ref input, _repeated_trialAvatarIdList_codec);
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
