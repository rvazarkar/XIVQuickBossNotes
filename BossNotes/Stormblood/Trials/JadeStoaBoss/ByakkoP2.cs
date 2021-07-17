namespace BossNotes.Stormblood.Trials.JadeStoaBoss
{
    public class ByakkoP2 : Boss
    {
        public ByakkoP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Avoid the outer ring, dodge orbs.";
            InDepthStrategy = @"After being launched into the air, the raid will begin free-falling. No actions (e.g. attacks or healing) can be performed at this time. During the phase, the outer ring of the arena will kill any player who touches it. Additionally, Byakko will begin firing orbs from far below which players must avoid. Periodically, Byakko will leap up and cast a doughnut AoE which must be avoided by moving into the centre. Lastly, Hakutei (the White Tiger) will occasionally cast a straight line AoE through the centre, forcing players to move out.

Should you survive the onslaught, the raid will land (stunned) in a new arena be blasted with a massive unavoidable AoE attack from Byakko, killing any player who took too much damage during the free-fall.";
        }
    }
}