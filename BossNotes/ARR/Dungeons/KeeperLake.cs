using BossNotes.ARR.Dungeons.KeeperLakeBosses;

namespace BossNotes.ARR.Dungeons
{
    public class KeeperLake : Instance
    {
        public KeeperLake()
        {
            Name = "The Keeper of the Lake";
            Level = 50;
            ZoneID = 150;
            Bosses = new Boss[]
            {
                new Einhander(),
                new MagitekGunship(),
                new Midgardsormr()
            };
        }
    }
}