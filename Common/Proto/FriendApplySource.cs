// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendApplySource.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FriendApplySource.proto</summary>
  public static partial class FriendApplySourceReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendApplySource.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendApplySourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdGcmllbmRBcHBseVNvdXJjZS5wcm90byqJAgoRRnJpZW5kQXBwbHlTb3Vy",
            "Y2USHAoYRlJJRU5EX0FQUExZX1NPVVJDRV9OT05FEAASHgoaRlJJRU5EX0FQ",
            "UExZX1NPVVJDRV9TRUFSQ0gQARIhCh1GUklFTkRfQVBQTFlfU09VUkNFX1JF",
            "Q09NTUVORBACEh4KGkZSSUVORF9BUFBMWV9TT1VSQ0VfQVNTSVNUEAMSKAok",
            "RlJJRU5EX0FQUExZX1NPVVJDRV9SRUNPTU1FTkRfQVNTSVNUEAQSIgoeRlJJ",
            "RU5EX0FQUExZX1NPVVJDRV9QU05fRlJJRU5EEAUSJQohRlJJRU5EX0FQUExZ",
            "X1NPVVJDRV9BU1NJU1RfUkVXQVJEEAZCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.FriendApplySource), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FriendApplySource {
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_NONE")] None = 0,
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_SEARCH")] Search = 1,
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_RECOMMEND")] Recommend = 2,
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_ASSIST")] Assist = 3,
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_RECOMMEND_ASSIST")] RecommendAssist = 4,
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_PSN_FRIEND")] PsnFriend = 5,
    [pbr::OriginalName("FRIEND_APPLY_SOURCE_ASSIST_REWARD")] AssistReward = 6,
  }

  #endregion

}

#endregion Designer generated code
