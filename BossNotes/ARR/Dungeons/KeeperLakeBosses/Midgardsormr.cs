namespace BossNotes.ARR.Dungeons.KeeperLakeBosses
{
    public class Midgardsormr : Boss
    {
        public Midgardsormr()
        {
            Name = "Midgardsormr";
            QuickStrategy = @"Boss is invuln while adds are up. Adds have breath attacks, so stay behind them.
First add needs to be tanked away from boss. Second needs to be tanked near boss.
Shield generator add needs to be killed as fast as possible.";
            InDepthStrategy = @"The boss itself is the big dragon head that does not need to be tanked. He does a couple of different AoE attacks. He will revive one of the two dragons at the time. Party should focus on killing these dragons as Midgardsormr is invulnerable during that time. These dragons also have their own AoE attacks as well as breath attacks so DPS should be mindful not to stand in front of the dragons. The first dragon that spawns has to be tanked far away from Midgardsomr, while the second dragon has to be tanked close to Midgardsomr. After the first dragon is revived, Midgardsormr will begin using a new AoE attack that alternates between approximately half of the room closest to Midgarsormr and later the further half. Tanks should try to position the dragons on either the east or west point of the room to make dodging these attacks easier. At some point an add will spawn who carries a shield-generator, this add will look similar to the dragons which drop the cannisters in the Einhander fight. DPS should focus these instantly, since the Midgardsormr will charge up an insta-kill AoE at that time. The Shield generator needs to be interacted with in order for the shield to become available and all members of the party must be inside the bubble to avoid being instantly killed. Repeat with the second dragon and second shield-generator. In this second phase however, Midgarsormr gains a new AoE ability which begins as a small circle which will expand outward two times, taking up a large portion of the room. Each time a dragon is killed, Midgarsormr will lose around 45% of his health. After both dragons are killed, quickly DPS any of his remaining health.";
        }
    }
}