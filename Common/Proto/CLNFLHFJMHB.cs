// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CLNFLHFJMHB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CLNFLHFJMHB.proto</summary>
  public static partial class CLNFLHFJMHBReflection {

    #region Descriptor
    /// <summary>File descriptor for CLNFLHFJMHB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CLNFLHFJMHBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDTE5GTEhGSk1IQi5wcm90byJhCgtDTE5GTEhGSk1IQhITCgtFR0xDQk5K",
            "T01QRBgMIAMoDRITCgtKT0NFS0hLSkpITBgPIAEoCBITCgtCSUxLRk5BTEdM",
            "QRgDIAEoDRITCgtKTkVFRkZGT0lHRhgKIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CLNFLHFJMHB), global::EggLink.DanhengServer.Proto.CLNFLHFJMHB.Parser, new[]{ "EGLCBNJOMPD", "JOCEKHKJJHL", "BILKFNALGLA", "JNEEFFFOIGF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CLNFLHFJMHB : pb::IMessage<CLNFLHFJMHB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CLNFLHFJMHB> _parser = new pb::MessageParser<CLNFLHFJMHB>(() => new CLNFLHFJMHB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CLNFLHFJMHB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CLNFLHFJMHBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLNFLHFJMHB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLNFLHFJMHB(CLNFLHFJMHB other) : this() {
      eGLCBNJOMPD_ = other.eGLCBNJOMPD_.Clone();
      jOCEKHKJJHL_ = other.jOCEKHKJJHL_;
      bILKFNALGLA_ = other.bILKFNALGLA_;
      jNEEFFFOIGF_ = other.jNEEFFFOIGF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLNFLHFJMHB Clone() {
      return new CLNFLHFJMHB(this);
    }

    /// <summary>Field number for the "EGLCBNJOMPD" field.</summary>
    public const int EGLCBNJOMPDFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_eGLCBNJOMPD_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> eGLCBNJOMPD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EGLCBNJOMPD {
      get { return eGLCBNJOMPD_; }
    }

    /// <summary>Field number for the "JOCEKHKJJHL" field.</summary>
    public const int JOCEKHKJJHLFieldNumber = 15;
    private bool jOCEKHKJJHL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JOCEKHKJJHL {
      get { return jOCEKHKJJHL_; }
      set {
        jOCEKHKJJHL_ = value;
      }
    }

    /// <summary>Field number for the "BILKFNALGLA" field.</summary>
    public const int BILKFNALGLAFieldNumber = 3;
    private uint bILKFNALGLA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BILKFNALGLA {
      get { return bILKFNALGLA_; }
      set {
        bILKFNALGLA_ = value;
      }
    }

    /// <summary>Field number for the "JNEEFFFOIGF" field.</summary>
    public const int JNEEFFFOIGFFieldNumber = 10;
    private uint jNEEFFFOIGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JNEEFFFOIGF {
      get { return jNEEFFFOIGF_; }
      set {
        jNEEFFFOIGF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CLNFLHFJMHB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CLNFLHFJMHB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!eGLCBNJOMPD_.Equals(other.eGLCBNJOMPD_)) return false;
      if (JOCEKHKJJHL != other.JOCEKHKJJHL) return false;
      if (BILKFNALGLA != other.BILKFNALGLA) return false;
      if (JNEEFFFOIGF != other.JNEEFFFOIGF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= eGLCBNJOMPD_.GetHashCode();
      if (JOCEKHKJJHL != false) hash ^= JOCEKHKJJHL.GetHashCode();
      if (BILKFNALGLA != 0) hash ^= BILKFNALGLA.GetHashCode();
      if (JNEEFFFOIGF != 0) hash ^= JNEEFFFOIGF.GetHashCode();
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
      if (BILKFNALGLA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BILKFNALGLA);
      }
      if (JNEEFFFOIGF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JNEEFFFOIGF);
      }
      eGLCBNJOMPD_.WriteTo(output, _repeated_eGLCBNJOMPD_codec);
      if (JOCEKHKJJHL != false) {
        output.WriteRawTag(120);
        output.WriteBool(JOCEKHKJJHL);
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
      if (BILKFNALGLA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BILKFNALGLA);
      }
      if (JNEEFFFOIGF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JNEEFFFOIGF);
      }
      eGLCBNJOMPD_.WriteTo(ref output, _repeated_eGLCBNJOMPD_codec);
      if (JOCEKHKJJHL != false) {
        output.WriteRawTag(120);
        output.WriteBool(JOCEKHKJJHL);
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
      size += eGLCBNJOMPD_.CalculateSize(_repeated_eGLCBNJOMPD_codec);
      if (JOCEKHKJJHL != false) {
        size += 1 + 1;
      }
      if (BILKFNALGLA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BILKFNALGLA);
      }
      if (JNEEFFFOIGF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JNEEFFFOIGF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CLNFLHFJMHB other) {
      if (other == null) {
        return;
      }
      eGLCBNJOMPD_.Add(other.eGLCBNJOMPD_);
      if (other.JOCEKHKJJHL != false) {
        JOCEKHKJJHL = other.JOCEKHKJJHL;
      }
      if (other.BILKFNALGLA != 0) {
        BILKFNALGLA = other.BILKFNALGLA;
      }
      if (other.JNEEFFFOIGF != 0) {
        JNEEFFFOIGF = other.JNEEFFFOIGF;
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
          case 24: {
            BILKFNALGLA = input.ReadUInt32();
            break;
          }
          case 80: {
            JNEEFFFOIGF = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            eGLCBNJOMPD_.AddEntriesFrom(input, _repeated_eGLCBNJOMPD_codec);
            break;
          }
          case 120: {
            JOCEKHKJJHL = input.ReadBool();
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
          case 24: {
            BILKFNALGLA = input.ReadUInt32();
            break;
          }
          case 80: {
            JNEEFFFOIGF = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            eGLCBNJOMPD_.AddEntriesFrom(ref input, _repeated_eGLCBNJOMPD_codec);
            break;
          }
          case 120: {
            JOCEKHKJJHL = input.ReadBool();
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
