namespace BossNotes.ARR.Dungeons.StoneVigilBosses
{
    public class Koshchei : Boss
    {
        public Koshchei()
        {
            Name = "Koshchei";
            QuickStrategy = @"Use cannons to kill adds";
            InDepthStrategy = @"Koshchei is the 2nd dragon boss of The Stone Vigil. In this fight there are 3 cannons positioned at the far side of the boss' room. Throughout the fight, Koshchei will summon dragon adds outside of the castle to help him. Use the cannons to defeat the adds when they spawn.

Koshchei will use the ability Typhoon to spawn whirlwinds. As the fight escalate, multiple whirlwinds appear at once. Players caught within the whirlwinds will take damage and receive a DoT debuff.

Use the cannons to defeat the adds.
Abilities

Collapse is an instant ability that damages all targets in front of it.
Spiked Tail is an ability that Inflicts the debuff Poison on it's target.
Typhoon is a tornado that slowly moves towards a random party member. Targets hit by the spell takes a small amount of damage and receives the debuff Windburn.
Blazing Trail is a frontal cone AoE attack that moderately damages any targets hit.";
        }
    }
}