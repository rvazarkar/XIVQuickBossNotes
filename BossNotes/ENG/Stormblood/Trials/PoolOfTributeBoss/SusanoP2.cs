namespace BossNotes.Stormblood.Trials.PoolOfTributeBoss
{
    public class SusanoP2 : Boss
    {
        public SusanoP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Main tank should pick up flower crystal. Off-tank should soak orbs.";
            InDepthStrategy =
                @"At the beginning of Phase 2, a flower-shaped crystal will appear on the platform. The Main Tank should pick this up as the player who picks it up will be the one receiving continuous damage from Susano during this phase.

Clash - The player that picked up the flower-shaped crystal will be locked in a clash with Susano, receiving a damaging debuff for as long as Ame-no-Murakumo is alive.

Ame-no-Murakumo - While clashing, Susano will begin casting this ability. Successful casting will cause a wipe. The party should focus damage on the sword to interrupt this cast.

Sheer Force - During the clash, orbs will spawn on the perimeter of the platform. The Off-tank should run into these orbs before they get to the party, as they do splash damage.

This ends in heavy, unavoidable damage (a wipe if Ame-no-Murakumo is not destroyed), marked by a large, red line AoE across the platform.";
        }
    }
}