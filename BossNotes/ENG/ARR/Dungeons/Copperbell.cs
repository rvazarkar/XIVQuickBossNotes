using BossNotes.ARR.Dungeons.CopperbellBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Copperbell : Instance
    {
        public Copperbell()
        {
            Name = "Copperbell Mines";
            Level = 17;
            Bosses = new Boss[]
            {
                new Kottos(),
                new Ichorous(),
                new Gyges()
            };
            ZoneID = 161;
        }
    }
}