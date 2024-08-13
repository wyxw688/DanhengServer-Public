﻿namespace EggLink.DanhengServer.Data.Config;

public class MonsterInfo : PositionInfo
{
    public int NPCMonsterID { get; set; }
    public int EventID { get; set; }
    public int FarmElementID { get; set; }
    public bool IsClientOnly { get; set; }
}