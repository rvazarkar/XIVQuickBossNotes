namespace BossNotes.ARR.Trials.BowlOfEmbersBoss
{
    public class IfritP3 : Boss
    {
        public IfritP3()
        {
            Name = "Phase 3";
            QuickStrategy = @"Kill ""Infernal Nail"" ASAP (this is a DPS check!)";
            InDepthStrategy = @"Spawns an Infernal Nail.
This is a DPS check. The nail must be killed immediately.";
        }
    }
}