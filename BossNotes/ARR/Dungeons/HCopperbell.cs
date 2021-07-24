using BossNotes.ARR.Dungeons.HCopperbellBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HCopperbell : Instance
    {
        public HCopperbell()
        {
            Name = "Copperbell Mines (Hard)";
            Level = 50;
            ZoneID = 349;
            Bosses = new Boss[]
            {
                new Hecatoncheir(),
                new Gogmagolem(),
                new Ouranos()
            };
        }
    }
}