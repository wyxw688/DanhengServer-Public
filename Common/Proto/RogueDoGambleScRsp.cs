// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDoGambleScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueDoGambleScRsp.proto</summary>
  public static partial class RogueDoGambleScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDoGambleScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDoGambleScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZURvR2FtYmxlU2NSc3AucHJvdG8aFVJvZ3VlR2FtYmxlSW5mby5w",
            "cm90byJ2ChJSb2d1ZURvR2FtYmxlU2NSc3ASEwoLQUNKREpNQk9EQU0YAiAB",
            "KA0SJQoLZ2FtYmxlX2luZm8YCyABKAsyEC5Sb2d1ZUdhbWJsZUluZm8SEwoL",
            "SUdJRUhQSEdLRkwYASABKA0SDwoHcmV0Y29kZRgOIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueGambleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueDoGambleScRsp), global::EggLink.DanhengServer.Proto.RogueDoGambleScRsp.Parser, new[]{ "ACJDJMBODAM", "GambleInfo", "IGIEHPHGKFL", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueDoGambleScRsp : pb::IMessage<RogueDoGambleScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDoGambleScRsp> _parser = new pb::MessageParser<RogueDoGambleScRsp>(() => new RogueDoGambleScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDoGambleScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueDoGambleScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDoGambleScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDoGambleScRsp(RogueDoGambleScRsp other) : this() {
      aCJDJMBODAM_ = other.aCJDJMBODAM_;
      gambleInfo_ = other.gambleInfo_ != null ? other.gambleInfo_.Clone() : null;
      iGIEHPHGKFL_ = other.iGIEHPHGKFL_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDoGambleScRsp Clone() {
      return new RogueDoGambleScRsp(this);
    }

    /// <summary>Field number for the "ACJDJMBODAM" field.</summary>
    public const int ACJDJMBODAMFieldNumber = 2;
    private uint aCJDJMBODAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ACJDJMBODAM {
      get { return aCJDJMBODAM_; }
      set {
        aCJDJMBODAM_ = value;
      }
    }

    /// <summary>Field number for the "gamble_info" field.</summary>
    public const int GambleInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueGambleInfo gambleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueGambleInfo GambleInfo {
      get { return gambleInfo_; }
      set {
        gambleInfo_ = value;
      }
    }

    /// <summary>Field number for the "IGIEHPHGKFL" field.</summary>
    public const int IGIEHPHGKFLFieldNumber = 1;
    private uint iGIEHPHGKFL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IGIEHPHGKFL {
      get { return iGIEHPHGKFL_; }
      set {
        iGIEHPHGKFL_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDoGambleScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDoGambleScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ACJDJMBODAM != other.ACJDJMBODAM) return false;
      if (!object.Equals(GambleInfo, other.GambleInfo)) return false;
      if (IGIEHPHGKFL != other.IGIEHPHGKFL) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ACJDJMBODAM != 0) hash ^= ACJDJMBODAM.GetHashCode();
      if (gambleInfo_ != null) hash ^= GambleInfo.GetHashCode();
      if (IGIEHPHGKFL != 0) hash ^= IGIEHPHGKFL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (IGIEHPHGKFL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IGIEHPHGKFL);
      }
      if (ACJDJMBODAM != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ACJDJMBODAM);
      }
      if (gambleInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(GambleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      if (IGIEHPHGKFL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IGIEHPHGKFL);
      }
      if (ACJDJMBODAM != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ACJDJMBODAM);
      }
      if (gambleInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(GambleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      if (ACJDJMBODAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ACJDJMBODAM);
      }
      if (gambleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GambleInfo);
      }
      if (IGIEHPHGKFL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IGIEHPHGKFL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDoGambleScRsp other) {
      if (other == null) {
        return;
      }
      if (other.ACJDJMBODAM != 0) {
        ACJDJMBODAM = other.ACJDJMBODAM;
      }
      if (other.gambleInfo_ != null) {
        if (gambleInfo_ == null) {
          GambleInfo = new global::EggLink.DanhengServer.Proto.RogueGambleInfo();
        }
        GambleInfo.MergeFrom(other.GambleInfo);
      }
      if (other.IGIEHPHGKFL != 0) {
        IGIEHPHGKFL = other.IGIEHPHGKFL;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            IGIEHPHGKFL = input.ReadUInt32();
            break;
          }
          case 16: {
            ACJDJMBODAM = input.ReadUInt32();
            break;
          }
          case 90: {
            if (gambleInfo_ == null) {
              GambleInfo = new global::EggLink.DanhengServer.Proto.RogueGambleInfo();
            }
            input.ReadMessage(GambleInfo);
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
            IGIEHPHGKFL = input.ReadUInt32();
            break;
          }
          case 16: {
            ACJDJMBODAM = input.ReadUInt32();
            break;
          }
          case 90: {
            if (gambleInfo_ == null) {
              GambleInfo = new global::EggLink.DanhengServer.Proto.RogueGambleInfo();
            }
            input.ReadMessage(GambleInfo);
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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