// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrackMainMissionUpdateReasonId.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrackMainMissionUpdateReasonId.proto</summary>
  public static partial class TrackMainMissionUpdateReasonIdReflection {

    #region Descriptor
    /// <summary>File descriptor for TrackMainMissionUpdateReasonId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrackMainMissionUpdateReasonIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRUcmFja01haW5NaXNzaW9uVXBkYXRlUmVhc29uSWQucHJvdG8qugEKHlRy",
            "YWNrTWFpbk1pc3Npb25VcGRhdGVSZWFzb25JZBIiCh5UUkFDS19NQUlOX01J",
            "U1NJT05fVVBEQVRFX05PTkUQABIiCh5UUkFDS19NQUlOX01JU1NJT05fVVBE",
            "QVRFX0FVVE8QARIkCiBUUkFDS19NQUlOX01JU1NJT05fVVBEQVRFX01BTlVB",
            "TBACEioKJlRSQUNLX01BSU5fTUlTU0lPTl9VUERBVEVfTE9HSU5fUkVQT1JU",
            "EANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.TrackMainMissionUpdateReasonId), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum TrackMainMissionUpdateReasonId {
    [pbr::OriginalName("TRACK_MAIN_MISSION_UPDATE_NONE")] TrackMainMissionUpdateNone = 0,
    [pbr::OriginalName("TRACK_MAIN_MISSION_UPDATE_AUTO")] TrackMainMissionUpdateAuto = 1,
    [pbr::OriginalName("TRACK_MAIN_MISSION_UPDATE_MANUAL")] TrackMainMissionUpdateManual = 2,
    [pbr::OriginalName("TRACK_MAIN_MISSION_UPDATE_LOGIN_REPORT")] TrackMainMissionUpdateLoginReport = 3,
  }

  #endregion

}

#endregion Designer generated code
