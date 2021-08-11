using BossNotes.ARR.Trials.HWhorleaterBoss;

namespace BossNotes.ARR.Trials
{
    public class HWhorleater : Instance
    {
        public HWhorleater()
        {
            Name = "The Whorleater (Hard)";
            Level = 50;
            ZoneID = 281;
            Bosses = new Boss[]
            {
                new Leviathan()
            };
        }
    }
}