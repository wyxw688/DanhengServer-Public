// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LobbyCharacterStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LobbyCharacterStatus.proto</summary>
  public static partial class LobbyCharacterStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for LobbyCharacterStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LobbyCharacterStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpMb2JieUNoYXJhY3RlclN0YXR1cy5wcm90byqBAgoUTG9iYnlDaGFyYWN0",
            "ZXJTdGF0dXMSHQoZTG9iYnlDaGFyYWN0ZXJTdGF0dXNfTm9uZRAAEh0KGUxv",
            "YmJ5Q2hhcmFjdGVyU3RhdHVzX0lkbGUQARIiCh5Mb2JieUNoYXJhY3RlclN0",
            "YXR1c19PcGVyYXRpbmcQAhIeChpMb2JieUNoYXJhY3RlclN0YXR1c19SZWFk",
            "eRADEiEKHUxvYmJ5Q2hhcmFjdGVyU3RhdHVzX0ZpZ2h0aW5nEAQSIQodTG9i",
            "YnlDaGFyYWN0ZXJTdGF0dXNfV2F0Y2hpbmcQBRIhCh1Mb2JieUNoYXJhY3Rl",
            "clN0YXR1c19NYXRjaGluZxAGQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.LobbyCharacterStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LobbyCharacterStatus {
    [pbr::OriginalName("LobbyCharacterStatus_None")] None = 0,
    [pbr::OriginalName("LobbyCharacterStatus_Idle")] Idle = 1,
    [pbr::OriginalName("LobbyCharacterStatus_Operating")] Operating = 2,
    [pbr::OriginalName("LobbyCharacterStatus_Ready")] Ready = 3,
    [pbr::OriginalName("LobbyCharacterStatus_Fighting")] Fighting = 4,
    [pbr::OriginalName("LobbyCharacterStatus_Watching")] Watching = 5,
    [pbr::OriginalName("LobbyCharacterStatus_Matching")] Matching = 6,
  }

  #endregion

}

#endregion Designer generated code
