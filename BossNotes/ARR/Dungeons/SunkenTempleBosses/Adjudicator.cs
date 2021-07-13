namespace BossNotes.ARR.Dungeons.SunkenTempleBosses
{
    public class Adjudicator : Boss
    {
        public Adjudicator()
        {
            Name = "Adjudicator";
            QuickStrategy =
                "Kill sun jurors on top of glowing platform. Avoid blue beams and kill Mythril Verges ASAP. When black box spawns, DPS should get inside boxes and kill verges.";
            InDepthStrategy = @"Mythril Verge
When the Mythril Verge spawns, it will start firing beams of laser across the room. When a pale, blue beam appears across the ground, move out of its way immediately. The beam will light up after about 1 second and heavily damage anyone in its path. Because of the high damage and low health nature of the Mythril Verge, damage dealers should destroy them as soon as they spawn.
Avoid blue beams and destroy verges asap.
After the Adjudicator has taken some damage, he will spawn Verge in a large dark box on the ground. After a few seconds the black box will seal off and the Verge will begin to cast Verge Pulse. Verge Pulse explodes the Verge and does a decent amount of damage to your entire party. While the black box is visible, players who are not in it will do reduced damage. Damage Dealers should enter the black box as soon as it spawns and destroy the verge.
Players should enter the black box as soon as it spawns and destroy the verge.
After taking a significant amount of damage, the Adjudicator will spawn 2 black boxes in the 2 corners of the room. The two damage dealers should split up and enter the two boxes and destroy the verges before they can cast Verge Pulse.
When near death, Adjudicator will summon 4 laser-shooting Mythril Verge at a time. Players should dodge the lasers while taking out as many Verges as they can. DPSing down the boss is also an option.
Sun Juror
In the beginning of the fight, the Adjudicator will spawn cube-shaped mobs named Sun Jurors. When fighting these creatures, players need to ensure that the mobs die on the square platforms on the ground. If you do not kill them on the platforms, they will continuously revive. No more Sun Jurors will spawn once the Mythril Verges start spawning.
Other Abilities
Darkness is a frontal AoE cone attack that will damage and blind the players struck.
Paralyze is a spell used by the Adjudicator. He will periodically and randomly inflict paralyze on one of your party members. Melee players should attempt to interrupt his casting. Healers should use Esuna on the afflicted player to remove the debuff.
Creeping Darkness is an instant ability that deals a moderate amount of damage to all party members.";
        }
    }
}