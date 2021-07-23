using BossNotes.ARR.Dungeons.StoneVigilBosses;

namespace BossNotes.ARR.Dungeons
{
    public class StoneVigil : Instance
    {
        public StoneVigil()
        {
            Name = "The Stone Vigil";
            Level = 41;
            ZoneID = 168;
            Bosses = new Boss[]
            {
                new ChudoYudo(),
                new Koshchei(),
                new Isgebind()
            };
        }
    }
}