// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFantasticStoryActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFantasticStoryActivityDataScRsp.proto</summary>
  public static partial class GetFantasticStoryActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFantasticStoryActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFantasticStoryActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihHZXRGYW50YXN0aWNTdG9yeUFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhtG",
            "YW50YXN0aWNBY3Rpdml0eURhdGEucHJvdG8iYgoiR2V0RmFudGFzdGljU3Rv",
            "cnlBY3Rpdml0eURhdGFTY1JzcBIPCgdyZXRjb2RlGAEgASgNEisKC0NQQ09I",
            "SVBITkxFGAsgASgLMhYuRmFudGFzdGljQWN0aXZpdHlEYXRhQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FantasticActivityDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFantasticStoryActivityDataScRsp), global::EggLink.DanhengServer.Proto.GetFantasticStoryActivityDataScRsp.Parser, new[]{ "Retcode", "CPCOHIPHNLE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFantasticStoryActivityDataScRsp : pb::IMessage<GetFantasticStoryActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFantasticStoryActivityDataScRsp> _parser = new pb::MessageParser<GetFantasticStoryActivityDataScRsp>(() => new GetFantasticStoryActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFantasticStoryActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFantasticStoryActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFantasticStoryActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFantasticStoryActivityDataScRsp(GetFantasticStoryActivityDataScRsp other) : this() {
      retcode_ = other.retcode_;
      cPCOHIPHNLE_ = other.cPCOHIPHNLE_ != null ? other.cPCOHIPHNLE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFantasticStoryActivityDataScRsp Clone() {
      return new GetFantasticStoryActivityDataScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CPCOHIPHNLE" field.</summary>
    public const int CPCOHIPHNLEFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.FantasticActivityData cPCOHIPHNLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FantasticActivityData CPCOHIPHNLE {
      get { return cPCOHIPHNLE_; }
      set {
        cPCOHIPHNLE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFantasticStoryActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFantasticStoryActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(CPCOHIPHNLE, other.CPCOHIPHNLE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (cPCOHIPHNLE_ != null) hash ^= CPCOHIPHNLE.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (cPCOHIPHNLE_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CPCOHIPHNLE);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (cPCOHIPHNLE_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CPCOHIPHNLE);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (cPCOHIPHNLE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CPCOHIPHNLE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFantasticStoryActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.cPCOHIPHNLE_ != null) {
        if (cPCOHIPHNLE_ == null) {
          CPCOHIPHNLE = new global::EggLink.DanhengServer.Proto.FantasticActivityData();
        }
        CPCOHIPHNLE.MergeFrom(other.CPCOHIPHNLE);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (cPCOHIPHNLE_ == null) {
              CPCOHIPHNLE = new global::EggLink.DanhengServer.Proto.FantasticActivityData();
            }
            input.ReadMessage(CPCOHIPHNLE);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (cPCOHIPHNLE_ == null) {
              CPCOHIPHNLE = new global::EggLink.DanhengServer.Proto.FantasticActivityData();
            }
            input.ReadMessage(CPCOHIPHNLE);
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
