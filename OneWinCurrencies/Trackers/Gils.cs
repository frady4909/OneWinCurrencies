using FFXIVClientStructs.FFXIV.Client.Game;

namespace OneWinCurrencies.Trackers;

public class Gils : ITrackers
{
    public uint InventoryGils { get; private set; }

    public void Initialize()
    {
        SetAllGils();
    }

    public void Update()
    {
        SetAllGils();
    }

    private unsafe void SetAllGils()
    {
        var inventoryInstance = InventoryManager.Instance();

        InventoryGils = inventoryInstance->GetGil();
    }
}
