using BossNotes.ARR.Dungeons.HAmpadorKeepBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HAmpadorKeep : Instance
    {
        public HAmpadorKeep()
        {
            Name = "Ampador Keep (Hard)";
            Level = 50;
            ZoneID = 189;
            Bosses = new Boss[]
            {
                new Anchag(),
                new Boogyman(),
                new Ferdiad()
            };
        }
    }
}