using BossNotes.Stormblood.Dungeons.GhimlytBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class Ghimlyt : Instance
    {
        public Ghimlyt()
        {
            Name = "The Ghimlyt Dark";
            Level = 70;
            ZoneID = 793;
            Bosses = new Boss[]
            {
                new MarkIII(),
                new Prometheus(),
                new AnniaJulia()
            };
        }
    }
}