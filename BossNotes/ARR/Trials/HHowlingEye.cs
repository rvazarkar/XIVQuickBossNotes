using BossNotes.ARR.Trials.HHowlingEyeBoss;

namespace BossNotes.ARR.Trials
{
    public class HHowlingEye : Instance
    {
        public HHowlingEye()
        {
            Name = "The Howling Eye (Hard)";
            Level = 50;
            ZoneID = 294;
            Bosses = new Boss[]
            {
                new HGarudaP1(),
                new HGarudaP2()
            };
        }
    }
}