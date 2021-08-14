using BossNotes.ARR.Dungeons.CuttersCryBosses;

namespace BossNotes.ARR.Dungeons
{
    public class CuttersCry : Instance
    {
        public CuttersCry()
        {
            Name = "Cutter's Cry";
            Level = 38;
            ZoneID = 170;
            Bosses = new Boss[]
            {
                new MyrmidonPrincess(),
                new GiantTunnelWorm(),
                new Chimera()
            };
        }
    }
}