using BossNotes.ARR.Dungeons.AmpadorBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Ampador : Instance
    {
        public Ampador()
        {
            Name = "Ampador Keep";
            Level = 50;
            ZoneID = 167;
            Bosses = new Boss[]
            {
                new Psycheflayer(),
                new DemonWall(),
                new Anantaboga()
            };
        }
    }
}