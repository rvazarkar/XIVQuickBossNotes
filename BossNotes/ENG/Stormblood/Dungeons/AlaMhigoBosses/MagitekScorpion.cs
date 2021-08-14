namespace BossNotes.Stormblood.Dungeons.AlaMhigoBosses
{
    public class MagitekScorpion : Boss
    {
        public MagitekScorpion()
        {
            Name = "Magitek Scorpion";
            QuickStrategy = @"Bait ""Target Search"" away from party.";
            InDepthStrategy = @"Electromagnetic Field: Area wide moderate damage.
Target Search: Places a target marker under players. It takes about 6s to aquire its target. Bait it away and drop it somewhere safe. It will put a small AOE at its final place.
Tail Laser: Line AOE front/behind Magitek Scorpion.";
        }
    }
}