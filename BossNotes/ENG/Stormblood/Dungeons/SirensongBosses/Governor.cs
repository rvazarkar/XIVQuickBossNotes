namespace BossNotes.Stormblood.Dungeons.SirensongBosses
{
    public class Governor : Boss
    {
        public Governor()
        {
            Name = "The Governor";
            QuickStrategy = "Avoid shadow areas. When tethered, run away from boss to break it";
            InDepthStrategy = @"Bloodburst: Party-wide AoE.
Shadowflow: Creates shadow areas on the ground, which fill a large portion of the room. Stay out of those shadow areas because they will stack magic damage vulnerability.
Enter Night: Marks a player, then does a draw-in and tether. Run far from the boss to break the tether.
Shadowsplit: Summons a bunch of small versions of himself, which then cover more areas during the ensuing Shadowflow.";
        }
    }
}