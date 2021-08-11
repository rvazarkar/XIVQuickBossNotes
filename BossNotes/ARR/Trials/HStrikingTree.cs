using BossNotes.ARR.Trials.HStrikingTreeBoss;

namespace BossNotes.ARR.Trials
{
    public class HStrikingTree : Instance
    {
        public HStrikingTree()
        {
            Name = "The Striking Tree (Hard)";
            Level = 50;
            ZoneID = 374;
            Bosses = new Boss[]
            {
                new Ramuh()
            };
        }
    }
}