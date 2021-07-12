using BossNotes.ARR.Dungeons.Bosses;
using BossNotes.ARR.Dungeons.SastashaBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Sastasha : Instance
    {
        public Sastasha()
        {
            Name = "Sastasha";
            Level = 15;
            Bosses = new Boss[]
            {
                new Chopper(),
                new CaptainMadison(),
                new Denn()
            };
        }
    }
}