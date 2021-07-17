using BossNotes.Stormblood.Dungeons.BurnBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class TheBurn : Instance
    {
        public TheBurn()
        {
            Name = "The Burn";
            Level = 70;
            ZoneID = 789;
            Bosses = new Boss[]
            {
                new Hedetet(),
                new DefectiveDrone(),
                new MistDragon()
            };
        }
    }
}