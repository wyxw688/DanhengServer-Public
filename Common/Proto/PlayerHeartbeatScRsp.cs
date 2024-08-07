// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerHeartBeatScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerHeartBeatScRsp.proto</summary>
  public static partial class PlayerHeartBeatScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerHeartBeatScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerHeartBeatScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQbGF5ZXJIZWFydEJlYXRTY1JzcC5wcm90bxoYQ2xpZW50RG93bmxvYWRE",
            "YXRhLnByb3RvIoMBChRQbGF5ZXJIZWFydEJlYXRTY1JzcBIqCg1kb3dubG9h",
            "ZF9kYXRhGAQgASgLMhMuQ2xpZW50RG93bmxvYWREYXRhEhYKDnNlcnZlcl90",
            "aW1lX21zGAMgASgEEg8KB3JldGNvZGUYDSABKA0SFgoOY2xpZW50X3RpbWVf",
            "bXMYCyABKARCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ClientDownloadDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerHeartBeatScRsp), global::EggLink.DanhengServer.Proto.PlayerHeartBeatScRsp.Parser, new[]{ "DownloadData", "ServerTimeMs", "Retcode", "ClientTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerHeartBeatScRsp : pb::IMessage<PlayerHeartBeatScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerHeartBeatScRsp> _parser = new pb::MessageParser<PlayerHeartBeatScRsp>(() => new PlayerHeartBeatScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerHeartBeatScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerHeartBeatScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHeartBeatScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHeartBeatScRsp(PlayerHeartBeatScRsp other) : this() {
      downloadData_ = other.downloadData_ != null ? other.downloadData_.Clone() : null;
      serverTimeMs_ = other.serverTimeMs_;
      retcode_ = other.retcode_;
      clientTimeMs_ = other.clientTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerHeartBeatScRsp Clone() {
      return new PlayerHeartBeatScRsp(this);
    }

    /// <summary>Field number for the "download_data" field.</summary>
    public const int DownloadDataFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ClientDownloadData downloadData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ClientDownloadData DownloadData {
      get { return downloadData_; }
      set {
        downloadData_ = value;
      }
    }

    /// <summary>Field number for the "server_time_ms" field.</summary>
    public const int ServerTimeMsFieldNumber = 3;
    private ulong serverTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ServerTimeMs {
      get { return serverTimeMs_; }
      set {
        serverTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "client_time_ms" field.</summary>
    public const int ClientTimeMsFieldNumber = 11;
    private ulong clientTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ClientTimeMs {
      get { return clientTimeMs_; }
      set {
        clientTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerHeartBeatScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerHeartBeatScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DownloadData, other.DownloadData)) return false;
      if (ServerTimeMs != other.ServerTimeMs) return false;
      if (Retcode != other.Retcode) return false;
      if (ClientTimeMs != other.ClientTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (downloadData_ != null) hash ^= DownloadData.GetHashCode();
      if (ServerTimeMs != 0UL) hash ^= ServerTimeMs.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ClientTimeMs != 0UL) hash ^= ClientTimeMs.GetHashCode();
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
      if (ServerTimeMs != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ServerTimeMs);
      }
      if (downloadData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(DownloadData);
      }
      if (ClientTimeMs != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ClientTimeMs);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      if (ServerTimeMs != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ServerTimeMs);
      }
      if (downloadData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(DownloadData);
      }
      if (ClientTimeMs != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ClientTimeMs);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      if (downloadData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DownloadData);
      }
      if (ServerTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerTimeMs);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (ClientTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ClientTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerHeartBeatScRsp other) {
      if (other == null) {
        return;
      }
      if (other.downloadData_ != null) {
        if (downloadData_ == null) {
          DownloadData = new global::EggLink.DanhengServer.Proto.ClientDownloadData();
        }
        DownloadData.MergeFrom(other.DownloadData);
      }
      if (other.ServerTimeMs != 0UL) {
        ServerTimeMs = other.ServerTimeMs;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ClientTimeMs != 0UL) {
        ClientTimeMs = other.ClientTimeMs;
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
          case 24: {
            ServerTimeMs = input.ReadUInt64();
            break;
          }
          case 34: {
            if (downloadData_ == null) {
              DownloadData = new global::EggLink.DanhengServer.Proto.ClientDownloadData();
            }
            input.ReadMessage(DownloadData);
            break;
          }
          case 88: {
            ClientTimeMs = input.ReadUInt64();
            break;
          }
          case 104: {
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
          case 24: {
            ServerTimeMs = input.ReadUInt64();
            break;
          }
          case 34: {
            if (downloadData_ == null) {
              DownloadData = new global::EggLink.DanhengServer.Proto.ClientDownloadData();
            }
            input.ReadMessage(DownloadData);
            break;
          }
          case 88: {
            ClientTimeMs = input.ReadUInt64();
            break;
          }
          case 104: {
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
