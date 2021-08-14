namespace BossNotes.ARR.Dungeons.CastrumMeridianumBosses
{
    public class BlackEft : Boss
    {
        public BlackEft()
        {
            Name = "The Black Eft";
            QuickStrategy = @"Off-tank should grab adds at the door.";
            InDepthStrategy =
                @"One tank should tank The Black Eft while another tank should get the attention of the adds spawning at the doors. Players should avoid the heavy hitting Magitek Cannon ability.

Abilities

Photon Stream is an instant, frontal, ranged attack that does small to moderate amount of damage.
Magitek Cannon is a large circular AoE attack that targets a random player. It will do heavy damage to all players hit.
Adds

Imperial War Hound has a frontal column AoE ability that should be avoided.
8th Cohort Laquearius has a frontal cone AoE ability that should be avoided.
Imperial Signifer is an add with spell casting abilities";
        }
    }
}