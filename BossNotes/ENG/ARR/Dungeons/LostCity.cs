using BossNotes.ARR.Dungeons.LostCityBosses;

namespace BossNotes.ARR.Dungeons
{
    public class LostCity : Instance
    {
        public LostCity()
        {
            Name = "The Lost City of Ampador";
            Level = 50;
            ZoneID = 363;
            Bosses = new Boss[]
            {
                new DecayingGourmand(),
                new Arioch(),
                new Diabolos()
            };
        }
    }
}