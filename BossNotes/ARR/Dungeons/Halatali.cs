using BossNotes.ARR.Dungeons.HalataliBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Halatali : Instance
    {
        public Halatali()
        {
            Name = "Halatali";
            Level = 20;
            Bosses = new Boss[]
            {
                new Firemane(),
                new Thunderclap(),
                new PitPeiste(),
                new Tangata()
            };
        }
    }
}