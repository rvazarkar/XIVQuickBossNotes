namespace BossNotes.ARR.Dungeons.HalataliBosses
{
    public class Tangata : Boss
    {
        public Tangata()
        {
            Name = "Tangata";
            QuickStrategy = "Avoid AoE. Kill adds when boss is invulnerable.";
            InDepthStrategy =
                @"He has a devastating frontal AoE cone attack. During the fight, Tangata will periodically become invulnerable in a pool of lava. While invulnerable, he summons wisps and fire sprites. Wisps will travel toward Tangata and explode if they reach him. Fire sprites will attack your party members. Kill the adds and Tangata will become vulnerable again.";
        }
    }
}