using BossNotes.ARR.Dungeons.ThousandMawsBosses;

namespace BossNotes.ARR.Dungeons
{
    public class ThousandMaws : Instance
    {
        public ThousandMaws()
        {
            Name = "The Thousand maws of Toto-Rak";
            Level = 24;
            Bosses = new Boss[]
            {
                new Graffias()
            };
            ZoneID = 169;
        }
    }
}