using BossNotes.ARR.Dungeons.TamTaraBosses;

namespace BossNotes.ARR.Dungeons
{
    public class TamTara : Instance
    {
        public TamTara()
        {
            Name = "The Tam Tara Deepcroft";
            Level = 16;
            Bosses = new Boss[]
            {
                new Galvanth()
            };
            ZoneID = 164;
        }
    }
}