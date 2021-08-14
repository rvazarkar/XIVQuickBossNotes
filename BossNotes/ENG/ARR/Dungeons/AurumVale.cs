using BossNotes.ARR.Dungeons.AurumValeBosses;

namespace BossNotes.ARR.Dungeons
{
    public class AurumVale : Instance
    {
        public AurumVale()
        {
            Name = "The Aurum Vale";
            Level = 47;
            ZoneID = 172;
            Bosses = new Boss[]
            {
                new Locksmith(),
                new Coincounter(),
                new MisersMistress()
            };
        }
    }
}