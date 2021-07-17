﻿using BossNotes.Stormblood.Dungeons;

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
        }
    }
}