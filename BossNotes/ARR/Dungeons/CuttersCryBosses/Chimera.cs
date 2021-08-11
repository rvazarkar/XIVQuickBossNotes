namespace BossNotes.ARR.Dungeons.CuttersCryBosses
{
    public class Chimera : Boss
    {
        public Chimera()
        {
            Name = "Chimera";
            QuickStrategy = @"Violet = close, Blue = away. Move away from purple energy balls.";
            InDepthStrategy =
                @"The final boss of Cutter's Cry, the Chimera requires close attention to know where to step. The Chimera has a Frontal Cone called Lion's Breath that deals a moderate amount of fire damage. Occasionally the Chimera will use the abilities Ram's Breath and Dragon's Breath. Ram's Breath causes Ice damage and heavy on the right side of its body and Dragon's Breath causes Thunder damage and paralysis on the left side of its body. Melee DPS can stand directly behind the Chimera to avoid these cones, but the tank will have to move left or right to sidestep their effects. Most of Chimera's attacks will paralyze its target, which can be cleansed with Esuna, but Adventurers with low hit points should be extra careful.

At 75% of its life, the Chimera will begin to use two attacks called Dragon's Voice and Ram's Voice. When players see one of the two messages below in the chat log, they need to either move closer to the boss or away from it:

When the Chimera's eyes glow violet - When performing Dragon's Voice, a thundercloud AoE attack that damages and paralyzes everyone outside of Chimera's melee range. Ranged damage dealers and healers should move toward the boss immediately.
When the Chimera's eyes glow blue - When performing Ram's Voice, an ice AoE attack that damages and heavies everyone in Chimera's melee range. Tanks and melee damage dealers should move away from him as soon as possible.
The Chimera will randomly begin targeting adventurers with two new abilities as well:

Cacophony - The Chimera sends out a purple ball of energy that travels to the target and explodes. That party member targeted by this ability should move away from the ball immediately. If the ball hits a player while it is traveling, it will explode immediately. Explosion not only damages players but also paralyzes them.
Ram's Keeper - The Chimera spits an ice orb that flies from the Chimera to one random player. It triggers a ground indicator and will leave an icy patch at that location.
";
        }
    }
}