using BossNotes.Stormblood.Trials.PoolOfTributeBoss;

namespace BossNotes.Stormblood.Trials
{
    public class PoolOfTribute : Instance
    {
        public PoolOfTribute()
        {
            Name = "The Pool of Tribute";
            Level = 63;
            ZoneID = 674;
            Bosses = new Boss[]
            {
                new SusanoP1(),
                new SusanoP2(),
                new SusanoP3()
            };
        }
    }
}