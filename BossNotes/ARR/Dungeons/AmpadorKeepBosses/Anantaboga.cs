namespace BossNotes.ARR.Dungeons.AmpadorBosses
{
    public class Anantaboga : Boss
    {
        public Anantaboga()
        {
            Name = "Anantaboga";
            QuickStrategy = @"Non tank's should be at the side of the boss.
Hide behind statues when orbs spawn, and kill the statue that wakes up.
Move away from statues/players when you get ""Plague Dance""";
            InDepthStrategy =
                @"Anantaboga is the final boss of Amdapor Keep. Non-tank players should be Flanking the boss to avoid its Rotten Breath (front conal AOE) and Tail Drive (rear conal AOE). Rotten Breath will apply the debuff disease to all targets hit. Disease will reduce all healing done to the target. White Mages should remove disease with Esuna if possible.

Throughout the fight Anantaboga will use Imminent Catastrophe to spawn purplish, red orbs in the center of the boss room. The orbs will do damage to all players in its line of sight. Be sure to hide behind the statues around the room to avoid the damage. Additionally, the ability will awake one of the statues. Avoid the statue's circular AoE attack and burst it down.

Later in the fight Anantaboga will use Plague Dance on random players. Players with the debuff should move away from statues and other players so the red orbs will not damage any other players. The red orbs disappear when Anantaboga uses Imminent Catastrophe.

Abilities

Look is an instant attack that deals a small amount of damage to the target with the most enmity.
Tail Drive is a rear cone AoE attack that deals high amount of damage and inflicts a DoT named Concussion to all players hit. Anantaboga will only use this ability when one or more players are behind it.
Rotten Breath is a frontal AoE attack which deals heavy damage and inflicts the debuff Disease to all players hit.
Imminent Catastrophe is a giant purplish, red orb that appears in the middle of the room. It deals heavy damage to all players in the line of sight.
Plague Dance is a purple beam that targets a random player. after a few seconds, a small red orb appears at the location and deals damage to all players nearby.
Adds

Dark Helot has an ability named Terror Eye that places a circular AoE under a random player. It deals heavy damage to all players caught within.";
        }
    }
}