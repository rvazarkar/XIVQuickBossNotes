using BossNotes.ARR.Trials.ChrysalisBoss;

namespace BossNotes.ARR.Trials
{
    public class Chrysalis : Instance
    {
        public Chrysalis()
        {
            Name = "The Chrysalis";
            Level = 50;
            ZoneID = 426;
            Bosses = new Boss[]
            {
                new NabrialesP1(),
                new NabrialesP2()
            };
        }
    }
}