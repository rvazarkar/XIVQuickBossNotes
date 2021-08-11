using BossNotes.ARR.Trials.HThornmarchBoss;

namespace BossNotes.ARR.Trials
{
    public class HThornmarch : Instance
    {
        public HThornmarch()
        {
            Name = "Thornmarch (Hard)";
            Level = 50;
            ZoneID = 207;
            Bosses = new Boss[]
            {
                new MoggleMog()
            };
        }
    }
}