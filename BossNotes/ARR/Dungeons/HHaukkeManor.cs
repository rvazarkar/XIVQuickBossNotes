using BossNotes.ARR.Dungeons.HHaukkeBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HHaukkeManor : Instance
    {
        public HHaukkeManor()
        {
            Name = "Haukke Manor (Hard)";
            Level = 50;
            ZoneID = 350;
            Bosses = new Boss[]
            {
                new ManorJester(),
                new Ash(),
                new Halicarnassus()
            };
        }
    }
}