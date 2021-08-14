namespace BossNotes.ARR.AllianceRaids.LabyrinthBosses
{
    public class Phlegethon : Boss
    {
        public Phlegethon()
        {
            Name = "Phlegethon";
            QuickStrategy = @"Tank the boss between the middle and B. 
When boss moves to the middle, immediately run to your platform!
Kill all adds.";
            InDepthStrategy =
                @"Phlegethon is the final boss of Labyrinth of the Ancients. The boss room is unlocked from defeating the other 3 bosses.

Phlegethon has only 1 big move to watch out for: Ancient Flare. Each group should take a position ahead of time (A on the left, B center, C on the right). At around 40-50% HP, Phlegethon will move to the center and start casting Ancient Flare. Each group needs to immediately move to its assigned platform. Doing this will put up a barrier to block his 'Ancient Flare' attack, which is otherwise a wipe. At around 5-15% HP, he will do this again; run back to the platform to repeat the mechanic or burn him down (do so if he starts the cast with < 6% HP).

During the fight adds will spawn, and should be killed. Iron Hand adds stun a nearby target.

Have each group stand on one of the circles the adds spawned from to block Ancient Flare.";
        }
    }
}