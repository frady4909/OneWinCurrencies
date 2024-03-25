using FFXIVClientStructs.FFXIV.Client.Game;

namespace OneWinCurrencies.Trackers;

public class Tomestones : ITrackers
{
    public uint PoeticTomeStoneCount { get; private set; }
    public uint SpecialTomeStoneCount1 { get; private set; }
    public uint SpecialTomeStoneCount2 { get; private set; }
    public int SpecialTomeStoneWeeklyCount { get; private set; }

    public void Initialize()
    {
        SetAllTomestones();
    }

    public void Update()
    {
        SetAllTomestones();
    }

    private unsafe void SetAllTomestones()
    {
        var inventoryInstance = InventoryManager.Instance();

        PoeticTomeStoneCount = inventoryInstance->GetTomestoneCount(1);
        SpecialTomeStoneCount1 = inventoryInstance->GetTomestoneCount(2);
        SpecialTomeStoneCount2 = inventoryInstance->GetTomestoneCount(3);
        SpecialTomeStoneWeeklyCount = inventoryInstance->GetWeeklyAcquiredTomestoneCount();
    }
}
