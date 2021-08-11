using BossNotes.ARR.Trials.HAkhAfahBoss;

namespace BossNotes.ARR.Trials
{
    public class HAfkAkah : Instance
    {
        public HAfkAkah()
        {
            Name = "Akh Afah Amphitheatre (Hard)";
            Level = 50;
            ZoneID = 377;
            Bosses = new Boss[]
            {
                new Shiva()
            };
        }
    }
}