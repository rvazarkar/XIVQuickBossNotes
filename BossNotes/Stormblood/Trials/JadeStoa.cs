using BossNotes.Stormblood.Trials.JadeStoaBoss;

namespace BossNotes.Stormblood.Trials
{
    public class JadeStoa : Instance
    {
        public JadeStoa()
        {
            Name = "The Jade Stoa";
            Level = 70;
            ZoneID = 746;
            Bosses = new Boss[]
            {
                new ByakkoP1(),
                new ByakkoP2(),
                new ByakkoP3()
            };
        }
    }
}