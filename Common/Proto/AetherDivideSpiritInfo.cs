// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AetherDivideSpiritInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AetherDivideSpiritInfo.proto</summary>
  public static partial class AetherDivideSpiritInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AetherDivideSpiritInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AetherDivideSpiritInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxBZXRoZXJEaXZpZGVTcGlyaXRJbmZvLnByb3RvGg9TcEJhckluZm8ucHJv",
            "dG8aFlBhc3NpdmVTa2lsbEl0ZW0ucHJvdG8isgEKFkFldGhlckRpdmlkZVNw",
            "aXJpdEluZm8SCwoDZXhwGAwgASgNEhMKC09DUE1ERkJPR0ZQGAEgASgNEhoK",
            "BnNwX2JhchgEIAEoCzIKLlNwQmFySW5mbxIRCglwcm9tb3Rpb24YDSABKA0S",
            "EwoLQU1OTUJLSVBBT0MYDiABKA0SMgoXcGFzc2l2ZV9za2lsbF9pdGVtX2xp",
            "c3QYBSADKAsyES5QYXNzaXZlU2tpbGxJdGVtQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SpBarInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PassiveSkillItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo), global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo.Parser, new[]{ "Exp", "OCPMDFBOGFP", "SpBar", "Promotion", "AMNMBKIPAOC", "PassiveSkillItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AetherDivideSpiritInfo : pb::IMessage<AetherDivideSpiritInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AetherDivideSpiritInfo> _parser = new pb::MessageParser<AetherDivideSpiritInfo>(() => new AetherDivideSpiritInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AetherDivideSpiritInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfo(AetherDivideSpiritInfo other) : this() {
      exp_ = other.exp_;
      oCPMDFBOGFP_ = other.oCPMDFBOGFP_;
      spBar_ = other.spBar_ != null ? other.spBar_.Clone() : null;
      promotion_ = other.promotion_;
      aMNMBKIPAOC_ = other.aMNMBKIPAOC_;
      passiveSkillItemList_ = other.passiveSkillItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AetherDivideSpiritInfo Clone() {
      return new AetherDivideSpiritInfo(this);
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 12;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "OCPMDFBOGFP" field.</summary>
    public const int OCPMDFBOGFPFieldNumber = 1;
    private uint oCPMDFBOGFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OCPMDFBOGFP {
      get { return oCPMDFBOGFP_; }
      set {
        oCPMDFBOGFP_ = value;
      }
    }

    /// <summary>Field number for the "sp_bar" field.</summary>
    public const int SpBarFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.SpBarInfo spBar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpBarInfo SpBar {
      get { return spBar_; }
      set {
        spBar_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 13;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    /// <summary>Field number for the "AMNMBKIPAOC" field.</summary>
    public const int AMNMBKIPAOCFieldNumber = 14;
    private uint aMNMBKIPAOC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AMNMBKIPAOC {
      get { return aMNMBKIPAOC_; }
      set {
        aMNMBKIPAOC_ = value;
      }
    }

    /// <summary>Field number for the "passive_skill_item_list" field.</summary>
    public const int PassiveSkillItemListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PassiveSkillItem> _repeated_passiveSkillItemList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.PassiveSkillItem.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PassiveSkillItem> passiveSkillItemList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PassiveSkillItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PassiveSkillItem> PassiveSkillItemList {
      get { return passiveSkillItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AetherDivideSpiritInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AetherDivideSpiritInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Exp != other.Exp) return false;
      if (OCPMDFBOGFP != other.OCPMDFBOGFP) return false;
      if (!object.Equals(SpBar, other.SpBar)) return false;
      if (Promotion != other.Promotion) return false;
      if (AMNMBKIPAOC != other.AMNMBKIPAOC) return false;
      if(!passiveSkillItemList_.Equals(other.passiveSkillItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (OCPMDFBOGFP != 0) hash ^= OCPMDFBOGFP.GetHashCode();
      if (spBar_ != null) hash ^= SpBar.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      if (AMNMBKIPAOC != 0) hash ^= AMNMBKIPAOC.GetHashCode();
      hash ^= passiveSkillItemList_.GetHashCode();
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
      if (OCPMDFBOGFP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OCPMDFBOGFP);
      }
      if (spBar_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SpBar);
      }
      passiveSkillItemList_.WriteTo(output, _repeated_passiveSkillItemList_codec);
      if (Exp != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Exp);
      }
      if (Promotion != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Promotion);
      }
      if (AMNMBKIPAOC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AMNMBKIPAOC);
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
      if (OCPMDFBOGFP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OCPMDFBOGFP);
      }
      if (spBar_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SpBar);
      }
      passiveSkillItemList_.WriteTo(ref output, _repeated_passiveSkillItemList_codec);
      if (Exp != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Exp);
      }
      if (Promotion != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Promotion);
      }
      if (AMNMBKIPAOC != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AMNMBKIPAOC);
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
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (OCPMDFBOGFP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OCPMDFBOGFP);
      }
      if (spBar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpBar);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      if (AMNMBKIPAOC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AMNMBKIPAOC);
      }
      size += passiveSkillItemList_.CalculateSize(_repeated_passiveSkillItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AetherDivideSpiritInfo other) {
      if (other == null) {
        return;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.OCPMDFBOGFP != 0) {
        OCPMDFBOGFP = other.OCPMDFBOGFP;
      }
      if (other.spBar_ != null) {
        if (spBar_ == null) {
          SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
        }
        SpBar.MergeFrom(other.SpBar);
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      if (other.AMNMBKIPAOC != 0) {
        AMNMBKIPAOC = other.AMNMBKIPAOC;
      }
      passiveSkillItemList_.Add(other.passiveSkillItemList_);
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
            OCPMDFBOGFP = input.ReadUInt32();
            break;
          }
          case 34: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 42: {
            passiveSkillItemList_.AddEntriesFrom(input, _repeated_passiveSkillItemList_codec);
            break;
          }
          case 96: {
            Exp = input.ReadUInt32();
            break;
          }
          case 104: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 112: {
            AMNMBKIPAOC = input.ReadUInt32();
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
            OCPMDFBOGFP = input.ReadUInt32();
            break;
          }
          case 34: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 42: {
            passiveSkillItemList_.AddEntriesFrom(ref input, _repeated_passiveSkillItemList_codec);
            break;
          }
          case 96: {
            Exp = input.ReadUInt32();
            break;
          }
          case 104: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 112: {
            AMNMBKIPAOC = input.ReadUInt32();
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
