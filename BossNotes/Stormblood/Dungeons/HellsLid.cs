using BossNotes.Stormblood.Dungeons.HellsLidBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class HellsLid : Instance
    {
        public HellsLid()
        {
            Name = "Hell's Lid";
            Level = 70;
            ZoneID = 742;
            Bosses = new Boss[]
            {
                new OtakeMaru(),
                new Kamaitachi(),
                new Genbu()
            };
        }
    }
}