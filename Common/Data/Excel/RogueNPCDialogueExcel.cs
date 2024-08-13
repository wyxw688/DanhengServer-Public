﻿using EggLink.DanhengServer.Data.Config;
using Newtonsoft.Json;

namespace EggLink.DanhengServer.Data.Excel;

[ResourceEntity("RogueNPCDialogue.json")]
public class RogueNPCDialogueExcel : ExcelResource
{
    public int RogueNPCID { get; set; }
    public int DialogueProgress { get; set; }
    public int HandbookEventID { get; set; }
    public string DialoguePath { get; set; } = "";

    [JsonIgnore] public DialogueInfo? DialogueInfo { get; set; }

    public override int GetId()
    {
        return RogueNPCID * 100 + DialogueProgress;
    }

    public override void Loaded()
    {
        GameData.RogueNPCDialogueData.Add(GetId(), this);
    }

    public bool CanUseInVer(int version)
    {
        GameData.RogueHandBookEventData.TryGetValue(HandbookEventID, out var handbookEvent);
        return DialogueInfo != null && handbookEvent != null && handbookEvent.EventTypeList.Contains(version);
    }
}