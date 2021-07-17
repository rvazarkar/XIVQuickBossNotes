using BossNotes.Stormblood.Trials.MenagerieBoss;

namespace BossNotes.Stormblood.Trials
{
    public class Menagerie : Instance
    {
        public Menagerie()
        {
            Name = "The Royal Menagerie";
            Level = 70;
            ZoneID = 679;
            Bosses = new Boss[]
            {
                new ShinryuP1(),
                new ShinryuP2(),
                new ShinryuP3()
            };
        }
    }
}