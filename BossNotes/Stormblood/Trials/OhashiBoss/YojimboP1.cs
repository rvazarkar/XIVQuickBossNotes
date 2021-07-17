namespace BossNotes.Stormblood.Trials.OhashiBoss
{
    public class YojimboP1 : Boss
    {
        public YojimboP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"Butterflies will eventually explode with large AoEs.";
            InDepthStrategy = @"Wakizashi: Tankbuster that hits an arc around the target.
Inoshikacho: Four butterflies will slowly float to random spots in the arena, exploding into large AoEs shortly after touching the ground.
Metta-giri: Moderate party-wide damage.";
        }
    }
}