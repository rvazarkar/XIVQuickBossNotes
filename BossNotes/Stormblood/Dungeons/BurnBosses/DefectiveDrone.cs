namespace BossNotes.Stormblood.Dungeons.BurnBosses
{
    public class DefectiveDrone : Boss
    {
        public DefectiveDrone()
        {
            Name = "Defective Drone";
            QuickStrategy = @"Safe zone for ""Full Throttle"" is in front of the broken zone. Avoid the edges of the arena.";
            InDepthStrategy = @"The Defective Drone's arena is smaller than most, and the left and right sides of the arena are constantly burning, inflicting Burns for as long as the player stands in it. Additionally, take note of the ""lanes"" the arena is separated into.

Aetherochemical Flame: High party-wide damage. Mitigate and heal through this.
Aetherochemical Coil: Tankbuster that hits an arc in front of the boss.
Prior to the next move, the Defective Drone will launch a glob of sludge towards a random player that inflicts Leaden while inside of it.
Full Throttle: The Defective Drone moves out of the arena, showing up with five smaller Mining Drones on one of the sides. Determine which of the smaller drones is sparking and does not have lights above it, and move into its lane. Getting run over by the drones inflicts massive damage and knockback guaranteed to push you into the fire.
Rock Busters: Summons Rock Busters on the sides of the arena that launch across in a straight line after a short time. Simply don't stand in front of them.
After a while, the boss summons a Repurposed Dreadnaught that has the standard Dreadnaught attacks.";
        }
    }
}