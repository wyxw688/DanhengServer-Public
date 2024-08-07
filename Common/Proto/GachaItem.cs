// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GachaItem.proto</summary>
  public static partial class GachaItemReflection {

    #region Descriptor
    /// <summary>File descriptor for GachaItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9HYWNoYUl0ZW0ucHJvdG8aCkl0ZW0ucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
            "InwKCUdhY2hhSXRlbRIZCgpnYWNoYV9pdGVtGA0gASgLMgUuSXRlbRIdCgp0",
            "b2tlbl9pdGVtGAggASgLMgkuSXRlbUxpc3QSDgoGaXNfbmV3GAogASgIEiUK",
            "EnRyYW5zZmVyX2l0ZW1fbGlzdBgPIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GachaItem), global::EggLink.DanhengServer.Proto.GachaItem.Parser, new[]{ "GachaItem_", "TokenItem", "IsNew", "TransferItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GachaItem : pb::IMessage<GachaItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaItem> _parser = new pb::MessageParser<GachaItem>(() => new GachaItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GachaItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaItem(GachaItem other) : this() {
      gachaItem_ = other.gachaItem_ != null ? other.gachaItem_.Clone() : null;
      tokenItem_ = other.tokenItem_ != null ? other.tokenItem_.Clone() : null;
      isNew_ = other.isNew_;
      transferItemList_ = other.transferItemList_ != null ? other.transferItemList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaItem Clone() {
      return new GachaItem(this);
    }

    /// <summary>Field number for the "gacha_item" field.</summary>
    public const int GachaItem_FieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.Item gachaItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.Item GachaItem_ {
      get { return gachaItem_; }
      set {
        gachaItem_ = value;
      }
    }

    /// <summary>Field number for the "token_item" field.</summary>
    public const int TokenItemFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ItemList tokenItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList TokenItem {
      get { return tokenItem_; }
      set {
        tokenItem_ = value;
      }
    }

    /// <summary>Field number for the "is_new" field.</summary>
    public const int IsNewFieldNumber = 10;
    private bool isNew_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNew {
      get { return isNew_; }
      set {
        isNew_ = value;
      }
    }

    /// <summary>Field number for the "transfer_item_list" field.</summary>
    public const int TransferItemListFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ItemList transferItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList TransferItemList {
      get { return transferItemList_; }
      set {
        transferItemList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GachaItem_, other.GachaItem_)) return false;
      if (!object.Equals(TokenItem, other.TokenItem)) return false;
      if (IsNew != other.IsNew) return false;
      if (!object.Equals(TransferItemList, other.TransferItemList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gachaItem_ != null) hash ^= GachaItem_.GetHashCode();
      if (tokenItem_ != null) hash ^= TokenItem.GetHashCode();
      if (IsNew != false) hash ^= IsNew.GetHashCode();
      if (transferItemList_ != null) hash ^= TransferItemList.GetHashCode();
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
      if (tokenItem_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TokenItem);
      }
      if (IsNew != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNew);
      }
      if (gachaItem_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(GachaItem_);
      }
      if (transferItemList_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TransferItemList);
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
      if (tokenItem_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(TokenItem);
      }
      if (IsNew != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNew);
      }
      if (gachaItem_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(GachaItem_);
      }
      if (transferItemList_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TransferItemList);
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
      if (gachaItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GachaItem_);
      }
      if (tokenItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TokenItem);
      }
      if (IsNew != false) {
        size += 1 + 1;
      }
      if (transferItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TransferItemList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaItem other) {
      if (other == null) {
        return;
      }
      if (other.gachaItem_ != null) {
        if (gachaItem_ == null) {
          GachaItem_ = new global::EggLink.DanhengServer.Proto.Item();
        }
        GachaItem_.MergeFrom(other.GachaItem_);
      }
      if (other.tokenItem_ != null) {
        if (tokenItem_ == null) {
          TokenItem = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        TokenItem.MergeFrom(other.TokenItem);
      }
      if (other.IsNew != false) {
        IsNew = other.IsNew;
      }
      if (other.transferItemList_ != null) {
        if (transferItemList_ == null) {
          TransferItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        TransferItemList.MergeFrom(other.TransferItemList);
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
          case 66: {
            if (tokenItem_ == null) {
              TokenItem = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(TokenItem);
            break;
          }
          case 80: {
            IsNew = input.ReadBool();
            break;
          }
          case 106: {
            if (gachaItem_ == null) {
              GachaItem_ = new global::EggLink.DanhengServer.Proto.Item();
            }
            input.ReadMessage(GachaItem_);
            break;
          }
          case 122: {
            if (transferItemList_ == null) {
              TransferItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(TransferItemList);
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
          case 66: {
            if (tokenItem_ == null) {
              TokenItem = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(TokenItem);
            break;
          }
          case 80: {
            IsNew = input.ReadBool();
            break;
          }
          case 106: {
            if (gachaItem_ == null) {
              GachaItem_ = new global::EggLink.DanhengServer.Proto.Item();
            }
            input.ReadMessage(GachaItem_);
            break;
          }
          case 122: {
            if (transferItemList_ == null) {
              TransferItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(TransferItemList);
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
