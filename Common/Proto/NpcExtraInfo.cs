// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NpcExtraInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NpcExtraInfo.proto</summary>
  public static partial class NpcExtraInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for NpcExtraInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NpcExtraInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJOcGNFeHRyYUluZm8ucHJvdG8aEUNIS01OTktNTFBMLnByb3RvGhJOcGNS",
            "b2d1ZUluZm8ucHJvdG8aEUJDUExKRUpKQUVOLnByb3RvIncKDE5wY0V4dHJh",
            "SW5mbxIhCgpyb2d1ZV9pbmZvGAkgASgLMg0uTnBjUm9ndWVJbmZvEiEKC0lG",
            "TExOR0hKQkVHGAUgASgLMgwuQ0hLTU5OS01MUEwSIQoLSEZFUElNRFBFR0UY",
            "ByABKAsyDC5CQ1BMSkVKSkFFTkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CHKMNNKMLPLReflection.Descriptor, global::EggLink.DanhengServer.Proto.NpcRogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.BCPLJEJJAENReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NpcExtraInfo), global::EggLink.DanhengServer.Proto.NpcExtraInfo.Parser, new[]{ "RogueInfo", "IFLLNGHJBEG", "HFEPIMDPEGE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NpcExtraInfo : pb::IMessage<NpcExtraInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NpcExtraInfo> _parser = new pb::MessageParser<NpcExtraInfo>(() => new NpcExtraInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NpcExtraInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NpcExtraInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NpcExtraInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NpcExtraInfo(NpcExtraInfo other) : this() {
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      iFLLNGHJBEG_ = other.iFLLNGHJBEG_ != null ? other.iFLLNGHJBEG_.Clone() : null;
      hFEPIMDPEGE_ = other.hFEPIMDPEGE_ != null ? other.hFEPIMDPEGE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NpcExtraInfo Clone() {
      return new NpcExtraInfo(this);
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.NpcRogueInfo rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NpcRogueInfo RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "IFLLNGHJBEG" field.</summary>
    public const int IFLLNGHJBEGFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.CHKMNNKMLPL iFLLNGHJBEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CHKMNNKMLPL IFLLNGHJBEG {
      get { return iFLLNGHJBEG_; }
      set {
        iFLLNGHJBEG_ = value;
      }
    }

    /// <summary>Field number for the "HFEPIMDPEGE" field.</summary>
    public const int HFEPIMDPEGEFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.BCPLJEJJAEN hFEPIMDPEGE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BCPLJEJJAEN HFEPIMDPEGE {
      get { return hFEPIMDPEGE_; }
      set {
        hFEPIMDPEGE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NpcExtraInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NpcExtraInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (!object.Equals(IFLLNGHJBEG, other.IFLLNGHJBEG)) return false;
      if (!object.Equals(HFEPIMDPEGE, other.HFEPIMDPEGE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (iFLLNGHJBEG_ != null) hash ^= IFLLNGHJBEG.GetHashCode();
      if (hFEPIMDPEGE_ != null) hash ^= HFEPIMDPEGE.GetHashCode();
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
      if (iFLLNGHJBEG_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(IFLLNGHJBEG);
      }
      if (hFEPIMDPEGE_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HFEPIMDPEGE);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueInfo);
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
      if (iFLLNGHJBEG_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(IFLLNGHJBEG);
      }
      if (hFEPIMDPEGE_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HFEPIMDPEGE);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueInfo);
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
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (iFLLNGHJBEG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IFLLNGHJBEG);
      }
      if (hFEPIMDPEGE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HFEPIMDPEGE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NpcExtraInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.NpcRogueInfo();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
      }
      if (other.iFLLNGHJBEG_ != null) {
        if (iFLLNGHJBEG_ == null) {
          IFLLNGHJBEG = new global::EggLink.DanhengServer.Proto.CHKMNNKMLPL();
        }
        IFLLNGHJBEG.MergeFrom(other.IFLLNGHJBEG);
      }
      if (other.hFEPIMDPEGE_ != null) {
        if (hFEPIMDPEGE_ == null) {
          HFEPIMDPEGE = new global::EggLink.DanhengServer.Proto.BCPLJEJJAEN();
        }
        HFEPIMDPEGE.MergeFrom(other.HFEPIMDPEGE);
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
          case 42: {
            if (iFLLNGHJBEG_ == null) {
              IFLLNGHJBEG = new global::EggLink.DanhengServer.Proto.CHKMNNKMLPL();
            }
            input.ReadMessage(IFLLNGHJBEG);
            break;
          }
          case 58: {
            if (hFEPIMDPEGE_ == null) {
              HFEPIMDPEGE = new global::EggLink.DanhengServer.Proto.BCPLJEJJAEN();
            }
            input.ReadMessage(HFEPIMDPEGE);
            break;
          }
          case 74: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.NpcRogueInfo();
            }
            input.ReadMessage(RogueInfo);
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
          case 42: {
            if (iFLLNGHJBEG_ == null) {
              IFLLNGHJBEG = new global::EggLink.DanhengServer.Proto.CHKMNNKMLPL();
            }
            input.ReadMessage(IFLLNGHJBEG);
            break;
          }
          case 58: {
            if (hFEPIMDPEGE_ == null) {
              HFEPIMDPEGE = new global::EggLink.DanhengServer.Proto.BCPLJEJJAEN();
            }
            input.ReadMessage(HFEPIMDPEGE);
            break;
          }
          case 74: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.NpcRogueInfo();
            }
            input.ReadMessage(RogueInfo);
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
