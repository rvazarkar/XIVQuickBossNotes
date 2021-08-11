namespace BossNotes.ARR.AllianceRaids.WorldOfDarknessBosses
{
    public class AngraMainyu : Boss
    {
        public AngraMainyu()
        {
            Name = "Angra Mainyu";
            QuickStrategy = @"Alternate standing in Red/White areas.
Kill hourglasses and don't stand in AoEs. Look away for ""Mortal Gaze"".
Run away from tethers.";
            InDepthStrategy = @"Double Vision, a floor-covering AoE that is split into red and white, which gives a stacking debuff depending on what colour you're standing on. The white AOE will give a ""Sullen"" debuff and the red AOE will give an ""Ireful"" debuff. The stacks will reset to 1 if you alternate which colour you stand on when it hits. If you get 2 stacks of the debuff you will take 2.5k damage. If you get 3 stacks you will die.

When he casts Mortal Gaze, anyone looking in his direction will receive a Doom debuff that kills you in 10 seconds. Stand on 1 of 4 circular platforms that is lit up to remove this debuff. You can also turn away from the boss when he casts the ability to completely avoid the Doom debuff.

Roulette, signified by a finger and a cone that rotates clockwise around the boss room, occurs when 4 Final Hourglass spawn at the outer edge of the room. Kill the 4 Final Hourglass one by one. To avoid being killed, do not stand in the quarter that is lit up when the last Final Hourglass dies. As long as all four of the Hourglasses die, you will be able to run out of that section if you happen to be in it.

Level 100 Flare: Red ball spawns on a player and a red circle appears on the ground. This ability tethers several players to 1 player. You need to run out of the circle to cancel the ability. Players in the red circle will all take massive damage if the total number of players in the circle is an even number.

Level 150 Doom: Purple ball spawns on a player and a purple circle appears on the ground. This ability tethers several players to 1 player. You need to run out of the circle to cancel the ability. Players in the purple circle will all die if the total number of players in the circle is a multiple of 3.

Adds should be killed or they will deal powerful raidwide damage.";
        }
    }
}