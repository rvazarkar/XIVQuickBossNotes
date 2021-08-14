namespace BossNotes.Stormblood.Dungeons.HellsLidBosses
{
    public class Genbu : Boss
    {
        public Genbu()
        {
            Name = "Genbu";
            QuickStrategy = @"Move away when marked, avoid blue balls by looking at arrows.";
            InDepthStrategy = @"Caduceus: No castbar. Tankbuster.
Hell of Water: Cross-like AoE, centered on Genbu.
Hell of Waste: Marker on player, AoE around player, drops water bomb on player. Stay away from group. Moderate damage.
Sinister Tide: Genbu jumps in the air, upon landing greenish light. Arrows appear on the hexagonal platforms, along with a blue orb. The orb will explode and send water following the arrows. Stand on a platform that is not in the water's path. Getting hit will result in moderate damage and 1 stack of Vulnerability Up.
Hell of Waves: Genbu becomes invincible and begins charging his Genbu's Focus meter. Destroy the Chelonian Gate around him before the meter fills completely. During this time platforms will start to glow and damage anyone standing on them, so move off of them quickly.
Divine Cataract: Ultimate, after Genbu's Focus meter fills or Chelonian Gate is destroyed. The amount of damage done depends on how full the meter was.";
        }
    }
}