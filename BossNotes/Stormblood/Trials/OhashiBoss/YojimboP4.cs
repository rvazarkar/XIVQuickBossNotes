namespace BossNotes.Stormblood.Trials.OhashiBoss
{
    public class YojimboP4 : Boss
    {
        public YojimboP4()
        {
            Name = "Phase 4";
            QuickStrategy = @"Initial safe point is where the boss lands.
Destroy fetters on players ASAP.
Stand in large AoEs until line fires and then move into line AoE for ""Epic Stormsplitter""";
            InDepthStrategy = @"Gilgamesh lands with another Giga Jump on a single tank.
Electrogenetic Force: A grid of lightning orbs will appear in the arena, each exploding with a small AoE. The only safe spot is one of the ""grids"" near Gilgamesh's landing point. All subsequent casts instead place a lightning orb on top of each living player. Gilgamesh says: ""And now for something truly shocking!""
Gilgamesh will now always use Electrogenetic Force or Tiny Song during Dragon Night. Which one he uses is random.
Masamune: Gilgamesh dashes across the arena in a Line, following up with the two following attacks in quick succession. Gilgamesh says: ""Not the strongest of swords, but it should suffice.""
Zanma Zanmai: Reduces the entire party's HP to 1. Identical to Zanmato. Gilgamesh says: ""Behold, the sword art of legend—Zanmato!""
Epic Stormsplitter: Line AoE directly across the arena, followed immediately by two rectangular AoEs on either side, covering the entire platform save for a narrow line directly in front of Gilgamesh. Stand in the larger AoEs until the line attack fires, then quickly move into the now-safe middle area. Gilgamesh says: ""The seas part for Gilgamesh alone!""
Enchain: Traps four players in Fetters, prioritizing both tanks and both healers. Fettered players are untargetable and cannot act, but the fetters themselves can be targeted and destroyed. As he casts this ability, Gilgamesh will say: ""What's the matter, friend? All tied up?""
Hells' Gate: Slow casting attack that inflicts Instant Death on all players with the Fetters debuff.";
        }
    }
}