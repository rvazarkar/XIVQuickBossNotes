namespace BossNotes.ARR.Dungeons.CastrumMeridianumBosses
{
    public class MagitekVanguardFI : Boss
    {
        public MagitekVanguardFI()
        {
            Name = "Magitek Vanguard F-I";
            QuickStrategy = @"Non-tanks should be behind the boss. Off-tank should pick up adds.";
            InDepthStrategy =
                @"One tank should tank Magitek Vanguard F-I while the second tank grabs adds that spawn at the doors. Non-tank players should avoid the front of the boss.

Abilities

Cermet Drill is an instant, frontal melee attack that deals a moderate amount of damage.
Drill Cannons is a frontal column, AoE attack that deals a heavy amount of damage to all players hit.
Overcharge is a frontal cone AoE attack that deals heavy amount of damage and inflicts the debuff Paralysis to all players hit.
Adds

8th Cohort Signifer has a fire spell that should be avoided by moving out of the ground indicator.
8th Cohort Sagittarius has ranged attacks that apply DoTs to its targets.
Magitek Reaper has a large circular AoE ability that deals heavy damage to all targets get. Move out of the ground indicator immediately.";
        }
    }
}