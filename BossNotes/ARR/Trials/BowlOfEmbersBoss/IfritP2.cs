namespace BossNotes.ARR.Trials.BowlOfEmbersBoss
{
    public class IfritP2 : Boss
    {
        public IfritP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Avoid AoEs.";
            InDepthStrategy = @"Periodically uses Eruption.
Targeted radial AoE.
Move to avoid.";
        }
    }
}