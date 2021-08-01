using BossNotes.ARR.Dungeons.HHalataliBosses;

namespace BossNotes.ARR.Dungeons
{
    public class HHalatali : Instance
    {
        public HHalatali()
        {
            Name = "Halatali (Hard)";
            Level = 50;
            ZoneID = 360;
            Bosses = new Boss[]
            {
                new Pyracmon(),
                new Catoblepas(),
                new Mumuepo()
            };
        }
    }
}