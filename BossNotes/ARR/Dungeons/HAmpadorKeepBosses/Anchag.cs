namespace BossNotes.ARR.Dungeons.HAmpadorKeepBosses
{
    public class Anchag : Boss
    {
        public Anchag()
        {
            Name = "Anchag";
            QuickStrategy = @"Tank the boss in the middle of the room. Stand behind a statue when you get a marker.
Stand slightly away from statues to avoid damaging them.";
            InDepthStrategy = @"The key components of this fight are the four statues in the room. When a red marker appears above your head, run behind a statue immediately. If you do not, he will spawn a tether that deals massive DoT and applies a debuff. Most characters, even tanks, will be killed if they take full damage from this attack. The statue will absorb the damage so long as you are hiding behind it.

Anchag should be tanked in the middle of the room, or at least away from these statues. He will do several AoEs that can destroy the statues prematurely, which you do not want. Similarly, ranged DPS and healers should remain near, but not too near the statues. He will target certain players at random for an AoE, and you do not want a statue to be caught up in that attack by proximity. Standing directly between two statues should be safe.

If he targets you for a rush attack, in which he charges at you and knocks you back (it will be a long, rectangular telegraph), stay away from the statues, as this attack will immediately destroy them. Instead, move closer to the boss, which reduces the damage dealt. Other players should avoid the telegraphed area.";
        }
    }
}