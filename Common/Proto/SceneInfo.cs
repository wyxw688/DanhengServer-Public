// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneInfo.proto</summary>
  public static partial class SceneInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TY2VuZUluZm8ucHJvdG8aFVNjZW5lR3JvdXBTdGF0ZS5wcm90bxoURW50",
            "aXR5QnVmZkluZm8ucHJvdG8aFEN1c3RvbVNhdmVEYXRhLnByb3RvGhFHR1BO",
            "RkNKS0ZFTC5wcm90bxoOQnVmZkluZm8ucHJvdG8aHk1pc3Npb25TdGF0dXNC",
            "eVNjZW5lSW5mby5wcm90bxoVU2NlbmVFbnRpdHlJbmZvLnByb3RvGhpTY2Vu",
            "ZUVudGl0eUdyb3VwSW5mby5wcm90byKDBgoJU2NlbmVJbmZvEhgKEGxlYWRl",
            "cl9lbnRpdHlfaWQYBSABKA0SGgoSY2xpZW50X3Bvc192ZXJzaW9uGA8gASgN",
            "EhYKDmdhbWVfbW9kZV90eXBlGA0gASgNEiEKDnN5bmNfYnVmZl9pbmZvGAMg",
            "AygLMgkuQnVmZkluZm8SNgoSc2NlbmVfbWlzc2lvbl9pbmZvGMALIAEoCzIZ",
            "Lk1pc3Npb25TdGF0dXNCeVNjZW5lSW5mbxIVCg1ncm91cF9pZF9saXN0GAwg",
            "AygNEjkKEGZsb29yX3NhdmVkX2RhdGEY0wEgAygLMh4uU2NlbmVJbmZvLkZs",
            "b29yU2F2ZWREYXRhRW50cnkSEAoId29ybGRfaWQYASABKA0SJAoLQklQQUZG",
            "SEtER0QYCSADKAsyDy5FbnRpdHlCdWZmSW5mbxInCg5zYXZlX2RhdGFfbGlz",
            "dBgLIAMoCzIPLkN1c3RvbVNhdmVEYXRhEhAKCHBsYW5lX2lkGA4gASgNEjEK",
            "EWVudGl0eV9ncm91cF9saXN0GOwIIAMoCzIVLlNjZW5lRW50aXR5R3JvdXBJ",
            "bmZvEisKEGdyb3VwX3N0YXRlX2xpc3QY3QQgAygLMhAuU2NlbmVHcm91cFN0",
            "YXRlEjAKC0pNUEhER0xKRENBGAQgAygLMhsuU2NlbmVJbmZvLkpNUEhER0xK",
            "RENBRW50cnkSEAoIZW50cnlfaWQYAiABKA0SFAoLQk9OQUNCT0lJQkUY9gcg",
            "ASgNEiUKC2VudGl0eV9saXN0GAogAygLMhAuU2NlbmVFbnRpdHlJbmZvEhAK",
            "CGZsb29yX2lkGAggASgNEhwKFGxpZ2h0ZW5fc2VjdGlvbl9saXN0GAcgAygN",
            "GjUKE0Zsb29yU2F2ZWREYXRhRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVl",
            "GAIgASgFOgI4ARpAChBKTVBIREdMSkRDQUVudHJ5EgsKA2tleRgBIAEoDRIb",
            "CgV2YWx1ZRgCIAEoCzIMLkdHUE5GQ0pLRkVMOgI4AUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneGroupStateReflection.Descriptor, global::EggLink.DanhengServer.Proto.EntityBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.CustomSaveDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.GGPNFCJKFELReflection.Descriptor, global::EggLink.DanhengServer.Proto.BuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneInfo), global::EggLink.DanhengServer.Proto.SceneInfo.Parser, new[]{ "LeaderEntityId", "ClientPosVersion", "GameModeType", "SyncBuffInfo", "SceneMissionInfo", "GroupIdList", "FloorSavedData", "WorldId", "BIPAFFHKDGD", "SaveDataList", "PlaneId", "EntityGroupList", "GroupStateList", "JMPHDGLJDCA", "EntryId", "BONACBOIIBE", "EntityList", "FloorId", "LightenSectionList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneInfo : pb::IMessage<SceneInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneInfo> _parser = new pb::MessageParser<SceneInfo>(() => new SceneInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo(SceneInfo other) : this() {
      leaderEntityId_ = other.leaderEntityId_;
      clientPosVersion_ = other.clientPosVersion_;
      gameModeType_ = other.gameModeType_;
      syncBuffInfo_ = other.syncBuffInfo_.Clone();
      sceneMissionInfo_ = other.sceneMissionInfo_ != null ? other.sceneMissionInfo_.Clone() : null;
      groupIdList_ = other.groupIdList_.Clone();
      floorSavedData_ = other.floorSavedData_.Clone();
      worldId_ = other.worldId_;
      bIPAFFHKDGD_ = other.bIPAFFHKDGD_.Clone();
      saveDataList_ = other.saveDataList_.Clone();
      planeId_ = other.planeId_;
      entityGroupList_ = other.entityGroupList_.Clone();
      groupStateList_ = other.groupStateList_.Clone();
      jMPHDGLJDCA_ = other.jMPHDGLJDCA_.Clone();
      entryId_ = other.entryId_;
      bONACBOIIBE_ = other.bONACBOIIBE_;
      entityList_ = other.entityList_.Clone();
      floorId_ = other.floorId_;
      lightenSectionList_ = other.lightenSectionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo Clone() {
      return new SceneInfo(this);
    }

    /// <summary>Field number for the "leader_entity_id" field.</summary>
    public const int LeaderEntityIdFieldNumber = 5;
    private uint leaderEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeaderEntityId {
      get { return leaderEntityId_; }
      set {
        leaderEntityId_ = value;
      }
    }

    /// <summary>Field number for the "client_pos_version" field.</summary>
    public const int ClientPosVersionFieldNumber = 15;
    private uint clientPosVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientPosVersion {
      get { return clientPosVersion_; }
      set {
        clientPosVersion_ = value;
      }
    }

    /// <summary>Field number for the "game_mode_type" field.</summary>
    public const int GameModeTypeFieldNumber = 13;
    private uint gameModeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameModeType {
      get { return gameModeType_; }
      set {
        gameModeType_ = value;
      }
    }

    /// <summary>Field number for the "sync_buff_info" field.</summary>
    public const int SyncBuffInfoFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BuffInfo> _repeated_syncBuffInfo_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.BuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> syncBuffInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> SyncBuffInfo {
      get { return syncBuffInfo_; }
    }

    /// <summary>Field number for the "scene_mission_info" field.</summary>
    public const int SceneMissionInfoFieldNumber = 1472;
    private global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo sceneMissionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo SceneMissionInfo {
      get { return sceneMissionInfo_; }
      set {
        sceneMissionInfo_ = value;
      }
    }

    /// <summary>Field number for the "group_id_list" field.</summary>
    public const int GroupIdListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_groupIdList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> groupIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GroupIdList {
      get { return groupIdList_; }
    }

    /// <summary>Field number for the "floor_saved_data" field.</summary>
    public const int FloorSavedDataFieldNumber = 211;
    private static readonly pbc::MapField<string, int>.Codec _map_floorSavedData_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 1690);
    private readonly pbc::MapField<string, int> floorSavedData_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> FloorSavedData {
      get { return floorSavedData_; }
    }

    /// <summary>Field number for the "world_id" field.</summary>
    public const int WorldIdFieldNumber = 1;
    private uint worldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldId {
      get { return worldId_; }
      set {
        worldId_ = value;
      }
    }

    /// <summary>Field number for the "BIPAFFHKDGD" field.</summary>
    public const int BIPAFFHKDGDFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EntityBuffInfo> _repeated_bIPAFFHKDGD_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.EntityBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> bIPAFFHKDGD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> BIPAFFHKDGD {
      get { return bIPAFFHKDGD_; }
    }

    /// <summary>Field number for the "save_data_list" field.</summary>
    public const int SaveDataListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CustomSaveData> _repeated_saveDataList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.CustomSaveData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> saveDataList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> SaveDataList {
      get { return saveDataList_; }
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 14;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "entity_group_list" field.</summary>
    public const int EntityGroupListFieldNumber = 1132;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> _repeated_entityGroupList_codec
        = pb::FieldCodec.ForMessage(9058, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> entityGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> EntityGroupList {
      get { return entityGroupList_; }
    }

    /// <summary>Field number for the "group_state_list" field.</summary>
    public const int GroupStateListFieldNumber = 605;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneGroupState> _repeated_groupStateList_codec
        = pb::FieldCodec.ForMessage(4842, global::EggLink.DanhengServer.Proto.SceneGroupState.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> groupStateList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> GroupStateList {
      get { return groupStateList_; }
    }

    /// <summary>Field number for the "JMPHDGLJDCA" field.</summary>
    public const int JMPHDGLJDCAFieldNumber = 4;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GGPNFCJKFEL>.Codec _map_jMPHDGLJDCA_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GGPNFCJKFEL>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.GGPNFCJKFEL.Parser), 34);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GGPNFCJKFEL> jMPHDGLJDCA_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GGPNFCJKFEL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.GGPNFCJKFEL> JMPHDGLJDCA {
      get { return jMPHDGLJDCA_; }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 2;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "BONACBOIIBE" field.</summary>
    public const int BONACBOIIBEFieldNumber = 1014;
    private uint bONACBOIIBE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BONACBOIIBE {
      get { return bONACBOIIBE_; }
      set {
        bONACBOIIBE_ = value;
      }
    }

    /// <summary>Field number for the "entity_list" field.</summary>
    public const int EntityListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityInfo> _repeated_entityList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.SceneEntityInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> entityList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> EntityList {
      get { return entityList_; }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 8;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LeaderEntityId != other.LeaderEntityId) return false;
      if (ClientPosVersion != other.ClientPosVersion) return false;
      if (GameModeType != other.GameModeType) return false;
      if(!syncBuffInfo_.Equals(other.syncBuffInfo_)) return false;
      if (!object.Equals(SceneMissionInfo, other.SceneMissionInfo)) return false;
      if(!groupIdList_.Equals(other.groupIdList_)) return false;
      if (!FloorSavedData.Equals(other.FloorSavedData)) return false;
      if (WorldId != other.WorldId) return false;
      if(!bIPAFFHKDGD_.Equals(other.bIPAFFHKDGD_)) return false;
      if(!saveDataList_.Equals(other.saveDataList_)) return false;
      if (PlaneId != other.PlaneId) return false;
      if(!entityGroupList_.Equals(other.entityGroupList_)) return false;
      if(!groupStateList_.Equals(other.groupStateList_)) return false;
      if (!JMPHDGLJDCA.Equals(other.JMPHDGLJDCA)) return false;
      if (EntryId != other.EntryId) return false;
      if (BONACBOIIBE != other.BONACBOIIBE) return false;
      if(!entityList_.Equals(other.entityList_)) return false;
      if (FloorId != other.FloorId) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LeaderEntityId != 0) hash ^= LeaderEntityId.GetHashCode();
      if (ClientPosVersion != 0) hash ^= ClientPosVersion.GetHashCode();
      if (GameModeType != 0) hash ^= GameModeType.GetHashCode();
      hash ^= syncBuffInfo_.GetHashCode();
      if (sceneMissionInfo_ != null) hash ^= SceneMissionInfo.GetHashCode();
      hash ^= groupIdList_.GetHashCode();
      hash ^= FloorSavedData.GetHashCode();
      if (WorldId != 0) hash ^= WorldId.GetHashCode();
      hash ^= bIPAFFHKDGD_.GetHashCode();
      hash ^= saveDataList_.GetHashCode();
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      hash ^= entityGroupList_.GetHashCode();
      hash ^= groupStateList_.GetHashCode();
      hash ^= JMPHDGLJDCA.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      if (BONACBOIIBE != 0) hash ^= BONACBOIIBE.GetHashCode();
      hash ^= entityList_.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
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
      if (WorldId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldId);
      }
      if (EntryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntryId);
      }
      syncBuffInfo_.WriteTo(output, _repeated_syncBuffInfo_codec);
      jMPHDGLJDCA_.WriteTo(output, _map_jMPHDGLJDCA_codec);
      if (LeaderEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeaderEntityId);
      }
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      if (FloorId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FloorId);
      }
      bIPAFFHKDGD_.WriteTo(output, _repeated_bIPAFFHKDGD_codec);
      entityList_.WriteTo(output, _repeated_entityList_codec);
      saveDataList_.WriteTo(output, _repeated_saveDataList_codec);
      groupIdList_.WriteTo(output, _repeated_groupIdList_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GameModeType);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlaneId);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ClientPosVersion);
      }
      floorSavedData_.WriteTo(output, _map_floorSavedData_codec);
      groupStateList_.WriteTo(output, _repeated_groupStateList_codec);
      if (BONACBOIIBE != 0) {
        output.WriteRawTag(176, 63);
        output.WriteUInt32(BONACBOIIBE);
      }
      entityGroupList_.WriteTo(output, _repeated_entityGroupList_codec);
      if (sceneMissionInfo_ != null) {
        output.WriteRawTag(130, 92);
        output.WriteMessage(SceneMissionInfo);
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
      if (WorldId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldId);
      }
      if (EntryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntryId);
      }
      syncBuffInfo_.WriteTo(ref output, _repeated_syncBuffInfo_codec);
      jMPHDGLJDCA_.WriteTo(ref output, _map_jMPHDGLJDCA_codec);
      if (LeaderEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeaderEntityId);
      }
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      if (FloorId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FloorId);
      }
      bIPAFFHKDGD_.WriteTo(ref output, _repeated_bIPAFFHKDGD_codec);
      entityList_.WriteTo(ref output, _repeated_entityList_codec);
      saveDataList_.WriteTo(ref output, _repeated_saveDataList_codec);
      groupIdList_.WriteTo(ref output, _repeated_groupIdList_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GameModeType);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlaneId);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ClientPosVersion);
      }
      floorSavedData_.WriteTo(ref output, _map_floorSavedData_codec);
      groupStateList_.WriteTo(ref output, _repeated_groupStateList_codec);
      if (BONACBOIIBE != 0) {
        output.WriteRawTag(176, 63);
        output.WriteUInt32(BONACBOIIBE);
      }
      entityGroupList_.WriteTo(ref output, _repeated_entityGroupList_codec);
      if (sceneMissionInfo_ != null) {
        output.WriteRawTag(130, 92);
        output.WriteMessage(SceneMissionInfo);
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
      if (LeaderEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeaderEntityId);
      }
      if (ClientPosVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
      }
      if (GameModeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameModeType);
      }
      size += syncBuffInfo_.CalculateSize(_repeated_syncBuffInfo_codec);
      if (sceneMissionInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SceneMissionInfo);
      }
      size += groupIdList_.CalculateSize(_repeated_groupIdList_codec);
      size += floorSavedData_.CalculateSize(_map_floorSavedData_codec);
      if (WorldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldId);
      }
      size += bIPAFFHKDGD_.CalculateSize(_repeated_bIPAFFHKDGD_codec);
      size += saveDataList_.CalculateSize(_repeated_saveDataList_codec);
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      size += entityGroupList_.CalculateSize(_repeated_entityGroupList_codec);
      size += groupStateList_.CalculateSize(_repeated_groupStateList_codec);
      size += jMPHDGLJDCA_.CalculateSize(_map_jMPHDGLJDCA_codec);
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (BONACBOIIBE != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(BONACBOIIBE);
      }
      size += entityList_.CalculateSize(_repeated_entityList_codec);
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneInfo other) {
      if (other == null) {
        return;
      }
      if (other.LeaderEntityId != 0) {
        LeaderEntityId = other.LeaderEntityId;
      }
      if (other.ClientPosVersion != 0) {
        ClientPosVersion = other.ClientPosVersion;
      }
      if (other.GameModeType != 0) {
        GameModeType = other.GameModeType;
      }
      syncBuffInfo_.Add(other.syncBuffInfo_);
      if (other.sceneMissionInfo_ != null) {
        if (sceneMissionInfo_ == null) {
          SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
        }
        SceneMissionInfo.MergeFrom(other.SceneMissionInfo);
      }
      groupIdList_.Add(other.groupIdList_);
      floorSavedData_.MergeFrom(other.floorSavedData_);
      if (other.WorldId != 0) {
        WorldId = other.WorldId;
      }
      bIPAFFHKDGD_.Add(other.bIPAFFHKDGD_);
      saveDataList_.Add(other.saveDataList_);
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      entityGroupList_.Add(other.entityGroupList_);
      groupStateList_.Add(other.groupStateList_);
      jMPHDGLJDCA_.MergeFrom(other.jMPHDGLJDCA_);
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      if (other.BONACBOIIBE != 0) {
        BONACBOIIBE = other.BONACBOIIBE;
      }
      entityList_.Add(other.entityList_);
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      lightenSectionList_.Add(other.lightenSectionList_);
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
            WorldId = input.ReadUInt32();
            break;
          }
          case 16: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 26: {
            syncBuffInfo_.AddEntriesFrom(input, _repeated_syncBuffInfo_codec);
            break;
          }
          case 34: {
            jMPHDGLJDCA_.AddEntriesFrom(input, _map_jMPHDGLJDCA_codec);
            break;
          }
          case 40: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 64: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 74: {
            bIPAFFHKDGD_.AddEntriesFrom(input, _repeated_bIPAFFHKDGD_codec);
            break;
          }
          case 82: {
            entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
            break;
          }
          case 90: {
            saveDataList_.AddEntriesFrom(input, _repeated_saveDataList_codec);
            break;
          }
          case 98:
          case 96: {
            groupIdList_.AddEntriesFrom(input, _repeated_groupIdList_codec);
            break;
          }
          case 104: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 112: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 120: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 1690: {
            floorSavedData_.AddEntriesFrom(input, _map_floorSavedData_codec);
            break;
          }
          case 4842: {
            groupStateList_.AddEntriesFrom(input, _repeated_groupStateList_codec);
            break;
          }
          case 8112: {
            BONACBOIIBE = input.ReadUInt32();
            break;
          }
          case 9058: {
            entityGroupList_.AddEntriesFrom(input, _repeated_entityGroupList_codec);
            break;
          }
          case 11778: {
            if (sceneMissionInfo_ == null) {
              SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(SceneMissionInfo);
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
            WorldId = input.ReadUInt32();
            break;
          }
          case 16: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 26: {
            syncBuffInfo_.AddEntriesFrom(ref input, _repeated_syncBuffInfo_codec);
            break;
          }
          case 34: {
            jMPHDGLJDCA_.AddEntriesFrom(ref input, _map_jMPHDGLJDCA_codec);
            break;
          }
          case 40: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 64: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 74: {
            bIPAFFHKDGD_.AddEntriesFrom(ref input, _repeated_bIPAFFHKDGD_codec);
            break;
          }
          case 82: {
            entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
            break;
          }
          case 90: {
            saveDataList_.AddEntriesFrom(ref input, _repeated_saveDataList_codec);
            break;
          }
          case 98:
          case 96: {
            groupIdList_.AddEntriesFrom(ref input, _repeated_groupIdList_codec);
            break;
          }
          case 104: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 112: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 120: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 1690: {
            floorSavedData_.AddEntriesFrom(ref input, _map_floorSavedData_codec);
            break;
          }
          case 4842: {
            groupStateList_.AddEntriesFrom(ref input, _repeated_groupStateList_codec);
            break;
          }
          case 8112: {
            BONACBOIIBE = input.ReadUInt32();
            break;
          }
          case 9058: {
            entityGroupList_.AddEntriesFrom(ref input, _repeated_entityGroupList_codec);
            break;
          }
          case 11778: {
            if (sceneMissionInfo_ == null) {
              SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(SceneMissionInfo);
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
