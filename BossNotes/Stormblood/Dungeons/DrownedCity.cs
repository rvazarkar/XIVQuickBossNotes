using BossNotes.Stormblood.Dungeons.DrownedCityBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class DrownedCity : Instance
    {
        public DrownedCity()
        {
            Name = "The Drowned City of Skalla";
            Level = 70;
            ZoneID = 731;
            Bosses = new Boss[]
            {
                new Kelpie(),
                new OldOne(),
                new Hrodric()
            };
        }
    }
}