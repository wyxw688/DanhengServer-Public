// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NIALDNOAGLG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NIALDNOAGLG.proto</summary>
  public static partial class NIALDNOAGLGReflection {

    #region Descriptor
    /// <summary>File descriptor for NIALDNOAGLG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NIALDNOAGLGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOSUFMRE5PQUdMRy5wcm90byJhCgtOSUFMRE5PQUdMRxITCgtQQUJKR0RK",
            "RVBMSBgBIAEoDRITCgtORUlKTUNPUEdLRRgCIAEoCBITCgtHUENQSE9PQ0FN",
            "RhgDIAEoDRITCgtOSUtHSEJPTEFOSBgEIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NIALDNOAGLG), global::EggLink.DanhengServer.Proto.NIALDNOAGLG.Parser, new[]{ "PABJGDJEPLH", "NEIJMCOPGKE", "GPCPHOOCAMF", "NIKGHBOLANH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NIALDNOAGLG : pb::IMessage<NIALDNOAGLG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NIALDNOAGLG> _parser = new pb::MessageParser<NIALDNOAGLG>(() => new NIALDNOAGLG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NIALDNOAGLG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NIALDNOAGLGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NIALDNOAGLG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NIALDNOAGLG(NIALDNOAGLG other) : this() {
      pABJGDJEPLH_ = other.pABJGDJEPLH_;
      nEIJMCOPGKE_ = other.nEIJMCOPGKE_;
      gPCPHOOCAMF_ = other.gPCPHOOCAMF_;
      nIKGHBOLANH_ = other.nIKGHBOLANH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NIALDNOAGLG Clone() {
      return new NIALDNOAGLG(this);
    }

    /// <summary>Field number for the "PABJGDJEPLH" field.</summary>
    public const int PABJGDJEPLHFieldNumber = 1;
    private uint pABJGDJEPLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PABJGDJEPLH {
      get { return pABJGDJEPLH_; }
      set {
        pABJGDJEPLH_ = value;
      }
    }

    /// <summary>Field number for the "NEIJMCOPGKE" field.</summary>
    public const int NEIJMCOPGKEFieldNumber = 2;
    private bool nEIJMCOPGKE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NEIJMCOPGKE {
      get { return nEIJMCOPGKE_; }
      set {
        nEIJMCOPGKE_ = value;
      }
    }

    /// <summary>Field number for the "GPCPHOOCAMF" field.</summary>
    public const int GPCPHOOCAMFFieldNumber = 3;
    private uint gPCPHOOCAMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GPCPHOOCAMF {
      get { return gPCPHOOCAMF_; }
      set {
        gPCPHOOCAMF_ = value;
      }
    }

    /// <summary>Field number for the "NIKGHBOLANH" field.</summary>
    public const int NIKGHBOLANHFieldNumber = 4;
    private uint nIKGHBOLANH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NIKGHBOLANH {
      get { return nIKGHBOLANH_; }
      set {
        nIKGHBOLANH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NIALDNOAGLG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NIALDNOAGLG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PABJGDJEPLH != other.PABJGDJEPLH) return false;
      if (NEIJMCOPGKE != other.NEIJMCOPGKE) return false;
      if (GPCPHOOCAMF != other.GPCPHOOCAMF) return false;
      if (NIKGHBOLANH != other.NIKGHBOLANH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PABJGDJEPLH != 0) hash ^= PABJGDJEPLH.GetHashCode();
      if (NEIJMCOPGKE != false) hash ^= NEIJMCOPGKE.GetHashCode();
      if (GPCPHOOCAMF != 0) hash ^= GPCPHOOCAMF.GetHashCode();
      if (NIKGHBOLANH != 0) hash ^= NIKGHBOLANH.GetHashCode();
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
      if (PABJGDJEPLH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PABJGDJEPLH);
      }
      if (NEIJMCOPGKE != false) {
        output.WriteRawTag(16);
        output.WriteBool(NEIJMCOPGKE);
      }
      if (GPCPHOOCAMF != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GPCPHOOCAMF);
      }
      if (NIKGHBOLANH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NIKGHBOLANH);
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
      if (PABJGDJEPLH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PABJGDJEPLH);
      }
      if (NEIJMCOPGKE != false) {
        output.WriteRawTag(16);
        output.WriteBool(NEIJMCOPGKE);
      }
      if (GPCPHOOCAMF != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GPCPHOOCAMF);
      }
      if (NIKGHBOLANH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NIKGHBOLANH);
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
      if (PABJGDJEPLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PABJGDJEPLH);
      }
      if (NEIJMCOPGKE != false) {
        size += 1 + 1;
      }
      if (GPCPHOOCAMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GPCPHOOCAMF);
      }
      if (NIKGHBOLANH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NIKGHBOLANH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NIALDNOAGLG other) {
      if (other == null) {
        return;
      }
      if (other.PABJGDJEPLH != 0) {
        PABJGDJEPLH = other.PABJGDJEPLH;
      }
      if (other.NEIJMCOPGKE != false) {
        NEIJMCOPGKE = other.NEIJMCOPGKE;
      }
      if (other.GPCPHOOCAMF != 0) {
        GPCPHOOCAMF = other.GPCPHOOCAMF;
      }
      if (other.NIKGHBOLANH != 0) {
        NIKGHBOLANH = other.NIKGHBOLANH;
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
            PABJGDJEPLH = input.ReadUInt32();
            break;
          }
          case 16: {
            NEIJMCOPGKE = input.ReadBool();
            break;
          }
          case 24: {
            GPCPHOOCAMF = input.ReadUInt32();
            break;
          }
          case 32: {
            NIKGHBOLANH = input.ReadUInt32();
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
            PABJGDJEPLH = input.ReadUInt32();
            break;
          }
          case 16: {
            NEIJMCOPGKE = input.ReadBool();
            break;
          }
          case 24: {
            GPCPHOOCAMF = input.ReadUInt32();
            break;
          }
          case 32: {
            NIKGHBOLANH = input.ReadUInt32();
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
