using BossNotes.Stormblood.Dungeons.HSaintMocianneBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class HSaintMocianne : Instance
    {
        public HSaintMocianne()
        {
            Name = "Saint Mocianne's Arboretum (Hard)";
            Level = 70;
            ZoneID = 788;
            Bosses = new Boss[]
            {
                new Nullchu(),
                new Lakhamu(),
                new Tokkapchi()
            };
        }
    }
}