namespace BossNotes.ARR.Dungeons.HalataliBosses
{
    public class Firemane : Boss
    {
        public Firemane()
        {
            Name = "Firemane";
            QuickStrategy = "Burst firemane down or kill wisps to prevent mass AoE damage.";
            InDepthStrategy =
                @"Firemane is a fire elemental that summons wisps as adds. The wisps travel toward the fire pit in the center of the boss room. If they reach the pit, they will explode and deal damage to everyone in your party. 
                Be sure to burst Firemane down or kill the wisps before they can reach the pit.";
        }
    }
}