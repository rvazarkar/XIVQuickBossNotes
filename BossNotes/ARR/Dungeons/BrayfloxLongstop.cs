using BossNotes.ARR.Dungeons.BrayfloxBosses;

namespace BossNotes.ARR.Dungeons
{
    public class BrayfloxLongstop : Instance
    {
        public BrayfloxLongstop()
        {
            Name = "Brayflox's Longstop";
            Level = 32;
            Bosses = new Boss[]
            {
                new Pelican(),
                new InfernoDrake(),
                new Hellbender(),
                new DeepJungleCoeurl(),
                new Aiatar()
            };
            ZoneID = 158;
        }
    }
}