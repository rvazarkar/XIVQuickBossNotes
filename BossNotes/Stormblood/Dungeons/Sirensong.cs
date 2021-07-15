using BossNotes.Stormblood.Dungeons.SirensongBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class Sirensong : Instance
    {
        public Sirensong()
        {
            Name = "The Sirensong Sea";
            Level = 61;
            Bosses = new Boss[]
            {
                new Lugat(),
                new Governor(),
                new Lorelei()
            };
            ZoneID = 626;
        }
    }
}