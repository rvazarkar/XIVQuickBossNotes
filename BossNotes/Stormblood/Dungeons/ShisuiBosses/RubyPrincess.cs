namespace BossNotes.Stormblood.Dungeons.ShisuiBosses
{
    public class RubyPrincess : Boss
    {
        public RubyPrincess()
        {
            Name = "Ruby Princess";
            QuickStrategy =
                "Grab a box on the outside of the arena when boss casts seduce. Abyssal volcano has multiple hits, so keep dodging.";
            InDepthStrategy =
                @"The boss will periodically enter the center of the room and begin to cast Seduce, which will cause everyone hit by it to slowly walk toward the boss. Immediately after Seduce, the boss will perform Coriolis Kick, a large circular AoE, which Seduced players will be hit by.
To avoid being hit by Seduce, each player must run into one of the four boxes around the outside of the arena, which will place the Old debuff on that player. Once touched, the box will be used up until the next Seduce phase, and while one box can affect multiple players, the timing is too precise to be practical. So, each player should pick a box and only use that box, and avoid running into it except to avoid the Seduce effect.
The boss will periodically cast Abyssal Volcano, which places a large circular AoE as well as marking two players with an AoE which will track them. Affected players should repeatedly run out of this effect, avoiding touching the boxes.
The boss periodically casts Tornadogenesis on its primary target, which deals a moderate amount of damage, Cooldown and heal as necessary.";
        }
    }
}