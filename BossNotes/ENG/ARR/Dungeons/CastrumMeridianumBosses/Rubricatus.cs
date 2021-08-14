namespace BossNotes.ARR.Dungeons.CastrumMeridianumBosses
{
    public class Rubricatus : Boss
    {
        public Rubricatus()
        {
            Name = "Magitek Colossus Rubricatus";
            QuickStrategy = @"If possible, stun the boss at 80% and at 60% to prevent the buff.";
            InDepthStrategy =
                @"One tank should tank Magitek Colossus Rubricatus while the other tank tank the adds that spawn. Players should spread out to lessen the damage taken from Magitek Ray. Players should also avoid standing in front of the Magitek Vanguard H-1 adds.

Abilities

Grand Sword is an instant frontal cleave attack that deals a moderate amount of damage to all targets hit.
Exhaust is a frontal column AoE attack that does a moderate amount of damage to all targets hit.
Magitek Ray is an instant attack that randomly targets a player and deals a moderate amount of damage to the player and nearby players.
Magitek Field gives Magitek Colossus Rubricatus the buff Vulnerability Down, massively reducing the damage it takes. This can be bypassed by stunning the boss at the right time (around 80% HP, then again at around 60%), which will make the fight significantly faster. Otherwise, it will last until Cid destroys the untargetable Magitek Death Claw adds tethered to it.
Adds

8th Cohort Laquearius has a frontal AoE cone attack that moderately damages all targets hit.
8th Cohort Medicus has the Cure spell that heals its ally.
Magitek Vanguard H-1 has a frontal cone and column AoE attacks that deal heavy damage to all targets hit.";
        }
    }
}