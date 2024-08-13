﻿using EggLink.DanhengServer.Kcp;

namespace EggLink.DanhengServer.GameServer.Server.Packet.Recv.Chat;

[Opcode(CmdIds.GetChatFriendHistoryCsReq)]
public class HandlerGetChatFriendHistoryCsReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(CmdIds.GetChatFriendHistoryScRsp);
    }
}