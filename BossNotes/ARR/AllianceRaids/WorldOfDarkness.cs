using BossNotes.ARR.AllianceRaids.WorldOfDarknessBosses;

namespace BossNotes.ARR.AllianceRaids
{
    public class WorldOfDarkness : Instance
    {
        public WorldOfDarkness()
        {
            Name = "The World of Darkness";
            Level = 50;
            ZoneID = 151;
            Bosses = new Boss[]
            {
                new AngraMainyu(),
                new FiveHeadedDragon(),
                new Cerberus(),
                new CloudOfDarkness()
            };
        }
    }
}