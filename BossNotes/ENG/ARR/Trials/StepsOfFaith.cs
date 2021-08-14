using BossNotes.ARR.Trials.StepsOfFaithBoss;

namespace BossNotes.ARR.Trials
{
    public class StepsOfFaith : Instance
    {
        public StepsOfFaith()
        {
            Name = "The Steps of Faith";
            Level = 50;
            ZoneID = 143;
            Bosses = new Boss[]
            {
                new Vishap()
            };
        }
    }
}