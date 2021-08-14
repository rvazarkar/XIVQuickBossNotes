using BossNotes.ARR.Trials.UrthsFountBoss;

namespace BossNotes.ARR.Trials
{
    public class UrthsFount : Instance
    {
        public UrthsFount()
        {
            Name = "Urth's Fount";
            Level = 50;
            ZoneID = 394;
            Bosses = new Boss[]
            {
                new Odin()
            };
        }
    }
}