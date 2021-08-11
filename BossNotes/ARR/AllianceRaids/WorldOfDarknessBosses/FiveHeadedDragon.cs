namespace BossNotes.ARR.AllianceRaids.WorldOfDarknessBosses
{
    public class FiveHeadedDragon : Boss
    {
        public FiveHeadedDragon()
        {
            Name = "Five-headed Dragon";
            QuickStrategy = @"Kill slimes ASAP and stand in puddles to stop more spawns.
Stack together for purple marker. Pass dragonfly tethers around.
Kill prominence orbs ASAP.";
            InDepthStrategy = @"Ice Floor's AoE expands if it hits a player. When you see a white, circular swirl on the ground, run away.

The poison Slimes need to be killed to stop them from joining together and casting silence on the entire raid. Killing them causes them to burst into poison resistance buffs. Wherever the slimes spawn, there will be a puddle of slime left over. At least one player needs to stand in the puddle to prevent more slimes from spawning and turning into a Toxic Slime.

When the boss channels Discordance you have to kill the 5 extra heads that appear or the raid will wipe. The boss could use this multiple times, so stay on your toes if your DPS is slower.

The boss will occasionally mark a player with a white, curved ball. When this happens, a small number of players (usually 3-5) need to stack on this player to split the damage. If this does not happen, the player will receive 9999 damage.

When you see Prominence, red circles spawn on the ground followed by red or white balls, kill the balls ASAP before they explode and deal damage.

Red Bird Tether attaches to a player and inflicts a debuff, the player needs to run and touch another player before the debuff kills them.

Heatwave is a raid-wide attack used when the boss' HP is low. For 5 seconds, every action you make will deal 500 damage.";
        }
    }
}