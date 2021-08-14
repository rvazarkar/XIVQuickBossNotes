using BossNotes.Stormblood.Trials.FluminisBoss;

namespace BossNotes.Stormblood.Trials
{
    public class Fluminis : Instance
    {
        public Fluminis()
        {
            Name = "Castrum Fluminis";
            Level = 70;
            ZoneID = 778;
            Bosses = new Boss[]
            {
                new TsukuyomiP1(),
                new TsukuyomiP2(),
                new TsukuyomiP3()
            };
        }
    }
}