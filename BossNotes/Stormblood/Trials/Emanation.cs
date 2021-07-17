using BossNotes.Stormblood.Trials.EmanationBoss;

namespace BossNotes.Stormblood.Trials
{
    public class Emanation : Instance
    {
        public Emanation()
        {
            Name = "Emanation";
            Level = 67;
            ZoneID = 719;
            Bosses = new Boss[]
            {
                new LakshmiP1(),
                new LakshmiP2()
            };
        }
    }
}