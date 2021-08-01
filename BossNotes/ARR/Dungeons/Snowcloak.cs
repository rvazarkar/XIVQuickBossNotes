using BossNotes.ARR.Dungeons.SnowcloakBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Snowcloak : Instance
    {
        public Snowcloak()
        {
            Name = "Snowcloak";
            Level = 50;
            ZoneID = 371;
            Bosses = new Boss[]
            {
                new  Wandil(),
                new Yeti(),
                new Fenrir()
            };
        }
    }
}