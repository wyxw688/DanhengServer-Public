// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EFEEMPHMFKI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EFEEMPHMFKI.proto</summary>
  public static partial class EFEEMPHMFKIReflection {

    #region Descriptor
    /// <summary>File descriptor for EFEEMPHMFKI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EFEEMPHMFKIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFRkVFTVBITUZLSS5wcm90byqIAQoLRUZFRU1QSE1GS0kSHQoZTUFUQ0gz",
            "X1BMQVlFUl9TVEFURV9BTElWRRAAEh0KGU1BVENIM19QTEFZRVJfU1RBVEVf",
            "RFlJTkcQARIcChhNQVRDSDNfUExBWUVSX1NUQVRFX0RFQUQQAhIdChlNQVRD",
            "SDNfUExBWUVSX1NUQVRFX0xFQVZFEANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.EFEEMPHMFKI), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EFEEMPHMFKI {
    [pbr::OriginalName("MATCH3_PLAYER_STATE_ALIVE")] Match3PlayerStateAlive = 0,
    [pbr::OriginalName("MATCH3_PLAYER_STATE_DYING")] Match3PlayerStateDying = 1,
    [pbr::OriginalName("MATCH3_PLAYER_STATE_DEAD")] Match3PlayerStateDead = 2,
    [pbr::OriginalName("MATCH3_PLAYER_STATE_LEAVE")] Match3PlayerStateLeave = 3,
  }

  #endregion

}

#endregion Designer generated code
