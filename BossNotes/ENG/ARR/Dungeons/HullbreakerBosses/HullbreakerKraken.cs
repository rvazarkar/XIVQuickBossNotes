namespace BossNotes.ARR.Dungeons.HullbreakerBosses
{
    public class HullbreakerKraken : Boss
    {
        public HullbreakerKraken()
        {
            Name = "Kraken";
            QuickStrategy = @"When you get a marker, go to another platform and drop it there.";
            InDepthStrategy =
                @"In the Kraken fight, players will kill 10 of its arms, two per platform. The boss room is divided into various platforms. Players need to use the water sprouts around the platforms to move to among them. Every now and then players will get a green pulsating icon over their heads. This indicates that a tornado is about to spawn on top of you. The player with the green icon should move to another platform immediately, then move back to the previous platform when the tornado drops, because the tornadoes act as time bombs. They will do enormous amounts of damage after a short time. Note that every time you jump you get a stacking debuff that increases the damage you will take.

When a green icon appears over a players head, said player need to jump to a different platform, wait for the tornado to drop, then jump back.";
        }
    }
}