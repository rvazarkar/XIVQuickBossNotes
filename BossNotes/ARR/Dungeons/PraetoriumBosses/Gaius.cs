namespace BossNotes.ARR.Dungeons.PraetoriumBosses
{
    public class Gaius : Boss
    {
        public Gaius()
        {
            Name = "Gaius van Baelsar";
            QuickStrategy = @"Tank and SPANK";
            InDepthStrategy = @"Players should spread out to avoid Gaius' Hand of the Empire. Non-tank players should not be in front of the boss. At 3/4, 1/2 and 1/4 HP, flaming blue circles will appear on the ground. Players should move and stay out of the circles because they do damage to anyone in them. Players should also avoid his Blue X ability called Terminus Est. When the flaming blue X appears, move out of its way.

Abilities

Innocence is an instant frontal cleave attack that deals a moderate amount of damage to all players hit.
Sentence is an instant attack that knocks back a random player.
Heirsbane is an instant attack that deals a moderate amount of damage to a random player.
Hand of the Empire is an instant attack that unleashes a blue ball of flame at a random player. That player and all players around will take small amount of damage.
Terminus Est is a blue, flaming X that appears. After a few seconds, a blast comes from the X dealing heavy amount of damage to all players in its path.
Judgment stuns a random player and spawns a circular AoE ground indicator around him or her. After a few seconds all players within the ground indicator will take moderate amount of damage.";
        }
    }
}