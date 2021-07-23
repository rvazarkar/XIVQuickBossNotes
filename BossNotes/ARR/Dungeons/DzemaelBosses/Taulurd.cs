namespace BossNotes.ARR.Dungeons.DzemaelBosses
{
    public class Taulurd : Boss
    {
        public Taulurd()
        {
            Name = "Taulurd";
            QuickStrategy = @"Spread out and avoid AoE.";
            InDepthStrategy = @"Taulurd is the 2nd boss of Dzemael Darkhold. He has some powerful AoE cone attacks that should be avoided by all players.

Throughout the fight he will summon adds named Deepvoid Slaves. These monsters are on top of an elevated platform. They will perform ranged attacks at the players. Be sure to spread out and avoid their Firewater attacks.

Adds

Deepvoid Slave has two types of attacks, Firewater and Boulderdash. Firewater is a circular AoE attack that targets one random player. Firewater can be avoided by moving out of the red circular ground indicator.
Abilities

Straight Punch is an instant melee attack that deals a small amount of damage.
Double Smash is a frontal AoE cone attack that deals a large amount of damage to targets hit.
Elbow Drop is a frontal AoE cone attack that deals more damage than Double Smash. Taulurd starts to use this when it is under half HP.";
        }
    }
}