using BossNotes.Stormblood.Dungeons;
using BossNotes.Stormblood.Trials;

namespace BossNotes.Stormblood
{
    public class Stormblood : Expansion
    {
        public Stormblood()
        {
            Name = "Stormblood";
            Dungeons = new Instance[]
            {
                new Sirensong(),
                new Shisui(),
                new BardamsMettle(),
                new CastrumAbania(),
                new AlaMhigo(),
                new Kugane(),
                new TempleFist(),
                new DrownedCity(),
                new HellsLid(),
                new HFractal(),
                new SwallowsCompass(),
                new HSaintMocianne(),
                new TheBurn(),
                new Ghimlyt()
            };
            Trials = new Instance[]
            {
                new PoolOfTribute(),
                new Emanation(),
                new Menagerie(),
                new Fluminis(),
                new Ohashi(),
                new GreatHunt(),
                new JadeStoa(),
            };
        }
    }
}