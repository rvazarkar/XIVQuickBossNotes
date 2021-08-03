using BossNotes.ARR.Dungeons.HSastashaBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HSastasha : Instance
    {
        public HSastasha()
        {
            Name = "Sastasha (Hard)";
            Level = 50;
            ZoneID = 387;
            Bosses = new Boss[]
            {
                new Karlabos(),
                new CaptainMadisons(),
                new SastashaKraken()
            };
        }
    }
}