using BossNotes.ARR.Dungeons.HStoneVigilBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HStoneVigil : Instance
    {
        public HStoneVigil()
        {
            Name = "The Stone Vigil (Hard)";
            Level = 50;
            ZoneID = 365;
            Bosses = new Boss[]
            {
                new Gorynich(),
                new CucaFera(),
                new Giruveganaus()
            };
        }
    }
}