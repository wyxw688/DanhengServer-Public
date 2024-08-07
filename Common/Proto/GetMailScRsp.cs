// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMailScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMailScRsp.proto</summary>
  public static partial class GetMailScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMailScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMailScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHZXRNYWlsU2NSc3AucHJvdG8aEENsaWVudE1haWwucHJvdG8imAEKDEdl",
            "dE1haWxTY1JzcBIeCgltYWlsX2xpc3QYAiADKAsyCy5DbGllbnRNYWlsEg4K",
            "BmlzX2VuZBgBIAEoCBIPCgdyZXRjb2RlGAMgASgNEg0KBXN0YXJ0GA0gASgN",
            "EhEKCXRvdGFsX251bRgOIAEoDRIlChBub3RpY2VfbWFpbF9saXN0GAUgAygL",
            "MgsuQ2xpZW50TWFpbEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ClientMailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMailScRsp), global::EggLink.DanhengServer.Proto.GetMailScRsp.Parser, new[]{ "MailList", "IsEnd", "Retcode", "Start", "TotalNum", "NoticeMailList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMailScRsp : pb::IMessage<GetMailScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMailScRsp> _parser = new pb::MessageParser<GetMailScRsp>(() => new GetMailScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMailScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMailScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMailScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMailScRsp(GetMailScRsp other) : this() {
      mailList_ = other.mailList_.Clone();
      isEnd_ = other.isEnd_;
      retcode_ = other.retcode_;
      start_ = other.start_;
      totalNum_ = other.totalNum_;
      noticeMailList_ = other.noticeMailList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMailScRsp Clone() {
      return new GetMailScRsp(this);
    }

    /// <summary>Field number for the "mail_list" field.</summary>
    public const int MailListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ClientMail> _repeated_mailList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.ClientMail.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> mailList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> MailList {
      get { return mailList_; }
    }

    /// <summary>Field number for the "is_end" field.</summary>
    public const int IsEndFieldNumber = 1;
    private bool isEnd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEnd {
      get { return isEnd_; }
      set {
        isEnd_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 13;
    private uint start_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "total_num" field.</summary>
    public const int TotalNumFieldNumber = 14;
    private uint totalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalNum {
      get { return totalNum_; }
      set {
        totalNum_ = value;
      }
    }

    /// <summary>Field number for the "notice_mail_list" field.</summary>
    public const int NoticeMailListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ClientMail> _repeated_noticeMailList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.ClientMail.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> noticeMailList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ClientMail> NoticeMailList {
      get { return noticeMailList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMailScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMailScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mailList_.Equals(other.mailList_)) return false;
      if (IsEnd != other.IsEnd) return false;
      if (Retcode != other.Retcode) return false;
      if (Start != other.Start) return false;
      if (TotalNum != other.TotalNum) return false;
      if(!noticeMailList_.Equals(other.noticeMailList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mailList_.GetHashCode();
      if (IsEnd != false) hash ^= IsEnd.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Start != 0) hash ^= Start.GetHashCode();
      if (TotalNum != 0) hash ^= TotalNum.GetHashCode();
      hash ^= noticeMailList_.GetHashCode();
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
      if (IsEnd != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsEnd);
      }
      mailList_.WriteTo(output, _repeated_mailList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      noticeMailList_.WriteTo(output, _repeated_noticeMailList_codec);
      if (Start != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Start);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalNum);
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
      if (IsEnd != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsEnd);
      }
      mailList_.WriteTo(ref output, _repeated_mailList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      noticeMailList_.WriteTo(ref output, _repeated_noticeMailList_codec);
      if (Start != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Start);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalNum);
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
      size += mailList_.CalculateSize(_repeated_mailList_codec);
      if (IsEnd != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (Start != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Start);
      }
      if (TotalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalNum);
      }
      size += noticeMailList_.CalculateSize(_repeated_noticeMailList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMailScRsp other) {
      if (other == null) {
        return;
      }
      mailList_.Add(other.mailList_);
      if (other.IsEnd != false) {
        IsEnd = other.IsEnd;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Start != 0) {
        Start = other.Start;
      }
      if (other.TotalNum != 0) {
        TotalNum = other.TotalNum;
      }
      noticeMailList_.Add(other.noticeMailList_);
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
            IsEnd = input.ReadBool();
            break;
          }
          case 18: {
            mailList_.AddEntriesFrom(input, _repeated_mailList_codec);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            noticeMailList_.AddEntriesFrom(input, _repeated_noticeMailList_codec);
            break;
          }
          case 104: {
            Start = input.ReadUInt32();
            break;
          }
          case 112: {
            TotalNum = input.ReadUInt32();
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
            IsEnd = input.ReadBool();
            break;
          }
          case 18: {
            mailList_.AddEntriesFrom(ref input, _repeated_mailList_codec);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            noticeMailList_.AddEntriesFrom(ref input, _repeated_noticeMailList_codec);
            break;
          }
          case 104: {
            Start = input.ReadUInt32();
            break;
          }
          case 112: {
            TotalNum = input.ReadUInt32();
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
