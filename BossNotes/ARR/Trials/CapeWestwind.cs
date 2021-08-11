using BossNotes.ARR.Trials.CapeWestwindBoss;

namespace BossNotes.ARR.Trials
{
    public class CapeWestwind : Instance
    {
        public CapeWestwind()
        {
            Name = "Cape Westwind";
            Level = 49;
            ZoneID = 332;
            Bosses = new Boss[]
            {
                new Rihtahtyn()
            };
        }
    }
}