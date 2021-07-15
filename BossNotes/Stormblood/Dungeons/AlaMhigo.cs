using BossNotes.Stormblood.Dungeons.AlaMhigoBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class AlaMhigo : Instance
    {
        public AlaMhigo()
        {
            Name = "Ala Mhigo";
            Level = 70;
            ZoneID = 689;
            Bosses = new Boss[]
            {
                new MagitekScorpion(),
                new AulusMalAsina(),
                new Zenos()
            };
        }
    }
}