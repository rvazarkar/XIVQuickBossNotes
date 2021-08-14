using BossNotes.Stormblood.Dungeons.BardamBosses;

namespace BossNotes.Stormblood.Dungeons
{
    public class BardamsMettle : Instance
    {
        public BardamsMettle()
        {
            Name = "Bardam's Mettle";
            Level = 65;
            Bosses = new Boss[] {new Garula(), new Bardam(), new Yol()};
            ZoneID = 623;
        }
    }
}