// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BPAFCEPNOAI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BPAFCEPNOAI.proto</summary>
  public static partial class BPAFCEPNOAIReflection {

    #region Descriptor
    /// <summary>File descriptor for BPAFCEPNOAI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BPAFCEPNOAIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCUEFGQ0VQTk9BSS5wcm90byqFAQoLQlBBRkNFUE5PQUkSIQodSEVBUlRf",
            "RElBTF9VTkxPQ0tfU1RBVFVTX0xPQ0sQABIqCiZIRUFSVF9ESUFMX1VOTE9D",
            "S19TVEFUVVNfVU5MT0NLX1NJTkdMRRABEicKI0hFQVJUX0RJQUxfVU5MT0NL",
            "X1NUQVRVU19VTkxPQ0tfQUxMEAJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.BPAFCEPNOAI), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum BPAFCEPNOAI {
    [pbr::OriginalName("HEART_DIAL_UNLOCK_STATUS_LOCK")] HeartDialUnlockStatusLock = 0,
    [pbr::OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_SINGLE")] HeartDialUnlockStatusUnlockSingle = 1,
    [pbr::OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_ALL")] HeartDialUnlockStatusUnlockAll = 2,
  }

  #endregion

}

#endregion Designer generated code
