namespace BossNotes.ARR.AllianceRaids.SyrcusTowerBosses
{
    public class Scylla : Boss
    {
        public Scylla()
        {
            Name = "Scylla";
            QuickStrategy = @"Run purple balls to lightning pillars, and fire balls to frozen people.
Stand in puddles when boss casts ""Ancient Flare""";
            InDepthStrategy = @"Elemental balls - Random DPS and healers will be marked to be followed by balls of elemental energy. Lightning balls appear purple, ice balls appear blue, and flame balls appear red. You will have to deal with this mechanic throughout the fight.

Lightning ball - Neutralized by the lightning pillar. Running them into the lightning pillar energizes the pillar, which is denoted by panels of light on the ground next to the pillar. Three charges are needed and will produce a red marker indicating that the pillar is fully charged. Lightning balls detonate for heavy raid wide damage after about 15 seconds if not run into a pillar.

Ice ball - Trails a target and will freeze that target after a set duration of time. This is unavoidable and cannot be stopped. What you can and should do is make sure that you are not standing in one of the puddles left behind when a frozen target is thawed, as everyone in the vicinity of the puddle will be frozen as well, an important consideration for melee. Thaws after 30 seconds.

Flame ball - will chase a target and detonate after about 15 seconds. Can be used to thaw frozen targets, and you should. Thawing a frozen target leaves behind a patch of water on the ground which confers very high fire resistance, but will spread the freeze effect of an ice ball if it detonates inside the puddle.";
        }
    }
}