using BossNotes.ARR.Dungeons.HBrayfloxBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HBrayfloxLongstop : Instance
    {
        public HBrayfloxLongstop()
        {
            Name = "Braflox's Longstop (Hard)";
            Level = 50;
            ZoneID = 362;
            Bosses = new Boss[]
            {
                new IlluminatiCommander(),
                new MagitekVangobGIII(),
                new GobmachineGVI()
            };
        }
    }
}