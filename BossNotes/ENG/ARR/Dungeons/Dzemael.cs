using BossNotes.ARR.Dungeons.DzemaelBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Dzemael : Instance
    {
        public Dzemael()
        {
            Name = "Dzemael Darkhold";
            Level = 44;
            ZoneID = 171;
            Bosses = new Boss[]
            {
                new AllSeeingEye(),
                new Taulurd(),
                new Batraal()
            };
        }
    }
}