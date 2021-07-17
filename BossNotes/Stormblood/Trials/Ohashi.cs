using BossNotes.Stormblood.Trials.OhashiBoss;

namespace BossNotes.Stormblood.Trials
{
    public class Ohashi : Instance
    {
        public Ohashi()
        {
            Name = "Kugane Ohashi";
            Level = 70;
            ZoneID = 806;
            Bosses = new Boss[]
            {
                new YojimboP1(),
                new YojimboP2(),
                new YojimboP3(),
                new YojimboP4()
            };
        }
    }
}