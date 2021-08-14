using BossNotes.ARR.Dungeons.HWanderersPalaceBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HWanderersPalace : Instance
    {
        public HWanderersPalace()
        {
            Name = "The Wanderer's Palace (Hard)";
            Level = 50;
            ZoneID = 188;
            Bosses = new Boss[]
            {
                new KoheelJa(),
                new ZoloolJa(),
                new MolaaJaJa()
            };
        }
    }
}