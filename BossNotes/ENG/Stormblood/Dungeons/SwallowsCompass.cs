using BossNotes.Stormblood.Dungeons.SwallowsCompassBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class SwallowsCompass : Instance
    {
        public SwallowsCompass()
        {
            Name = "The Swallow's Compass";
            Level = 70;
            ZoneID = 768;
            Bosses = new Boss[]
            {
                new Otengu(),
                new Daidarabotchi(),
                new QitianDasheng()
            };
        }
    }
}