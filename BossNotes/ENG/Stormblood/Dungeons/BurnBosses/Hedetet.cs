namespace BossNotes.Stormblood.Dungeons.BurnBosses
{
    public class Hedetet : Boss
    {
        public Hedetet()
        {
            Name = "Hedetet";
            QuickStrategy = @"Stand behind crystals to avoid ""Hailfire"" and ""Shardfall"".
Stand inside boss hitbox to avoid ""Dissonance"" which is always after ""Shardfall""";
            InDepthStrategy =
                @"Take note of the four white crystals jutting from the ground, as these serve as shields for some of the boss's attacks. Be warned that the crystals explode after being hit by one of Hedetet's attacks. New crystals fall from the ceiling, but be prepared to move out of their way.

Crystal Needle: Tankbuster.
Hailfire: Places a crosshair on a random target. After a short delay, Hedetet blasts sand at the targeted player, damaging the first thing it hits. Standing behind a crystal blocks all damage.
All subsequent casts of Hailfire begin with Hedetet jumping to a random spot in the arena before targeting a player.
Shardfall: Arena-wide area of effect. Stand behind a crystal to protect yourself. Hedetet casts Dissonance immediately after this attack.
Dissonance: Another arena-wide area of effect. This time the safe zone is inside Hedetet's hitbox. Deals high damage and inflicts Vulnerability Up if it connects.
Shardstrike: Places an AoE marker on all players. Spread out to avoid damage overlap, but also position as to not hit any of the crystals.";
        }
    }
}