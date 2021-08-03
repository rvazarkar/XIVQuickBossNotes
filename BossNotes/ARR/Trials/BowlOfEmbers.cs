using BossNotes.ARR.Trials.BowlOfEmbersBoss;

namespace BossNotes.ARR.Trials
{
    public class BowlOfEmbers : Instance
    {
        public BowlOfEmbers()
        {
            Name = "The Bowl of Embers";
            Level = 20;
            ZoneID = 202;
            Bosses = new Boss[]
            {
                new IfritP1(),
                new IfritP2(),
                new IfritP3(),
                new IfritP4()
            };
        }
    }
}