﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Data.Config;
using EggLink.DanhengServer.Data.Custom;
using EggLink.DanhengServer.Data.Excel;
using EggLink.DanhengServer.Enums.Rogue;
using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Util;

namespace EggLink.DanhengServer.GameServer.Game.ChessRogue.Cell;

public class ChessRogueCellInstance
{
    public ChessRogueCellInstance(ChessRogueInstance instance, RogueChestGridItem item)
    {
        Instance = instance;
        Layer = instance.Layers.IndexOf(instance.CurLayer) + 1;
        var list = new RandomList<RogueDLCBlockTypeEnum>();
        list.Add(RogueDLCBlockTypeEnum.MonsterNormal, 8);
        list.Add(RogueDLCBlockTypeEnum.Reward, 4);
        list.Add(RogueDLCBlockTypeEnum.Event, 6);
        list.Add(RogueDLCBlockTypeEnum.NousSpecialEvent, 4);
        list.Add(RogueDLCBlockTypeEnum.NousEvent, 2);

        if (item.BlockTypeList.Count > 0)
            CellType = item.BlockTypeList.RandomElement();
        else
            CellType = list.GetRandom();
    }

    public RogueDLCBlockTypeEnum CellType { get; set; }
    public int PosY { get; set; }
    public int PosX { get; set; }
    public int CellId { get; set; }
    public int RoomId { get; set; }
    public int Layer { get; set; } = 1;
    public int MapId { get; set; }
    public ChessRogueInstance Instance { get; set; }
    public ChessRogueBoardCellStatus CellStatus { get; set; } = ChessRogueBoardCellStatus.Idle;
    public ChessRogueRoomConfig? RoomConfig { get; set; }
    public int SelectMonsterId { get; set; }

    public List<int> SelectedDecayId { get; set; } = [];

    public List<ChessRogueCellAdvanceInfo> CellAdvanceInfo { get; set; } = [];

    public void Init()
    {
        if (CellType == RogueDLCBlockTypeEnum.MonsterBoss)
        {
            // boss
            if (Layer == 1)
            {
                var randomList = new List<int>();
                foreach (var i in Enumerable.Range(101, 7))
                {
                    if (i == 103) continue;
                    randomList.Add(i);
                }

                var random1 = randomList.RandomElement();
                randomList.Remove(random1);
                CellAdvanceInfo.Add(new ChessRogueCellAdvanceInfo
                {
                    BossDecayId = random1,
                    MonsterId = Random.Shared.Next(221001, 221018)
                });

                CellAdvanceInfo.Add(new ChessRogueCellAdvanceInfo
                {
                    BossDecayId = randomList.RandomElement(),
                    MonsterId = Random.Shared.Next(221001, 221018)
                });
            }
            else
            {
                var randomList = new List<int>();
                foreach (var i in Enumerable.Range(2, 3)) randomList.Add(i * 10 + 101);

                var random1 = randomList.RandomElement();
                randomList.Remove(random1);

                CellAdvanceInfo.Add(new ChessRogueCellAdvanceInfo
                {
                    BossDecayId = random1,
                    MonsterId = Random.Shared.Next(222001, 222007)
                });

                CellAdvanceInfo.Add(new ChessRogueCellAdvanceInfo
                {
                    BossDecayId = randomList.RandomElement(),
                    MonsterId = Random.Shared.Next(222001, 222017)
                });
            }
        }
        else if (CellType == RogueDLCBlockTypeEnum.MonsterNousBoss ||
                 CellType == RogueDLCBlockTypeEnum.MonsterSwarmBoss)
        {
            // last boss
            CellAdvanceInfo.Add(new ChessRogueCellAdvanceInfo
            {
                BossDecayId = 114,
                MonsterId = 223003
            });
            CellAdvanceInfo.Add(new ChessRogueCellAdvanceInfo
            {
                BossDecayId = 102 + Instance.BossAeonId * 10,
                MonsterId = Random.Shared.Next(223001, 223003)
            });

            foreach (var decay in Instance.BossBuff) SelectedDecayId.Add(decay.BossDecayID);
        }
    }

    public int GetBossAeonId(int monsterId)
    {
        var info = CellAdvanceInfo.Find(x => x.MonsterId == monsterId);
        if (info != null) return Math.Max((info.BossDecayId - 101) / 10, 0);
        return 0;
    }

    public RogueDLCBossDecayExcel? GetBossDecayExcel(int monsterId)
    {
        var info = CellAdvanceInfo.Find(x => x.MonsterId == monsterId);
        if (info != null)
        {
            GameData.RogueDLCBossDecayData.TryGetValue(info.BossDecayId, out var excel);
            return excel;
        }

        return null;
    }

    public int GetCellId()
    {
        return CellId;
    }

    public int GetEntryId()
    {
        if (RoomConfig == null)
        {
            var pool = GameData.ChessRogueRoomData[CellType].FindAll(x => x.EntranceId == Instance.LayerMap).ToList();
            RoomConfig = pool.RandomElement();
            if (Instance.FirstEnterBattle && CellType == RogueDLCBlockTypeEnum.MonsterNormal)
            {
                do
                {
                    RoomConfig = pool.RandomElement();
                } while (RoomConfig.SubMonsterGroup.Count == 0); // make sure the room has sub monster

                Instance.FirstEnterBattle = false;
            }

            RoomId = RoomConfig.RoomPrefix * 10000 + (int)CellType * 100 +
                     Random.Shared.Next(1, 10); // find a better way to generate room id
        }

        return RoomConfig.EntranceId;
    }

    public int GetRow()
    {
        return PosX;
    }

    public List<int> GetLoadGroupList()
    {
        var groupList = new List<int>();
        groupList.AddRange(RoomConfig!.DefaultLoadBasicGroup);
        groupList.AddRange(RoomConfig.DefaultLoadGroup);
        groupList.AddRange(RoomConfig.SubMonsterGroup);

        return groupList;
    }

    public ChessRogueCell ToProto()
    {
        var info = new ChessRogueCell
        {
            CellStatus = CellStatus,
            PosY = (uint)PosY,
            Id = (uint)GetCellId(),
            CellType = (uint)CellType,
            IsUnlock = true,
            RoomId = (uint)RoomId,
            JEHEAOINGMP = true,
            PosX = (uint)GetRow()
        };

        if (CellAdvanceInfo.Count > 0)
        {
            info.PlayerInfo = new CellAdvanceInfo
            {
                BossInfo = new CellMonsterInfo
                {
                    MonsterList = { CellAdvanceInfo.Select(x => x.ToProto()).ToList() },
                    SelectBossId = (uint)SelectMonsterId
                }
            };

            if (SelectedDecayId.Count > 0)
                info.PlayerInfo.SelectBossInfo = new CellMonsterSelectInfo
                {
                    SelectDecayId = { SelectedDecayId.Select(x => (uint)x).ToList() }
                };
        }

        return info;
    }

    public ChessRogueHistoryCellInfo ToHistoryProto()
    {
        var info = new ChessRogueHistoryCellInfo
        {
            RoomId = (uint)RoomId,
            CellId = (uint)GetCellId()
        };

        return info;
    }
}

public class ChessRogueCellAdvanceInfo
{
    public int BossDecayId { get; set; }
    public int MonsterId { get; set; }

    public CellMonster ToProto()
    {
        return new CellMonster
        {
            BossDecayId = (uint)BossDecayId,
            MonsterId = (uint)MonsterId
        };
    }
}