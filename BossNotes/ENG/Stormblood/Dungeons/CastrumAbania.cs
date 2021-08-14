using BossNotes.Stormblood.Dungeons.AbaniaBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class CastrumAbania : Instance
    {
        public CastrumAbania()
        {
            Name = "Castrum Abania";
            Level = 69;
            ZoneID = 661;
            Bosses = new Boss[]
            {
                new MagnaRoader(),
                new NumberXXIV(),
                new Inferno()
            };
        }
    }
}