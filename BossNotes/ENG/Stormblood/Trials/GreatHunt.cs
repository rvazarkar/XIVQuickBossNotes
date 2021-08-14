using BossNotes.Stormblood.Trials.GreatHuntBoss;

namespace BossNotes.Stormblood.Trials
{
    public class GreatHunt : Instance
    {
        public GreatHunt()
        {
            Name = "The Great Hunt";
            Level = 70;
            ZoneID = 761;
            Bosses = new Boss[]
            {
                new RathalosP1(),
                new RathalosP2(),
                new RathalosP3()
            };
        }
    }
}