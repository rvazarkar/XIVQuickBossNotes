using BossNotes.ARR.Dungeons.HSunkenTempleBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HSunkenTemple : Instance
    {
        public HSunkenTemple()
        {
            Name = "The Sunken Temple of Qarn (Hard)";
            Level = 50;
            ZoneID = 367;
            Bosses = new Boss[]
            {
                new DamagedAdjudicator(),
                new Emperatriz(),
                new Vicegerent()
            };
        }
    }
}