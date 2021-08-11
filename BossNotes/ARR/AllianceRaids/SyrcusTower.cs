using BossNotes.ARR.AllianceRaids.SyrcusTowerBosses;

namespace BossNotes.ARR.AllianceRaids
{
    public class SyrcusTower : Instance
    {
        public SyrcusTower()
        {
            Name = "Syrcus Tower";
            Level = 50;
            ZoneID = 372;
            Bosses = new Boss[]
            {
                new Scylla(),
                new GlasyaLabolas(),
                new Amon(),
                new Xande()
            };
        }
    }
}