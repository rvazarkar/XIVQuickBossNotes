namespace BossNotes.ARR.Dungeons.HStoneVigilBosses
{
    public class Giruveganaus : Boss
    {
        public Giruveganaus()
        {
            Name = "Giruveganaus";
            QuickStrategy = @"Boss ignores aggro. Boss has tells but not ground markers.
Tail Lift = read attack. Rear up = front attack. Drop shoulder = charge.
Kill original first when clone spawns.";
            InDepthStrategy = @"Giruveganaus is a fairly straightforward, if annoying, fight. The boss follows a random attack pattern, ignoring all hate generation. All players must keep an eye out for one of Giruvenganaus' many tells in order to anticipate and dodge attacks. All of the boss's attacks not only hit for moderate to high damage, but also bestow a debuff on anyone hit called Infirmity, which reduces healing from magical sources.

Phase 1 consists of 3 attacks. His first, a burning shoulder tackle, is telegraphed by the boss lowering his shoulder. After about a second, he will charge forward damaging all in his path. His next attack is a tail swipe, a rear cone attack preceded by the boss pausing and raising his tail. The final attack of this phase is a frontal cleave attack, in which the boss stops and rears up on his hind legs and swings at anyone in front of him. It is highly recommended to stay to the flank of the boss, as this puts you in a ""safe zone"" between the range of his frontal cleave and tail swipe. At approx 60% health, phase 2 will begin.

At the start of phase 2, Giruvenganaus will summon a clone of himself with all the same attacks and stats as the original at full health. He will also gain a new attack which is shared with his clone, where he will turn to face a random player and launch a fireball, which will damage the target and anyone in a close proximity. The tell for this is a small flame that will appear in the boss's mouth as it turns to its target. In this phase it is best to ignore the clone in favor of bursting down the original boss, dodging attacks when necessary. Once the original is dead, focus attacking the clone, who should follow soon afterward.";
        }
    }
}