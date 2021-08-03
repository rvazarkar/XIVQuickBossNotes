using BossNotes.ARR.Dungeons.HullbreakerBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Hullbreaker : Instance
    {
        public Hullbreaker()
        {
            Name = "Hullbreaker Isle";
            Level = 50;
            ZoneID = 361;
            Bosses = new Boss[]
            {
                new Sasquatch(),
                new Sjoorm(),
                new HullbreakerKraken()
            };
        }
    }
}