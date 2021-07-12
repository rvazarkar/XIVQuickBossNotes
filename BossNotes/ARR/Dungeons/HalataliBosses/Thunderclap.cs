namespace BossNotes.ARR.Dungeons.HalataliBosses
{
    public class Thunderclap : Boss
    {
        public Thunderclap()
        {
            Name = "Thunderclap Guivre";
            QuickStrategy = "Kill elementals when they spawn, fight the boss at the stairs so you're not in the water.";
            InDepthStrategy =
                @"Thunderclap Guivre is a drake with that can use Levinshower, a frontal AoE cone attack, and Electrify, a non-self-centered AoE attack. During this boss fight, Thunderclap Guivre will become invulnerable twice. He spawns lightning elementals while invulnerable. Kill the elementals and the drake will become vulnerable again. Occasionally the water will glow purple; any players standing in the water will take damage over time.

It is in a shallow pool of water. Those in the water will take significantly more damage from the lightning attacks, so it is advised to fight on either of the slopes.
During both add phases, it will run back into the pool to spawn the elementals which will approach the party.";
        }
    }
}