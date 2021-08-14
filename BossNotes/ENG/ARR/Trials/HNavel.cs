using BossNotes.ARR.Trials.HNavelBoss;

namespace BossNotes.ARR.Trials
{
    public class HNavel : Instance
    {
        public HNavel()
        {
            Name = "The Navel (Hard)";
            Level = 50;
            ZoneID = 293;
            Bosses = new Boss[]
            {
                new HTitan()
            };
        }
    }
}