// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EJKCOADDFFM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EJKCOADDFFM.proto</summary>
  public static partial class EJKCOADDFFMReflection {

    #region Descriptor
    /// <summary>File descriptor for EJKCOADDFFM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EJKCOADDFFMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFSktDT0FEREZGTS5wcm90byp4CgtFSktDT0FEREZGTRIXChNMb2JieUNo",
            "YXJhY3Rlcl9Ob25lEAASGQoVTG9iYnlDaGFyYWN0ZXJfTGVhZGVyEAESGQoV",
            "TG9iYnlDaGFyYWN0ZXJfTWVtYmVyEAISGgoWTG9iYnlDaGFyYWN0ZXJfV2F0",
            "Y2hlchADQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.EJKCOADDFFM), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EJKCOADDFFM {
    [pbr::OriginalName("LobbyCharacter_None")] LobbyCharacterNone = 0,
    [pbr::OriginalName("LobbyCharacter_Leader")] LobbyCharacterLeader = 1,
    [pbr::OriginalName("LobbyCharacter_Member")] LobbyCharacterMember = 2,
    [pbr::OriginalName("LobbyCharacter_Watcher")] LobbyCharacterWatcher = 3,
  }

  #endregion

}

#endregion Designer generated code
