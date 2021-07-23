namespace BossNotes.ARR.Dungeons.CuttersCryBosses
{
    public class GiantTunnelWorm : Boss
    {
        public GiantTunnelWorm()
        {
            Name = "Giant Tunnel Worm";
            QuickStrategy = @"When the worm submerges, spread out. ""Sludge"" should be cleansed ASAP.";
            InDepthStrategy = @"Giant Tunnel Worm is the humongous worm boss of Cutter's Cry. Throughout the fight, Giant Tunnel Worm will submerge underneath the sandy grounds of the boss room. The Worm is the most dangerous when it is submerged. The worm's main abilities include:

Sandstorm is an instant frontal attack that deals a small amount of damage.
Sand Cyclone is a spell that targets a random party member. It does a small amount of damage and inflicts a damage over time debuff.
Sand Pillar is an ability used by the Worm when it is burrowed. Sand Pillar damages any player standing on top of the sand trap.
Earthbreak is an ability used by the Worm when it is burrowed. Tunnel Worm explodes out of the ground and heavily damages anyone near it.
Bottomless Desert is an ability used by the Worm when it is burrowed. It appears as a whirlwind on the ground, does small amount of damage and pulls all party members towards its center.
Sludge is a single-target ability used by the Worm. It inflicts a heavy DoT (~200 HP per tick) on a player which should be removed as soon as possible. Target priority does not seem to factor in who gets attacked.
Spreading out when the worm submerges reduces the chance that multiple party members will be hit when it emerges from the sand. It is important that after it does the Bottomless desert that adventurers move out of the center to not get hit when the worm emerges.";
        }
    }
}