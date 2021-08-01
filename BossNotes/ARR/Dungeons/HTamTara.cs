using BossNotes.ARR.Dungeons.HTamTaraBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HTamTara : Instance
    {
        public HTamTara()
        {
            Name = "Tam-Tara Deepcroft (Hard)";
            Level = 50;
            ZoneID = 373;
            Bosses = new Boss[]
            {
                new Liavinne(),
                new SpareBody(),
                new Avere()
            };
        }
    }
}