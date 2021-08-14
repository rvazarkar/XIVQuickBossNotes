using BossNotes.Stormblood.Dungeons.ShisuiBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class Shisui : Instance
    {
        public Shisui()
        {
            Name = "Shisui of the Violet Tides";
            Level = 63;
            Bosses = new Boss[]
            {
                new Amikiri(),
                new RubyPrincess(),
                new ShisuiYohi()
            };
            ZoneID = 616;
        }
    }
}