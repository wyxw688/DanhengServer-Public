// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAlleyInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAlleyInfoScRsp.proto</summary>
  public static partial class GetAlleyInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAlleyInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAlleyInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHZXRBbGxleUluZm9TY1JzcC5wcm90bxoRRkhNRUZNS0FQTEgucHJvdG8a",
            "EVBBSE5FQkJCTURMLnByb3RvGhFJTUtBSU1FQ0RLTS5wcm90bxoRRUhPRUxM",
            "UE5DRksucHJvdG8ilgMKEUdldEFsbGV5SW5mb1NjUnNwEiEKC0JLSEdFRUhP",
            "R0RQGAUgASgLMgwuRkhNRUZNS0FQTEgSEwoLUEhKSU5QRkVOUE8YCCADKA0S",
            "EwoLQkRMTUFQQ0dGQlAYASABKA0SEwoLRElBS0ZIUElPRUoYBCADKA0SEwoL",
            "SU9IRE1FQ01GRkwYCiADKA0SDQoFbGV2ZWwYDyABKA0SOAoLTURGSE9LQ0pP",
            "QkMYAiADKAsyIy5HZXRBbGxleUluZm9TY1JzcC5NREZIT0tDSk9CQ0VudHJ5",
            "EhMKC0xFSUxPQ0ZKTkJNGAkgASgNEiEKC0hDSEdIQkJER0VHGAMgASgLMgwu",
            "RUhPRUxMUE5DRksSIQoLSUZJT0pIREZJSEkYDCADKAsyDC5JTUtBSU1FQ0RL",
            "TRIPCgdyZXRjb2RlGAcgASgNEiEKC0ZMRkFLUEdBS01OGAYgASgLMgwuUEFI",
            "TkVCQkJNREwaMgoQTURGSE9LQ0pPQkNFbnRyeRILCgNrZXkYASABKA0SDQoF",
            "dmFsdWUYAiABKA06AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FHMEFMKAPLHReflection.Descriptor, global::EggLink.DanhengServer.Proto.PAHNEBBBMDLReflection.Descriptor, global::EggLink.DanhengServer.Proto.IMKAIMECDKMReflection.Descriptor, global::EggLink.DanhengServer.Proto.EHOELLPNCFKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAlleyInfoScRsp), global::EggLink.DanhengServer.Proto.GetAlleyInfoScRsp.Parser, new[]{ "BKHGEEHOGDP", "PHJINPFENPO", "BDLMAPCGFBP", "DIAKFHPIOEJ", "IOHDMECMFFL", "Level", "MDFHOKCJOBC", "LEILOCFJNBM", "HCHGHBBDGEG", "IFIOJHDFIHI", "Retcode", "FLFAKPGAKMN" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAlleyInfoScRsp : pb::IMessage<GetAlleyInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAlleyInfoScRsp> _parser = new pb::MessageParser<GetAlleyInfoScRsp>(() => new GetAlleyInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAlleyInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAlleyInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAlleyInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAlleyInfoScRsp(GetAlleyInfoScRsp other) : this() {
      bKHGEEHOGDP_ = other.bKHGEEHOGDP_ != null ? other.bKHGEEHOGDP_.Clone() : null;
      pHJINPFENPO_ = other.pHJINPFENPO_.Clone();
      bDLMAPCGFBP_ = other.bDLMAPCGFBP_;
      dIAKFHPIOEJ_ = other.dIAKFHPIOEJ_.Clone();
      iOHDMECMFFL_ = other.iOHDMECMFFL_.Clone();
      level_ = other.level_;
      mDFHOKCJOBC_ = other.mDFHOKCJOBC_.Clone();
      lEILOCFJNBM_ = other.lEILOCFJNBM_;
      hCHGHBBDGEG_ = other.hCHGHBBDGEG_ != null ? other.hCHGHBBDGEG_.Clone() : null;
      iFIOJHDFIHI_ = other.iFIOJHDFIHI_.Clone();
      retcode_ = other.retcode_;
      fLFAKPGAKMN_ = other.fLFAKPGAKMN_ != null ? other.fLFAKPGAKMN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAlleyInfoScRsp Clone() {
      return new GetAlleyInfoScRsp(this);
    }

    /// <summary>Field number for the "BKHGEEHOGDP" field.</summary>
    public const int BKHGEEHOGDPFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.FHMEFMKAPLH bKHGEEHOGDP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FHMEFMKAPLH BKHGEEHOGDP {
      get { return bKHGEEHOGDP_; }
      set {
        bKHGEEHOGDP_ = value;
      }
    }

    /// <summary>Field number for the "PHJINPFENPO" field.</summary>
    public const int PHJINPFENPOFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_pHJINPFENPO_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> pHJINPFENPO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PHJINPFENPO {
      get { return pHJINPFENPO_; }
    }

    /// <summary>Field number for the "BDLMAPCGFBP" field.</summary>
    public const int BDLMAPCGFBPFieldNumber = 1;
    private uint bDLMAPCGFBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BDLMAPCGFBP {
      get { return bDLMAPCGFBP_; }
      set {
        bDLMAPCGFBP_ = value;
      }
    }

    /// <summary>Field number for the "DIAKFHPIOEJ" field.</summary>
    public const int DIAKFHPIOEJFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_dIAKFHPIOEJ_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> dIAKFHPIOEJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DIAKFHPIOEJ {
      get { return dIAKFHPIOEJ_; }
    }

    /// <summary>Field number for the "IOHDMECMFFL" field.</summary>
    public const int IOHDMECMFFLFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_iOHDMECMFFL_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> iOHDMECMFFL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IOHDMECMFFL {
      get { return iOHDMECMFFL_; }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 15;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "MDFHOKCJOBC" field.</summary>
    public const int MDFHOKCJOBCFieldNumber = 2;
    private static readonly pbc::MapField<uint, uint>.Codec _map_mDFHOKCJOBC_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 18);
    private readonly pbc::MapField<uint, uint> mDFHOKCJOBC_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> MDFHOKCJOBC {
      get { return mDFHOKCJOBC_; }
    }

    /// <summary>Field number for the "LEILOCFJNBM" field.</summary>
    public const int LEILOCFJNBMFieldNumber = 9;
    private uint lEILOCFJNBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LEILOCFJNBM {
      get { return lEILOCFJNBM_; }
      set {
        lEILOCFJNBM_ = value;
      }
    }

    /// <summary>Field number for the "HCHGHBBDGEG" field.</summary>
    public const int HCHGHBBDGEGFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.EHOELLPNCFK hCHGHBBDGEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EHOELLPNCFK HCHGHBBDGEG {
      get { return hCHGHBBDGEG_; }
      set {
        hCHGHBBDGEG_ = value;
      }
    }

    /// <summary>Field number for the "IFIOJHDFIHI" field.</summary>
    public const int IFIOJHDFIHIFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.IMKAIMECDKM> _repeated_iFIOJHDFIHI_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.IMKAIMECDKM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IMKAIMECDKM> iFIOJHDFIHI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IMKAIMECDKM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IMKAIMECDKM> IFIOJHDFIHI {
      get { return iFIOJHDFIHI_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "FLFAKPGAKMN" field.</summary>
    public const int FLFAKPGAKMNFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.PAHNEBBBMDL fLFAKPGAKMN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PAHNEBBBMDL FLFAKPGAKMN {
      get { return fLFAKPGAKMN_; }
      set {
        fLFAKPGAKMN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAlleyInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAlleyInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BKHGEEHOGDP, other.BKHGEEHOGDP)) return false;
      if(!pHJINPFENPO_.Equals(other.pHJINPFENPO_)) return false;
      if (BDLMAPCGFBP != other.BDLMAPCGFBP) return false;
      if(!dIAKFHPIOEJ_.Equals(other.dIAKFHPIOEJ_)) return false;
      if(!iOHDMECMFFL_.Equals(other.iOHDMECMFFL_)) return false;
      if (Level != other.Level) return false;
      if (!MDFHOKCJOBC.Equals(other.MDFHOKCJOBC)) return false;
      if (LEILOCFJNBM != other.LEILOCFJNBM) return false;
      if (!object.Equals(HCHGHBBDGEG, other.HCHGHBBDGEG)) return false;
      if(!iFIOJHDFIHI_.Equals(other.iFIOJHDFIHI_)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(FLFAKPGAKMN, other.FLFAKPGAKMN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (bKHGEEHOGDP_ != null) hash ^= BKHGEEHOGDP.GetHashCode();
      hash ^= pHJINPFENPO_.GetHashCode();
      if (BDLMAPCGFBP != 0) hash ^= BDLMAPCGFBP.GetHashCode();
      hash ^= dIAKFHPIOEJ_.GetHashCode();
      hash ^= iOHDMECMFFL_.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= MDFHOKCJOBC.GetHashCode();
      if (LEILOCFJNBM != 0) hash ^= LEILOCFJNBM.GetHashCode();
      if (hCHGHBBDGEG_ != null) hash ^= HCHGHBBDGEG.GetHashCode();
      hash ^= iFIOJHDFIHI_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (fLFAKPGAKMN_ != null) hash ^= FLFAKPGAKMN.GetHashCode();
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
      if (BDLMAPCGFBP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BDLMAPCGFBP);
      }
      mDFHOKCJOBC_.WriteTo(output, _map_mDFHOKCJOBC_codec);
      if (hCHGHBBDGEG_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HCHGHBBDGEG);
      }
      dIAKFHPIOEJ_.WriteTo(output, _repeated_dIAKFHPIOEJ_codec);
      if (bKHGEEHOGDP_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BKHGEEHOGDP);
      }
      if (fLFAKPGAKMN_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FLFAKPGAKMN);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      pHJINPFENPO_.WriteTo(output, _repeated_pHJINPFENPO_codec);
      if (LEILOCFJNBM != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LEILOCFJNBM);
      }
      iOHDMECMFFL_.WriteTo(output, _repeated_iOHDMECMFFL_codec);
      iFIOJHDFIHI_.WriteTo(output, _repeated_iFIOJHDFIHI_codec);
      if (Level != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Level);
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
      if (BDLMAPCGFBP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BDLMAPCGFBP);
      }
      mDFHOKCJOBC_.WriteTo(ref output, _map_mDFHOKCJOBC_codec);
      if (hCHGHBBDGEG_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HCHGHBBDGEG);
      }
      dIAKFHPIOEJ_.WriteTo(ref output, _repeated_dIAKFHPIOEJ_codec);
      if (bKHGEEHOGDP_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BKHGEEHOGDP);
      }
      if (fLFAKPGAKMN_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FLFAKPGAKMN);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      pHJINPFENPO_.WriteTo(ref output, _repeated_pHJINPFENPO_codec);
      if (LEILOCFJNBM != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LEILOCFJNBM);
      }
      iOHDMECMFFL_.WriteTo(ref output, _repeated_iOHDMECMFFL_codec);
      iFIOJHDFIHI_.WriteTo(ref output, _repeated_iFIOJHDFIHI_codec);
      if (Level != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Level);
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
      if (bKHGEEHOGDP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BKHGEEHOGDP);
      }
      size += pHJINPFENPO_.CalculateSize(_repeated_pHJINPFENPO_codec);
      if (BDLMAPCGFBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BDLMAPCGFBP);
      }
      size += dIAKFHPIOEJ_.CalculateSize(_repeated_dIAKFHPIOEJ_codec);
      size += iOHDMECMFFL_.CalculateSize(_repeated_iOHDMECMFFL_codec);
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += mDFHOKCJOBC_.CalculateSize(_map_mDFHOKCJOBC_codec);
      if (LEILOCFJNBM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LEILOCFJNBM);
      }
      if (hCHGHBBDGEG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HCHGHBBDGEG);
      }
      size += iFIOJHDFIHI_.CalculateSize(_repeated_iFIOJHDFIHI_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (fLFAKPGAKMN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FLFAKPGAKMN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAlleyInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.bKHGEEHOGDP_ != null) {
        if (bKHGEEHOGDP_ == null) {
          BKHGEEHOGDP = new global::EggLink.DanhengServer.Proto.FHMEFMKAPLH();
        }
        BKHGEEHOGDP.MergeFrom(other.BKHGEEHOGDP);
      }
      pHJINPFENPO_.Add(other.pHJINPFENPO_);
      if (other.BDLMAPCGFBP != 0) {
        BDLMAPCGFBP = other.BDLMAPCGFBP;
      }
      dIAKFHPIOEJ_.Add(other.dIAKFHPIOEJ_);
      iOHDMECMFFL_.Add(other.iOHDMECMFFL_);
      if (other.Level != 0) {
        Level = other.Level;
      }
      mDFHOKCJOBC_.MergeFrom(other.mDFHOKCJOBC_);
      if (other.LEILOCFJNBM != 0) {
        LEILOCFJNBM = other.LEILOCFJNBM;
      }
      if (other.hCHGHBBDGEG_ != null) {
        if (hCHGHBBDGEG_ == null) {
          HCHGHBBDGEG = new global::EggLink.DanhengServer.Proto.EHOELLPNCFK();
        }
        HCHGHBBDGEG.MergeFrom(other.HCHGHBBDGEG);
      }
      iFIOJHDFIHI_.Add(other.iFIOJHDFIHI_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.fLFAKPGAKMN_ != null) {
        if (fLFAKPGAKMN_ == null) {
          FLFAKPGAKMN = new global::EggLink.DanhengServer.Proto.PAHNEBBBMDL();
        }
        FLFAKPGAKMN.MergeFrom(other.FLFAKPGAKMN);
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
            BDLMAPCGFBP = input.ReadUInt32();
            break;
          }
          case 18: {
            mDFHOKCJOBC_.AddEntriesFrom(input, _map_mDFHOKCJOBC_codec);
            break;
          }
          case 26: {
            if (hCHGHBBDGEG_ == null) {
              HCHGHBBDGEG = new global::EggLink.DanhengServer.Proto.EHOELLPNCFK();
            }
            input.ReadMessage(HCHGHBBDGEG);
            break;
          }
          case 34:
          case 32: {
            dIAKFHPIOEJ_.AddEntriesFrom(input, _repeated_dIAKFHPIOEJ_codec);
            break;
          }
          case 42: {
            if (bKHGEEHOGDP_ == null) {
              BKHGEEHOGDP = new global::EggLink.DanhengServer.Proto.FHMEFMKAPLH();
            }
            input.ReadMessage(BKHGEEHOGDP);
            break;
          }
          case 50: {
            if (fLFAKPGAKMN_ == null) {
              FLFAKPGAKMN = new global::EggLink.DanhengServer.Proto.PAHNEBBBMDL();
            }
            input.ReadMessage(FLFAKPGAKMN);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            pHJINPFENPO_.AddEntriesFrom(input, _repeated_pHJINPFENPO_codec);
            break;
          }
          case 72: {
            LEILOCFJNBM = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            iOHDMECMFFL_.AddEntriesFrom(input, _repeated_iOHDMECMFFL_codec);
            break;
          }
          case 98: {
            iFIOJHDFIHI_.AddEntriesFrom(input, _repeated_iFIOJHDFIHI_codec);
            break;
          }
          case 120: {
            Level = input.ReadUInt32();
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
            BDLMAPCGFBP = input.ReadUInt32();
            break;
          }
          case 18: {
            mDFHOKCJOBC_.AddEntriesFrom(ref input, _map_mDFHOKCJOBC_codec);
            break;
          }
          case 26: {
            if (hCHGHBBDGEG_ == null) {
              HCHGHBBDGEG = new global::EggLink.DanhengServer.Proto.EHOELLPNCFK();
            }
            input.ReadMessage(HCHGHBBDGEG);
            break;
          }
          case 34:
          case 32: {
            dIAKFHPIOEJ_.AddEntriesFrom(ref input, _repeated_dIAKFHPIOEJ_codec);
            break;
          }
          case 42: {
            if (bKHGEEHOGDP_ == null) {
              BKHGEEHOGDP = new global::EggLink.DanhengServer.Proto.FHMEFMKAPLH();
            }
            input.ReadMessage(BKHGEEHOGDP);
            break;
          }
          case 50: {
            if (fLFAKPGAKMN_ == null) {
              FLFAKPGAKMN = new global::EggLink.DanhengServer.Proto.PAHNEBBBMDL();
            }
            input.ReadMessage(FLFAKPGAKMN);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            pHJINPFENPO_.AddEntriesFrom(ref input, _repeated_pHJINPFENPO_codec);
            break;
          }
          case 72: {
            LEILOCFJNBM = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            iOHDMECMFFL_.AddEntriesFrom(ref input, _repeated_iOHDMECMFFL_codec);
            break;
          }
          case 98: {
            iFIOJHDFIHI_.AddEntriesFrom(ref input, _repeated_iFIOJHDFIHI_codec);
            break;
          }
          case 120: {
            Level = input.ReadUInt32();
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
