namespace BossNotes.Stormblood.Dungeons.HellsLidBosses
{
    public class OtakeMaru : Boss
    {
        public OtakeMaru()
        {
            Name = "Otake-maru";
            QuickStrategy = @"Kite boss when he jumps to you.";
            InDepthStrategy = @"Abilities

100-tonze Swing: Large point blank AoE around Otake.
10-tonze Slash: Large cone shaped AoE, directed away from the tank.
Grrraaarrrgh: Otake will jump to a player (other than tank) and will follow that player. Kite him around the area because he starts drooling lava. Likewise he will drop his mace & shield. After some time he will jump to shield and mace and will, upon landing, do a short range point blank AoE.";
        }
    }
}