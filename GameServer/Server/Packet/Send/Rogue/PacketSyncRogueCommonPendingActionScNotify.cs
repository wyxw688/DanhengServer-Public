﻿using EggLink.DanhengServer.Game.Rogue;
using EggLink.DanhengServer.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Send.Rogue
{
    public class PacketSyncRogueCommonPendingActionScNotify : BasePacket
    {
        public PacketSyncRogueCommonPendingActionScNotify(RogueActionInstance actionInstance, int rogueSubmode) : base(CmdIds.SyncRogueCommonPendingActionScNotify)
        {
            var proto = new SyncRogueCommonPendingActionScNotify
            {
                Action = actionInstance.ToProto(),
                RogueSubMode = (uint)rogueSubmode,
            };

            SetData(proto);
        }
    }
}
