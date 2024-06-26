// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetHeroBasicTypeInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetHeroBasicTypeInfoScRsp.proto</summary>
  public static partial class GetHeroBasicTypeInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetHeroBasicTypeInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetHeroBasicTypeInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRIZXJvQmFzaWNUeXBlSW5mb1NjUnNwLnByb3RvGh1QbGF5ZXJIZXJv",
            "QmFzaWNUeXBlSW5mby5wcm90bxoTSGVyb0Jhc2ljVHlwZS5wcm90bxoMR2Vu",
            "ZGVyLnByb3RvItYBChlHZXRIZXJvQmFzaWNUeXBlSW5mb1NjUnNwEhcKBmdl",
            "bmRlchgHIAEoDjIHLkdlbmRlchImCg5jdXJfYmFzaWNfdHlwZRgIIAEoDjIO",
            "Lkhlcm9CYXNpY1R5cGUSGgoSaXNfZ2VuZGVyX21vZGlmaWVkGAUgASgIEjYK",
            "FGJhc2ljX3R5cGVfaW5mb19saXN0GAkgAygLMhguUGxheWVySGVyb0Jhc2lj",
            "VHlwZUluZm8SDwoHcmV0Y29kZRgBIAEoDRITCgtGR0xBRkxIS0ZFThgOIAEo",
            "CEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeroBasicTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.GenderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetHeroBasicTypeInfoScRsp), global::EggLink.DanhengServer.Proto.GetHeroBasicTypeInfoScRsp.Parser, new[]{ "Gender", "CurBasicType", "IsGenderModified", "BasicTypeInfoList", "Retcode", "FGLAFLHKFEN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetHeroBasicTypeInfoScRsp : pb::IMessage<GetHeroBasicTypeInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetHeroBasicTypeInfoScRsp> _parser = new pb::MessageParser<GetHeroBasicTypeInfoScRsp>(() => new GetHeroBasicTypeInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetHeroBasicTypeInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetHeroBasicTypeInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeroBasicTypeInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeroBasicTypeInfoScRsp(GetHeroBasicTypeInfoScRsp other) : this() {
      gender_ = other.gender_;
      curBasicType_ = other.curBasicType_;
      isGenderModified_ = other.isGenderModified_;
      basicTypeInfoList_ = other.basicTypeInfoList_.Clone();
      retcode_ = other.retcode_;
      fGLAFLHKFEN_ = other.fGLAFLHKFEN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeroBasicTypeInfoScRsp Clone() {
      return new GetHeroBasicTypeInfoScRsp(this);
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.Gender gender_ = global::EggLink.DanhengServer.Proto.Gender.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.Gender Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "cur_basic_type" field.</summary>
    public const int CurBasicTypeFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.HeroBasicType curBasicType_ = global::EggLink.DanhengServer.Proto.HeroBasicType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeroBasicType CurBasicType {
      get { return curBasicType_; }
      set {
        curBasicType_ = value;
      }
    }

    /// <summary>Field number for the "is_gender_modified" field.</summary>
    public const int IsGenderModifiedFieldNumber = 5;
    private bool isGenderModified_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGenderModified {
      get { return isGenderModified_; }
      set {
        isGenderModified_ = value;
      }
    }

    /// <summary>Field number for the "basic_type_info_list" field.</summary>
    public const int BasicTypeInfoListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo> _repeated_basicTypeInfoList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo> basicTypeInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo> BasicTypeInfoList {
      get { return basicTypeInfoList_; }
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

    /// <summary>Field number for the "FGLAFLHKFEN" field.</summary>
    public const int FGLAFLHKFENFieldNumber = 14;
    private bool fGLAFLHKFEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FGLAFLHKFEN {
      get { return fGLAFLHKFEN_; }
      set {
        fGLAFLHKFEN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetHeroBasicTypeInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetHeroBasicTypeInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Gender != other.Gender) return false;
      if (CurBasicType != other.CurBasicType) return false;
      if (IsGenderModified != other.IsGenderModified) return false;
      if(!basicTypeInfoList_.Equals(other.basicTypeInfoList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (FGLAFLHKFEN != other.FGLAFLHKFEN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) hash ^= Gender.GetHashCode();
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) hash ^= CurBasicType.GetHashCode();
      if (IsGenderModified != false) hash ^= IsGenderModified.GetHashCode();
      hash ^= basicTypeInfoList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (FGLAFLHKFEN != false) hash ^= FGLAFLHKFEN.GetHashCode();
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
      if (IsGenderModified != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsGenderModified);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Gender);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) CurBasicType);
      }
      basicTypeInfoList_.WriteTo(output, _repeated_basicTypeInfoList_codec);
      if (FGLAFLHKFEN != false) {
        output.WriteRawTag(112);
        output.WriteBool(FGLAFLHKFEN);
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
      if (IsGenderModified != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsGenderModified);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Gender);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) CurBasicType);
      }
      basicTypeInfoList_.WriteTo(ref output, _repeated_basicTypeInfoList_codec);
      if (FGLAFLHKFEN != false) {
        output.WriteRawTag(112);
        output.WriteBool(FGLAFLHKFEN);
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
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CurBasicType);
      }
      if (IsGenderModified != false) {
        size += 1 + 1;
      }
      size += basicTypeInfoList_.CalculateSize(_repeated_basicTypeInfoList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (FGLAFLHKFEN != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetHeroBasicTypeInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        Gender = other.Gender;
      }
      if (other.CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        CurBasicType = other.CurBasicType;
      }
      if (other.IsGenderModified != false) {
        IsGenderModified = other.IsGenderModified;
      }
      basicTypeInfoList_.Add(other.basicTypeInfoList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.FGLAFLHKFEN != false) {
        FGLAFLHKFEN = other.FGLAFLHKFEN;
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
          case 40: {
            IsGenderModified = input.ReadBool();
            break;
          }
          case 56: {
            Gender = (global::EggLink.DanhengServer.Proto.Gender) input.ReadEnum();
            break;
          }
          case 64: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 74: {
            basicTypeInfoList_.AddEntriesFrom(input, _repeated_basicTypeInfoList_codec);
            break;
          }
          case 112: {
            FGLAFLHKFEN = input.ReadBool();
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
          case 40: {
            IsGenderModified = input.ReadBool();
            break;
          }
          case 56: {
            Gender = (global::EggLink.DanhengServer.Proto.Gender) input.ReadEnum();
            break;
          }
          case 64: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 74: {
            basicTypeInfoList_.AddEntriesFrom(ref input, _repeated_basicTypeInfoList_codec);
            break;
          }
          case 112: {
            FGLAFLHKFEN = input.ReadBool();
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
