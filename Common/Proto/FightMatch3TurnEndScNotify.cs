// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightMatch3TurnEndScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightMatch3TurnEndScNotify.proto</summary>
  public static partial class FightMatch3TurnEndScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FightMatch3TurnEndScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightMatch3TurnEndScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBGaWdodE1hdGNoM1R1cm5FbmRTY05vdGlmeS5wcm90bxoRTkZJTUNQTkVJ",
            "Rk4ucHJvdG8iYgoaRmlnaHRNYXRjaDNUdXJuRW5kU2NOb3RpZnkSIQoLRUNI",
            "RkJKSEpJRkQYASABKAsyDC5ORklNQ1BORUlGThIhCgtDS0tQT0VNQkFQRxgM",
            "IAEoCzIMLk5GSU1DUE5FSUZOQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NFIMCPNEIFNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightMatch3TurnEndScNotify), global::EggLink.DanhengServer.Proto.FightMatch3TurnEndScNotify.Parser, new[]{ "ECHFBJHJIFD", "CKKPOEMBAPG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightMatch3TurnEndScNotify : pb::IMessage<FightMatch3TurnEndScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightMatch3TurnEndScNotify> _parser = new pb::MessageParser<FightMatch3TurnEndScNotify>(() => new FightMatch3TurnEndScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightMatch3TurnEndScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightMatch3TurnEndScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3TurnEndScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3TurnEndScNotify(FightMatch3TurnEndScNotify other) : this() {
      eCHFBJHJIFD_ = other.eCHFBJHJIFD_ != null ? other.eCHFBJHJIFD_.Clone() : null;
      cKKPOEMBAPG_ = other.cKKPOEMBAPG_ != null ? other.cKKPOEMBAPG_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightMatch3TurnEndScNotify Clone() {
      return new FightMatch3TurnEndScNotify(this);
    }

    /// <summary>Field number for the "ECHFBJHJIFD" field.</summary>
    public const int ECHFBJHJIFDFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.NFIMCPNEIFN eCHFBJHJIFD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NFIMCPNEIFN ECHFBJHJIFD {
      get { return eCHFBJHJIFD_; }
      set {
        eCHFBJHJIFD_ = value;
      }
    }

    /// <summary>Field number for the "CKKPOEMBAPG" field.</summary>
    public const int CKKPOEMBAPGFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.NFIMCPNEIFN cKKPOEMBAPG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NFIMCPNEIFN CKKPOEMBAPG {
      get { return cKKPOEMBAPG_; }
      set {
        cKKPOEMBAPG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightMatch3TurnEndScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightMatch3TurnEndScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ECHFBJHJIFD, other.ECHFBJHJIFD)) return false;
      if (!object.Equals(CKKPOEMBAPG, other.CKKPOEMBAPG)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eCHFBJHJIFD_ != null) hash ^= ECHFBJHJIFD.GetHashCode();
      if (cKKPOEMBAPG_ != null) hash ^= CKKPOEMBAPG.GetHashCode();
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
      if (eCHFBJHJIFD_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ECHFBJHJIFD);
      }
      if (cKKPOEMBAPG_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CKKPOEMBAPG);
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
      if (eCHFBJHJIFD_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ECHFBJHJIFD);
      }
      if (cKKPOEMBAPG_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CKKPOEMBAPG);
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
      if (eCHFBJHJIFD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ECHFBJHJIFD);
      }
      if (cKKPOEMBAPG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CKKPOEMBAPG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightMatch3TurnEndScNotify other) {
      if (other == null) {
        return;
      }
      if (other.eCHFBJHJIFD_ != null) {
        if (eCHFBJHJIFD_ == null) {
          ECHFBJHJIFD = new global::EggLink.DanhengServer.Proto.NFIMCPNEIFN();
        }
        ECHFBJHJIFD.MergeFrom(other.ECHFBJHJIFD);
      }
      if (other.cKKPOEMBAPG_ != null) {
        if (cKKPOEMBAPG_ == null) {
          CKKPOEMBAPG = new global::EggLink.DanhengServer.Proto.NFIMCPNEIFN();
        }
        CKKPOEMBAPG.MergeFrom(other.CKKPOEMBAPG);
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
          case 10: {
            if (eCHFBJHJIFD_ == null) {
              ECHFBJHJIFD = new global::EggLink.DanhengServer.Proto.NFIMCPNEIFN();
            }
            input.ReadMessage(ECHFBJHJIFD);
            break;
          }
          case 98: {
            if (cKKPOEMBAPG_ == null) {
              CKKPOEMBAPG = new global::EggLink.DanhengServer.Proto.NFIMCPNEIFN();
            }
            input.ReadMessage(CKKPOEMBAPG);
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
          case 10: {
            if (eCHFBJHJIFD_ == null) {
              ECHFBJHJIFD = new global::EggLink.DanhengServer.Proto.NFIMCPNEIFN();
            }
            input.ReadMessage(ECHFBJHJIFD);
            break;
          }
          case 98: {
            if (cKKPOEMBAPG_ == null) {
              CKKPOEMBAPG = new global::EggLink.DanhengServer.Proto.NFIMCPNEIFN();
            }
            input.ReadMessage(CKKPOEMBAPG);
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
