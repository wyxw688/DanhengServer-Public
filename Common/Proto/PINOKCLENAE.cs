// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PINOKCLENAE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PINOKCLENAE.proto</summary>
  public static partial class PINOKCLENAEReflection {

    #region Descriptor
    /// <summary>File descriptor for PINOKCLENAE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PINOKCLENAEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQSU5PS0NMRU5BRS5wcm90bxoRSkpGSUNEQUhPQ0gucHJvdG8aEUFGR0VE",
            "TkpISUVILnByb3RvIlMKC1BJTk9LQ0xFTkFFEiEKC0FCSENIRUlFQk9OGAkg",
            "ASgLMgwuQUZHRUROSkhJRUgSIQoLQ09DRUNQQktHQUQYAiABKAsyDC5KSkZJ",
            "Q0RBSE9DSEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.JJFICDAHOCHReflection.Descriptor, global::EggLink.DanhengServer.Proto.AFGEDNJHIEHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PINOKCLENAE), global::EggLink.DanhengServer.Proto.PINOKCLENAE.Parser, new[]{ "ABHCHEIEBON", "COCECPBKGAD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PINOKCLENAE : pb::IMessage<PINOKCLENAE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PINOKCLENAE> _parser = new pb::MessageParser<PINOKCLENAE>(() => new PINOKCLENAE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PINOKCLENAE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PINOKCLENAEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PINOKCLENAE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PINOKCLENAE(PINOKCLENAE other) : this() {
      aBHCHEIEBON_ = other.aBHCHEIEBON_ != null ? other.aBHCHEIEBON_.Clone() : null;
      cOCECPBKGAD_ = other.cOCECPBKGAD_ != null ? other.cOCECPBKGAD_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PINOKCLENAE Clone() {
      return new PINOKCLENAE(this);
    }

    /// <summary>Field number for the "ABHCHEIEBON" field.</summary>
    public const int ABHCHEIEBONFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.AFGEDNJHIEH aBHCHEIEBON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AFGEDNJHIEH ABHCHEIEBON {
      get { return aBHCHEIEBON_; }
      set {
        aBHCHEIEBON_ = value;
      }
    }

    /// <summary>Field number for the "COCECPBKGAD" field.</summary>
    public const int COCECPBKGADFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.JJFICDAHOCH cOCECPBKGAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JJFICDAHOCH COCECPBKGAD {
      get { return cOCECPBKGAD_; }
      set {
        cOCECPBKGAD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PINOKCLENAE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PINOKCLENAE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ABHCHEIEBON, other.ABHCHEIEBON)) return false;
      if (!object.Equals(COCECPBKGAD, other.COCECPBKGAD)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (aBHCHEIEBON_ != null) hash ^= ABHCHEIEBON.GetHashCode();
      if (cOCECPBKGAD_ != null) hash ^= COCECPBKGAD.GetHashCode();
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
      if (cOCECPBKGAD_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(COCECPBKGAD);
      }
      if (aBHCHEIEBON_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ABHCHEIEBON);
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
      if (cOCECPBKGAD_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(COCECPBKGAD);
      }
      if (aBHCHEIEBON_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ABHCHEIEBON);
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
      if (aBHCHEIEBON_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ABHCHEIEBON);
      }
      if (cOCECPBKGAD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(COCECPBKGAD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PINOKCLENAE other) {
      if (other == null) {
        return;
      }
      if (other.aBHCHEIEBON_ != null) {
        if (aBHCHEIEBON_ == null) {
          ABHCHEIEBON = new global::EggLink.DanhengServer.Proto.AFGEDNJHIEH();
        }
        ABHCHEIEBON.MergeFrom(other.ABHCHEIEBON);
      }
      if (other.cOCECPBKGAD_ != null) {
        if (cOCECPBKGAD_ == null) {
          COCECPBKGAD = new global::EggLink.DanhengServer.Proto.JJFICDAHOCH();
        }
        COCECPBKGAD.MergeFrom(other.COCECPBKGAD);
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
          case 18: {
            if (cOCECPBKGAD_ == null) {
              COCECPBKGAD = new global::EggLink.DanhengServer.Proto.JJFICDAHOCH();
            }
            input.ReadMessage(COCECPBKGAD);
            break;
          }
          case 74: {
            if (aBHCHEIEBON_ == null) {
              ABHCHEIEBON = new global::EggLink.DanhengServer.Proto.AFGEDNJHIEH();
            }
            input.ReadMessage(ABHCHEIEBON);
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
          case 18: {
            if (cOCECPBKGAD_ == null) {
              COCECPBKGAD = new global::EggLink.DanhengServer.Proto.JJFICDAHOCH();
            }
            input.ReadMessage(COCECPBKGAD);
            break;
          }
          case 74: {
            if (aBHCHEIEBON_ == null) {
              ABHCHEIEBON = new global::EggLink.DanhengServer.Proto.AFGEDNJHIEH();
            }
            input.ReadMessage(ABHCHEIEBON);
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
