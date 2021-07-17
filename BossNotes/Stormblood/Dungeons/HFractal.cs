using BossNotes.Stormblood.Dungeons.HFractalBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class HFractal : Instance
    {
        public HFractal()
        {
            Name = "The Fractal Continnum (Hard)";
            Level = 70;
            ZoneID = 743;
            Bosses = new Boss[]
            {
                new Motherbit(),
                new UltimaWarrior(),
                new UltimaBeast()
            };
        }
    }
}