// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ELBDNIGGHOE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ELBDNIGGHOE.proto</summary>
  public static partial class ELBDNIGGHOEReflection {

    #region Descriptor
    /// <summary>File descriptor for ELBDNIGGHOE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ELBDNIGGHOEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFTEJETklHR0hPRS5wcm90byJoCgtFTEJETklHR0hPRRITCgtGSkhPQ0hI",
            "QUhNUBgBIAEoDRITCgtKREVHSEtMS0xBSBgCIAEoARIaChJiYXR0bGVfdGFy",
            "Z2V0X2xpc3QYAyADKA0SEwoLTUdLSUdJTEtGTkEYBCABKAFCHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ELBDNIGGHOE), global::EggLink.DanhengServer.Proto.ELBDNIGGHOE.Parser, new[]{ "FJHOCHHAHMP", "JDEGHKLKLAH", "BattleTargetList", "MGKIGILKFNA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ELBDNIGGHOE : pb::IMessage<ELBDNIGGHOE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ELBDNIGGHOE> _parser = new pb::MessageParser<ELBDNIGGHOE>(() => new ELBDNIGGHOE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ELBDNIGGHOE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ELBDNIGGHOEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ELBDNIGGHOE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ELBDNIGGHOE(ELBDNIGGHOE other) : this() {
      fJHOCHHAHMP_ = other.fJHOCHHAHMP_;
      jDEGHKLKLAH_ = other.jDEGHKLKLAH_;
      battleTargetList_ = other.battleTargetList_.Clone();
      mGKIGILKFNA_ = other.mGKIGILKFNA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ELBDNIGGHOE Clone() {
      return new ELBDNIGGHOE(this);
    }

    /// <summary>Field number for the "FJHOCHHAHMP" field.</summary>
    public const int FJHOCHHAHMPFieldNumber = 1;
    private uint fJHOCHHAHMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FJHOCHHAHMP {
      get { return fJHOCHHAHMP_; }
      set {
        fJHOCHHAHMP_ = value;
      }
    }

    /// <summary>Field number for the "JDEGHKLKLAH" field.</summary>
    public const int JDEGHKLKLAHFieldNumber = 2;
    private double jDEGHKLKLAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double JDEGHKLKLAH {
      get { return jDEGHKLKLAH_; }
      set {
        jDEGHKLKLAH_ = value;
      }
    }

    /// <summary>Field number for the "battle_target_list" field.</summary>
    public const int BattleTargetListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_battleTargetList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> battleTargetList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BattleTargetList {
      get { return battleTargetList_; }
    }

    /// <summary>Field number for the "MGKIGILKFNA" field.</summary>
    public const int MGKIGILKFNAFieldNumber = 4;
    private double mGKIGILKFNA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double MGKIGILKFNA {
      get { return mGKIGILKFNA_; }
      set {
        mGKIGILKFNA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ELBDNIGGHOE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ELBDNIGGHOE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FJHOCHHAHMP != other.FJHOCHHAHMP) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(JDEGHKLKLAH, other.JDEGHKLKLAH)) return false;
      if(!battleTargetList_.Equals(other.battleTargetList_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MGKIGILKFNA, other.MGKIGILKFNA)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FJHOCHHAHMP != 0) hash ^= FJHOCHHAHMP.GetHashCode();
      if (JDEGHKLKLAH != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(JDEGHKLKLAH);
      hash ^= battleTargetList_.GetHashCode();
      if (MGKIGILKFNA != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MGKIGILKFNA);
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
      if (FJHOCHHAHMP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FJHOCHHAHMP);
      }
      if (JDEGHKLKLAH != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(JDEGHKLKLAH);
      }
      battleTargetList_.WriteTo(output, _repeated_battleTargetList_codec);
      if (MGKIGILKFNA != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(MGKIGILKFNA);
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
      if (FJHOCHHAHMP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FJHOCHHAHMP);
      }
      if (JDEGHKLKLAH != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(JDEGHKLKLAH);
      }
      battleTargetList_.WriteTo(ref output, _repeated_battleTargetList_codec);
      if (MGKIGILKFNA != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(MGKIGILKFNA);
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
      if (FJHOCHHAHMP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FJHOCHHAHMP);
      }
      if (JDEGHKLKLAH != 0D) {
        size += 1 + 8;
      }
      size += battleTargetList_.CalculateSize(_repeated_battleTargetList_codec);
      if (MGKIGILKFNA != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ELBDNIGGHOE other) {
      if (other == null) {
        return;
      }
      if (other.FJHOCHHAHMP != 0) {
        FJHOCHHAHMP = other.FJHOCHHAHMP;
      }
      if (other.JDEGHKLKLAH != 0D) {
        JDEGHKLKLAH = other.JDEGHKLKLAH;
      }
      battleTargetList_.Add(other.battleTargetList_);
      if (other.MGKIGILKFNA != 0D) {
        MGKIGILKFNA = other.MGKIGILKFNA;
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
          case 8: {
            FJHOCHHAHMP = input.ReadUInt32();
            break;
          }
          case 17: {
            JDEGHKLKLAH = input.ReadDouble();
            break;
          }
          case 26:
          case 24: {
            battleTargetList_.AddEntriesFrom(input, _repeated_battleTargetList_codec);
            break;
          }
          case 33: {
            MGKIGILKFNA = input.ReadDouble();
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
            FJHOCHHAHMP = input.ReadUInt32();
            break;
          }
          case 17: {
            JDEGHKLKLAH = input.ReadDouble();
            break;
          }
          case 26:
          case 24: {
            battleTargetList_.AddEntriesFrom(ref input, _repeated_battleTargetList_codec);
            break;
          }
          case 33: {
            MGKIGILKFNA = input.ReadDouble();
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
