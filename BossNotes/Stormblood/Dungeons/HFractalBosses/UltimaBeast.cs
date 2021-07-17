namespace BossNotes.Stormblood.Dungeons.HFractalBosses
{
    public class UltimaBeast : Boss
    {
        public UltimaBeast()
        {
            Name = "The Ultima Beast";
            QuickStrategy =
                @"Raised arm = run away, stand up = move to boss. Spread for purple markers. Spread for ""Allagan Flare""";
            InDepthStrategy = @"Death Spin: Hits anyone in Melee Range - Keep Clear.
Aether Bend: Hits anyone not inside his Hitbox - Stand on Boss.
Flare Star: Drops Fire Puddles - Proximity Based Damage.
Allagan Gravity: Spread out from others and move away from gravity puddles after.
Light Pillar: Expanding AoE from center - Dodge as it moves across platform.
Forborn Beast: Adds Damage Up buffs on Boss.
Allagen Flare: Targets Tank - Move away to reduce damage.
Enrage: Slow Demi Ulta - Boss must be killed before cast goes off";
        }
    }
}