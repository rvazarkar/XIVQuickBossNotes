namespace BossNotes.Stormblood.Dungeons.GhimlytBosses
{
    public class MarkIII : Boss
    {
        public MarkIII()
        {
            Name = "Mark III-B Magitek Colossus";
            QuickStrategy = @"Stack for ""Magitek Ray"". Stay in front of the AoE for ""Magitek Slash"".";
            InDepthStrategy = @"Jarring Blow: Tankbuster that hits a wide arc in front of the boss.
Ceruleum Vent: Moderate damage on the entire party.
Magitek Ray: Stack marker on one player.
Exhaust: Line attack in the direction of a random player.
Wild Fire Beam: A targeted AoE on each player, spread to avoid overlapping damage.
Magitek Slash: The Colossus slams its sword down, dealing damage in a cone area and leaving behind a fiery puddle that inflicts Burns while standing in it. The Colossus will rotate and slam down repeatedly until it has covered the entire arena. The first puddle will dissipate as the Colossus turns to make the final strike.";
        }
    }
}