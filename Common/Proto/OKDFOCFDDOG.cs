// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OKDFOCFDDOG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OKDFOCFDDOG.proto</summary>
  public static partial class OKDFOCFDDOGReflection {

    #region Descriptor
    /// <summary>File descriptor for OKDFOCFDDOG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OKDFOCFDDOGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPS0RGT0NGRERPRy5wcm90byqgAQoLT0tERk9DRkRET0cSDwoLRVZFTlRf",
            "QkVHSU4QABIPCgtFVkVOVF9CUkVBSxABEg4KCkVWRU5UX0ZBTEwQAhIRCg1F",
            "VkVOVF9SRUZSRVNIEAMSFAoQRVZFTlRfQklSRF9TS0lMTBAEEg0KCUVWRU5U",
            "X0VOVhAFEhEKDUVWRU5UX1NIVUZGTEUQBhIUChBFVkVOVF9TRVRUTEVfVEFH",
            "EAdCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.OKDFOCFDDOG), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum OKDFOCFDDOG {
    [pbr::OriginalName("EVENT_BEGIN")] EventBegin = 0,
    [pbr::OriginalName("EVENT_BREAK")] EventBreak = 1,
    [pbr::OriginalName("EVENT_FALL")] EventFall = 2,
    [pbr::OriginalName("EVENT_REFRESH")] EventRefresh = 3,
    [pbr::OriginalName("EVENT_BIRD_SKILL")] EventBirdSkill = 4,
    [pbr::OriginalName("EVENT_ENV")] EventEnv = 5,
    [pbr::OriginalName("EVENT_SHUFFLE")] EventShuffle = 6,
    [pbr::OriginalName("EVENT_SETTLE_TAG")] EventSettleTag = 7,
  }

  #endregion

}

#endregion Designer generated code
