// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishEmotionDialoguePerformanceCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishEmotionDialoguePerformanceCsReq.proto</summary>
  public static partial class FinishEmotionDialoguePerformanceCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishEmotionDialoguePerformanceCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishEmotionDialoguePerformanceCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitGaW5pc2hFbW90aW9uRGlhbG9ndWVQZXJmb3JtYW5jZUNzUmVxLnByb3Rv",
            "ImYKJUZpbmlzaEVtb3Rpb25EaWFsb2d1ZVBlcmZvcm1hbmNlQ3NSZXESEwoL",
            "R0JMR0RQUElGUEUYByABKA0SEwoLRkRPREVITU5QSlAYDSABKA0SEwoLQlBE",
            "S09QTUtKTU0YCiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishEmotionDialoguePerformanceCsReq), global::EggLink.DanhengServer.Proto.FinishEmotionDialoguePerformanceCsReq.Parser, new[]{ "GBLGDPPIFPE", "FDODEHMNPJP", "BPDKOPMKJMM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishEmotionDialoguePerformanceCsReq : pb::IMessage<FinishEmotionDialoguePerformanceCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishEmotionDialoguePerformanceCsReq> _parser = new pb::MessageParser<FinishEmotionDialoguePerformanceCsReq>(() => new FinishEmotionDialoguePerformanceCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishEmotionDialoguePerformanceCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishEmotionDialoguePerformanceCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishEmotionDialoguePerformanceCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishEmotionDialoguePerformanceCsReq(FinishEmotionDialoguePerformanceCsReq other) : this() {
      gBLGDPPIFPE_ = other.gBLGDPPIFPE_;
      fDODEHMNPJP_ = other.fDODEHMNPJP_;
      bPDKOPMKJMM_ = other.bPDKOPMKJMM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishEmotionDialoguePerformanceCsReq Clone() {
      return new FinishEmotionDialoguePerformanceCsReq(this);
    }

    /// <summary>Field number for the "GBLGDPPIFPE" field.</summary>
    public const int GBLGDPPIFPEFieldNumber = 7;
    private uint gBLGDPPIFPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GBLGDPPIFPE {
      get { return gBLGDPPIFPE_; }
      set {
        gBLGDPPIFPE_ = value;
      }
    }

    /// <summary>Field number for the "FDODEHMNPJP" field.</summary>
    public const int FDODEHMNPJPFieldNumber = 13;
    private uint fDODEHMNPJP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FDODEHMNPJP {
      get { return fDODEHMNPJP_; }
      set {
        fDODEHMNPJP_ = value;
      }
    }

    /// <summary>Field number for the "BPDKOPMKJMM" field.</summary>
    public const int BPDKOPMKJMMFieldNumber = 10;
    private uint bPDKOPMKJMM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BPDKOPMKJMM {
      get { return bPDKOPMKJMM_; }
      set {
        bPDKOPMKJMM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishEmotionDialoguePerformanceCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishEmotionDialoguePerformanceCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GBLGDPPIFPE != other.GBLGDPPIFPE) return false;
      if (FDODEHMNPJP != other.FDODEHMNPJP) return false;
      if (BPDKOPMKJMM != other.BPDKOPMKJMM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GBLGDPPIFPE != 0) hash ^= GBLGDPPIFPE.GetHashCode();
      if (FDODEHMNPJP != 0) hash ^= FDODEHMNPJP.GetHashCode();
      if (BPDKOPMKJMM != 0) hash ^= BPDKOPMKJMM.GetHashCode();
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
      if (GBLGDPPIFPE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GBLGDPPIFPE);
      }
      if (BPDKOPMKJMM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BPDKOPMKJMM);
      }
      if (FDODEHMNPJP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FDODEHMNPJP);
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
      if (GBLGDPPIFPE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GBLGDPPIFPE);
      }
      if (BPDKOPMKJMM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BPDKOPMKJMM);
      }
      if (FDODEHMNPJP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FDODEHMNPJP);
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
      if (GBLGDPPIFPE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GBLGDPPIFPE);
      }
      if (FDODEHMNPJP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FDODEHMNPJP);
      }
      if (BPDKOPMKJMM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BPDKOPMKJMM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishEmotionDialoguePerformanceCsReq other) {
      if (other == null) {
        return;
      }
      if (other.GBLGDPPIFPE != 0) {
        GBLGDPPIFPE = other.GBLGDPPIFPE;
      }
      if (other.FDODEHMNPJP != 0) {
        FDODEHMNPJP = other.FDODEHMNPJP;
      }
      if (other.BPDKOPMKJMM != 0) {
        BPDKOPMKJMM = other.BPDKOPMKJMM;
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
          case 56: {
            GBLGDPPIFPE = input.ReadUInt32();
            break;
          }
          case 80: {
            BPDKOPMKJMM = input.ReadUInt32();
            break;
          }
          case 104: {
            FDODEHMNPJP = input.ReadUInt32();
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
          case 56: {
            GBLGDPPIFPE = input.ReadUInt32();
            break;
          }
          case 80: {
            BPDKOPMKJMM = input.ReadUInt32();
            break;
          }
          case 104: {
            FDODEHMNPJP = input.ReadUInt32();
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
