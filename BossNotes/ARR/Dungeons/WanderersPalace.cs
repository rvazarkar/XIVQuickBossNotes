using BossNotes.ARR.Dungeons.WanderersPalaceBosses;

namespace BossNotes.ARR.Dungeons
{
    public class WanderersPalace : Instance
    {
        public WanderersPalace()
        {
            Name = "The Wanderer's Palace";
            Level = 50;
            ZoneID = 159;
            Bosses = new Boss[]
            {
                new Halidom(),
                new Bavarois(),
                new TonberryKing()
            };
        }
    }
}