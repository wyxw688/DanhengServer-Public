// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FeatureSwitchClosedScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FeatureSwitchClosedScNotify.proto</summary>
  public static partial class FeatureSwitchClosedScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FeatureSwitchClosedScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureSwitchClosedScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFGZWF0dXJlU3dpdGNoQ2xvc2VkU2NOb3RpZnkucHJvdG8aF0ZlYXR1cmVT",
            "d2l0Y2hUeXBlLnByb3RvIkYKG0ZlYXR1cmVTd2l0Y2hDbG9zZWRTY05vdGlm",
            "eRInCgtJR0pISkNPS0pCTBgHIAEoDjISLkZlYXR1cmVTd2l0Y2hUeXBlQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FeatureSwitchTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FeatureSwitchClosedScNotify), global::EggLink.DanhengServer.Proto.FeatureSwitchClosedScNotify.Parser, new[]{ "IGJHJCOKJBL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FeatureSwitchClosedScNotify : pb::IMessage<FeatureSwitchClosedScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeatureSwitchClosedScNotify> _parser = new pb::MessageParser<FeatureSwitchClosedScNotify>(() => new FeatureSwitchClosedScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeatureSwitchClosedScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FeatureSwitchClosedScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureSwitchClosedScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureSwitchClosedScNotify(FeatureSwitchClosedScNotify other) : this() {
      iGJHJCOKJBL_ = other.iGJHJCOKJBL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureSwitchClosedScNotify Clone() {
      return new FeatureSwitchClosedScNotify(this);
    }

    /// <summary>Field number for the "IGJHJCOKJBL" field.</summary>
    public const int IGJHJCOKJBLFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.FeatureSwitchType iGJHJCOKJBL_ = global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FeatureSwitchType IGJHJCOKJBL {
      get { return iGJHJCOKJBL_; }
      set {
        iGJHJCOKJBL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeatureSwitchClosedScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeatureSwitchClosedScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IGJHJCOKJBL != other.IGJHJCOKJBL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IGJHJCOKJBL != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) hash ^= IGJHJCOKJBL.GetHashCode();
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
      if (IGJHJCOKJBL != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) IGJHJCOKJBL);
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
      if (IGJHJCOKJBL != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) IGJHJCOKJBL);
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
      if (IGJHJCOKJBL != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IGJHJCOKJBL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeatureSwitchClosedScNotify other) {
      if (other == null) {
        return;
      }
      if (other.IGJHJCOKJBL != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        IGJHJCOKJBL = other.IGJHJCOKJBL;
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
            IGJHJCOKJBL = (global::EggLink.DanhengServer.Proto.FeatureSwitchType) input.ReadEnum();
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
            IGJHJCOKJBL = (global::EggLink.DanhengServer.Proto.FeatureSwitchType) input.ReadEnum();
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
