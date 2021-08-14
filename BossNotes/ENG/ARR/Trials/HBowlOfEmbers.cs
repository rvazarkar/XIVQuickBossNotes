using BossNotes.ARR.Trials.HBowlOfEmbersBoss;

namespace BossNotes.ARR.Trials
{
    public class HBowlOfEmbers : Instance
    {
        public HBowlOfEmbers()
        {
            Name = "The Bowl of Embers (Hard)";
            Level = 50;
            ZoneID = 292;
            Bosses = new Boss[]
            {
                new HIfrit()
            };
        }
    }
}