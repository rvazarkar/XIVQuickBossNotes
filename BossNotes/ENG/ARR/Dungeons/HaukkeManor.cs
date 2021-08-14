using BossNotes.ARR.Dungeons.HaukeBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HaukkeManor : Instance
    {
        public HaukkeManor()
        {
            Name = "Haukke Manor";
            Level = 28;
            Bosses = new Boss[]
            {
                new Claviger(),
                new JesterSteward(),
                new Amandine()
            };
            ZoneID = 166;
        }
    }
}