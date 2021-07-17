namespace BossNotes.Stormblood.Dungeons.SwallowsCompassBosses
{
    public class Daidarabotchi : Boss
    {
        public Daidarabotchi()
        {
            Name = "Daidarabotchi";
            QuickStrategy = @"Stand to the side of the boss when it raises its hand.";
            InDepthStrategy = @"The abilities do not have a castbar. Watch for the messages on screen.

Daidarabotchi is gathering aetherial energy...: Daidarabotchi will raise one of its arms and slam it down on the ground. Getting hit by this will result in medium damage and one (1) debuff stack of Vulnerability Up. It is suggested to stand on its other side.
The Land take You, Claim You!: AOE that will follow the marked player.
Swallow You, Consume You!: Daidarabotchi will hit the ground with its fist and create a circular, persistent AOE (a shimmering lake) around the centre of the area. That lake will grow over time and will cover ca. 75% of the area but will disappear again after some time.
Mountain Falls : Blue AOE with a blue water drop on top around a player. Will deal damage after a short while.";
        }
    }
}