namespace BossNotes.ARR.Trials.BowlOfEmbersBoss
{
    public class IfritP4 : Boss
    {
        public IfritP4()
        {
            Name = "Phase 4";
            QuickStrategy = @"Avoid AoEs.";
            InDepthStrategy = @"Eruption now creates a ring of non-targeted area-denial AoEs.
This ring can appear around the perimeter of the arena.
This ring can appear in the center of the arena.
Both rings can appear one after the other.";
        }
    }
}