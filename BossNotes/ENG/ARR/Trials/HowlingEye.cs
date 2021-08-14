using BossNotes.ARR.Trials.HowlingEyeBoss;

namespace BossNotes.ARR.Trials
{
    public class HowlingEye : Instance
    {
        public HowlingEye()
        {
            Name = "The Howling Eye";
            Level = 44;
            ZoneID = 208;
            Bosses = new Boss[]
            {
                new GarudaP1(),
                new GarudaP2()
            };
        }
    }
}