namespace BossNotes.ARR.Dungeons.HHaukkeBosses
{
    public class Halicarnassus : Boss
    {
        public Halicarnassus()
        {
            Name = "Halicarnassus";
            QuickStrategy =
                @"This is a DPS race. Adds need to be killed ASAP. The more health they have, the more damage the boss will do.";
            InDepthStrategy = @"Adds

Manor Sentry — When absorbed, Halicarnassus will gain immunity to stun/silence.
Manor Handmaidens x2 — When absorbed, she will gain a Determination buff (increased damage).
Lady Amandine — Normal-mode Haukke Manor boss.
After a short amount of time, she will cast a spell to absorb the add. Once the add is absorbed, she will cast the unavoidable spell Blood Rain. The more health the add had when absorbed, the more damage Blood Rain will do. This can be deadly, so each wave of adds is a DPS race. None of the adds can be killed completely and should be ignored at 0%.

When she spawns the two Handmaidens, it's best to bring one down to zero health and then concentrate on the other. When one reaches zero HP, she will absorb it immediately. If you don't get one of the Handmaidens down to zero health before she casts the absorb spell, she will choose one at random. If she chooses the Handmaiden with full health, it will wipe the group, so make sure to get one of the Handmaidens down to zero health before she absorbs one.

The final add is Lady Amandine, the final boss from normal-mode Haukke Manor. Using a dps limit break on her is strongly recommended, otherwise it is unlikely that enough damage will be dealt to her in time to make Blood Rain survivable.

Once the final add is dead, the tank should drag the boss to the center of the room. At about 15% HP, she will use Beguiling Mist. While she casts this spell, it will send out a red pulse. As soon as you see this pulse, run to your chosen corner. When the spell hits, all players will be forced to walk slowly toward the boss. She will target one player with Void Fire IV; as you've spread out to the four corners, this will only hit a single player and will be easy to heal through. This will repeat three times. If you haven't killed her after the third Beguiling Mist, she will absorb a random party member and the resulting Blood Rain will wipe the group. This DPS race is much easier than the add waves, but make sure to kill her before the third Beguiling Mist.";
        }
    }
}