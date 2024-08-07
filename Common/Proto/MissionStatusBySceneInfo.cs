// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MissionStatusBySceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MissionStatusBySceneInfo.proto</summary>
  public static partial class MissionStatusBySceneInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MissionStatusBySceneInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MissionStatusBySceneInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5NaXNzaW9uU3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aEUdCR1BDQ0xJSUVB",
            "LnByb3RvGg1NaXNzaW9uLnByb3RvIr8BChhNaXNzaW9uU3RhdHVzQnlTY2Vu",
            "ZUluZm8SIwobYWNjZXB0X21haW5fbWlzc2lvbl9pZF9saXN0GAkgAygNEhwK",
            "FG1haW5fbWlzc2lvbl9pZF9saXN0GAggAygNEigKFnNjZW5lX3N1Yl9taXNz",
            "aW9uX2xpc3QYDyADKAsyCC5NaXNzaW9uEiEKC0NPTERBQk1LTkRIGAMgAygL",
            "MgwuR0JHUENDTElJRUESEwoLREdCTUdJRk9LRUUYCyADKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GBGPCCLIIEAReflection.Descriptor, global::EggLink.DanhengServer.Proto.MissionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo), global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo.Parser, new[]{ "AcceptMainMissionIdList", "MainMissionIdList", "SceneSubMissionList", "COLDABMKNDH", "DGBMGIFOKEE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MissionStatusBySceneInfo : pb::IMessage<MissionStatusBySceneInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MissionStatusBySceneInfo> _parser = new pb::MessageParser<MissionStatusBySceneInfo>(() => new MissionStatusBySceneInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MissionStatusBySceneInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionStatusBySceneInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionStatusBySceneInfo(MissionStatusBySceneInfo other) : this() {
      acceptMainMissionIdList_ = other.acceptMainMissionIdList_.Clone();
      mainMissionIdList_ = other.mainMissionIdList_.Clone();
      sceneSubMissionList_ = other.sceneSubMissionList_.Clone();
      cOLDABMKNDH_ = other.cOLDABMKNDH_.Clone();
      dGBMGIFOKEE_ = other.dGBMGIFOKEE_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionStatusBySceneInfo Clone() {
      return new MissionStatusBySceneInfo(this);
    }

    /// <summary>Field number for the "accept_main_mission_id_list" field.</summary>
    public const int AcceptMainMissionIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_acceptMainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> acceptMainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AcceptMainMissionIdList {
      get { return acceptMainMissionIdList_; }
    }

    /// <summary>Field number for the "main_mission_id_list" field.</summary>
    public const int MainMissionIdListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_mainMissionIdList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> mainMissionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MainMissionIdList {
      get { return mainMissionIdList_; }
    }

    /// <summary>Field number for the "scene_sub_mission_list" field.</summary>
    public const int SceneSubMissionListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Mission> _repeated_sceneSubMissionList_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.Mission.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> sceneSubMissionList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> SceneSubMissionList {
      get { return sceneSubMissionList_; }
    }

    /// <summary>Field number for the "COLDABMKNDH" field.</summary>
    public const int COLDABMKNDHFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GBGPCCLIIEA> _repeated_cOLDABMKNDH_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.GBGPCCLIIEA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GBGPCCLIIEA> cOLDABMKNDH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GBGPCCLIIEA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GBGPCCLIIEA> COLDABMKNDH {
      get { return cOLDABMKNDH_; }
    }

    /// <summary>Field number for the "DGBMGIFOKEE" field.</summary>
    public const int DGBMGIFOKEEFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_dGBMGIFOKEE_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> dGBMGIFOKEE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DGBMGIFOKEE {
      get { return dGBMGIFOKEE_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MissionStatusBySceneInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MissionStatusBySceneInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!acceptMainMissionIdList_.Equals(other.acceptMainMissionIdList_)) return false;
      if(!mainMissionIdList_.Equals(other.mainMissionIdList_)) return false;
      if(!sceneSubMissionList_.Equals(other.sceneSubMissionList_)) return false;
      if(!cOLDABMKNDH_.Equals(other.cOLDABMKNDH_)) return false;
      if(!dGBMGIFOKEE_.Equals(other.dGBMGIFOKEE_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= acceptMainMissionIdList_.GetHashCode();
      hash ^= mainMissionIdList_.GetHashCode();
      hash ^= sceneSubMissionList_.GetHashCode();
      hash ^= cOLDABMKNDH_.GetHashCode();
      hash ^= dGBMGIFOKEE_.GetHashCode();
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
      cOLDABMKNDH_.WriteTo(output, _repeated_cOLDABMKNDH_codec);
      mainMissionIdList_.WriteTo(output, _repeated_mainMissionIdList_codec);
      acceptMainMissionIdList_.WriteTo(output, _repeated_acceptMainMissionIdList_codec);
      dGBMGIFOKEE_.WriteTo(output, _repeated_dGBMGIFOKEE_codec);
      sceneSubMissionList_.WriteTo(output, _repeated_sceneSubMissionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      cOLDABMKNDH_.WriteTo(ref output, _repeated_cOLDABMKNDH_codec);
      mainMissionIdList_.WriteTo(ref output, _repeated_mainMissionIdList_codec);
      acceptMainMissionIdList_.WriteTo(ref output, _repeated_acceptMainMissionIdList_codec);
      dGBMGIFOKEE_.WriteTo(ref output, _repeated_dGBMGIFOKEE_codec);
      sceneSubMissionList_.WriteTo(ref output, _repeated_sceneSubMissionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += acceptMainMissionIdList_.CalculateSize(_repeated_acceptMainMissionIdList_codec);
      size += mainMissionIdList_.CalculateSize(_repeated_mainMissionIdList_codec);
      size += sceneSubMissionList_.CalculateSize(_repeated_sceneSubMissionList_codec);
      size += cOLDABMKNDH_.CalculateSize(_repeated_cOLDABMKNDH_codec);
      size += dGBMGIFOKEE_.CalculateSize(_repeated_dGBMGIFOKEE_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MissionStatusBySceneInfo other) {
      if (other == null) {
        return;
      }
      acceptMainMissionIdList_.Add(other.acceptMainMissionIdList_);
      mainMissionIdList_.Add(other.mainMissionIdList_);
      sceneSubMissionList_.Add(other.sceneSubMissionList_);
      cOLDABMKNDH_.Add(other.cOLDABMKNDH_);
      dGBMGIFOKEE_.Add(other.dGBMGIFOKEE_);
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
          case 26: {
            cOLDABMKNDH_.AddEntriesFrom(input, _repeated_cOLDABMKNDH_codec);
            break;
          }
          case 66:
          case 64: {
            mainMissionIdList_.AddEntriesFrom(input, _repeated_mainMissionIdList_codec);
            break;
          }
          case 74:
          case 72: {
            acceptMainMissionIdList_.AddEntriesFrom(input, _repeated_acceptMainMissionIdList_codec);
            break;
          }
          case 90:
          case 88: {
            dGBMGIFOKEE_.AddEntriesFrom(input, _repeated_dGBMGIFOKEE_codec);
            break;
          }
          case 122: {
            sceneSubMissionList_.AddEntriesFrom(input, _repeated_sceneSubMissionList_codec);
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
          case 26: {
            cOLDABMKNDH_.AddEntriesFrom(ref input, _repeated_cOLDABMKNDH_codec);
            break;
          }
          case 66:
          case 64: {
            mainMissionIdList_.AddEntriesFrom(ref input, _repeated_mainMissionIdList_codec);
            break;
          }
          case 74:
          case 72: {
            acceptMainMissionIdList_.AddEntriesFrom(ref input, _repeated_acceptMainMissionIdList_codec);
            break;
          }
          case 90:
          case 88: {
            dGBMGIFOKEE_.AddEntriesFrom(ref input, _repeated_dGBMGIFOKEE_codec);
            break;
          }
          case 122: {
            sceneSubMissionList_.AddEntriesFrom(ref input, _repeated_sceneSubMissionList_codec);
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
