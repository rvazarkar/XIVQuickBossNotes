namespace BossNotes.Stormblood.Dungeons.DrownedCityBosses
{
    public class Kelpie : Boss
    {
        public Kelpie()
        {
            Name = "Kelpie";
            QuickStrategy =
                @"Move to boss for ""Hydro Push"" and away for ""Hydro Pull"". Spread out for Bloody Puddle.";
            InDepthStrategy = @"Torpedo Moderate tank damage.
Rising Seas Group AoE.
Hydra Pull Move away from Kelpie to avoid outer edge damage.
Hydra Push Move to Kelpie to avoid outer edge damage.
Bloody Puddle Target players for AoE and tethered orbs. Spread puddles to avoid damage and debuffs and kite orbs away.
Flash outside platform will damage and debuff any player standing in it.";
        }
    }
}