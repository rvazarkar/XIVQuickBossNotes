namespace BossNotes.ARR.AllianceRaids.SyrcusTowerBosses
{
    public class Xande : Boss
    {
        public Xande()
        {
            Name = "Xande";
            QuickStrategy = @"One person per small yellow circle. 
Bring black circles into melee range (don't overlap!)
Stand in glowy circles when boss casts ""Ancient Quagga""";
            InDepthStrategy =
                @"Xande should be tanked in the center of the arena. He has the standard ""don't stand in this"" mechanics, including a targeted AoE which deals about 2k damage. While not dangerous, a DPS can potentially be one-shotted if two are overlapping each other and the DPS is still standing in them. He also has The People's Elbow, which is centered on him, and deals moderate damage with a severe knockback. Melee must watch out for this.

Aetherochemical Explosion - Every now and then Xande creates golden orbs with a small golden radius around them. You have about 10-15 seconds before they detonate, so the raid should be fairly well spread in anticipation of this. They explode and deal about 500 damage per explosion if not neutralized, and since he spawns about a dozen at a time, this is a good way to lose a chunk of your raid if nobody is paying attention. To stop the explosion, simply have a person stand within the golden radius. This causes the orb to hit that person for about 50 damage upon detonation, rather than blasting the entire raid for ten times that damage.

At 70%, Xande teleports out of the arena and lounges on his throne while calling down meteors on your raid Sephiroth-style. This is the first intermission. 3 Attractors will appear on the edge of the arena. They must be killed quickly to prevent meteorfall. Additionally a giant attractor appears in the center. The entire raid should this one together once the three attractors on the fringes have been destroyed. If the small meteors land they cause heavy raid wide damage, if the big one lands it is a wipe. In short, handle this mechanic like the trash in Labyrinth leading up to King Behemoth.

Once Xande reappears, phase 2 begins. He now has a new ability where one person from each group gains an ominous black aura around them. This thing expires after about 15 seconds and deals close to 10k damage, split evenly amongst everyone standing in it, so each group should stack up close to Xande but without overlapping to soak. A null gravity zone is left behind upon detonation which lets you float. This is important because ...

Immediately after detonation, Xande will cast Ancient Quaga. The ability deals more than 5k damage to everyone in the raid. Ancient Quaga is nullified by floating. When Xande casts Ancient Quaga, everyone should move into a null gravity zone.

Xande retains golden orbs in this phase.";
        }
    }
}