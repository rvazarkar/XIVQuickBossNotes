using BossNotes.ARR.Dungeons.SunkenTempleBosses;

namespace BossNotes.ARR.Dungeons
{
    public class SunkenTemple : Instance
    {
        public SunkenTemple()
        {
            Name = "The Sunken Temple of Qarn";
            Level = 35;
            Bosses = new Boss[]
            {
                new Teratotaur(),
                new TempleGuardian(),
                new Adjudicator()
            };
            ZoneID = 163;
        }
    }
}