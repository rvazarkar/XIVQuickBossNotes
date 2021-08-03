using BossNotes.ARR.Trials.TheNavelBoss;

namespace BossNotes.ARR.Trials
{
    public class TheNavel : Instance
    {
        public TheNavel()
        {
            Name = "The Navel";
            Level = 34;
            ZoneID = 206;
            Bosses = new Boss[]
            {
                new TitanP1(),
                new TitanP2()
            };
        }
    }
}