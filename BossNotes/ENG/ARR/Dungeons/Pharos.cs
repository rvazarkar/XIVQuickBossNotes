using BossNotes.ARR.Dungeons.PharosBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Pharos : Instance
    {
        public Pharos()
        {
            Name = "Pharos Sirus";
            Level = 50;
            ZoneID = 160;
            Bosses = new Boss[]
            {
                new Symond(),
                new Zu(),
                new Tyrant(),
                new Siren()
            };
        }
    }
}