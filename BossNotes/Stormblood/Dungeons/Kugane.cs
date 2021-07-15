using BossNotes.Stormblood.Dungeons.KuganeBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class Kugane : Instance
    {
        public Kugane()
        {
            Name = "Kugane Castle";
            Level = 70;
            ZoneID = 662;
            Bosses = new Boss[]
            {
                new ZuikoMaru(),
                new DojunMaru(),
                new Yojimbo()
            };
        }
    }
}