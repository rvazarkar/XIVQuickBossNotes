using BossNotes.Stormblood.Dungeons.TempleFistBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class TempleFist : Instance
    {
        public TempleFist()
        {
            Name = "The Temple of the Fist";
            Level = 70;
            ZoneID = 663;
            Bosses = new Boss[]
            {
                new CouerlSmriti(),
                new Arbuda(),
                new Ivon()
            };
        }
    }
}