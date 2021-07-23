using BossNotes.ARR.Dungeons.CastrumMeridianumBosses;

namespace BossNotes.ARR.Dungeons
{
    public class CastrumMeridianum : Instance
    {
        public CastrumMeridianum()
        {
            Name = "Castrum Meridianum";
            Level = 50;
            ZoneID = 217;
            Bosses = new Boss[]
            {
                new BlackEft(),
                new MagitekVanguardFI(),
                new Rubricatus(),
                new LiviaP1(),
                new LiviaP2()
            };
        }
    }
}