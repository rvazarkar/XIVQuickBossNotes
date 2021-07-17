namespace BossNotes.Stormblood.Trials.FluminisBoss
{
    public class TsukuyomiP2 : Boss
    {
        public TsukuyomiP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Kill adds as fast as possible.";
            InDepthStrategy = @"Starts with Nightbloom - raid-wide damage and stun.

Adds will spawn during this phase. Destroy the adds as soon as they come up.

Duty Gauge - Suffering - During phase 2, the Suffering gauge will fill up over time. Destroy the adds as soon as possible as the longer the phase goes on, the more suffering is accumulated, which deals more damage at the end of the phase. Naturally, if the gauge hits 100%, it will wipe the group. Shield/heal as necessary.";
        }
    }
}