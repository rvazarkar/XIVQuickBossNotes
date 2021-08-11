namespace BossNotes.ARR.Dungeons.HSunkenTempleBosses
{
    public class DamagedAdjudicator : Boss
    {
        public DamagedAdjudicator()
        {
            Name = "Damaged Adjudicator";
            QuickStrategy = @"Kill the cores, not the boss. Move out of whirlpools.";
            InDepthStrategy =
                @"Do not attack the boss itself, attack the body part with the core. The core is indicated by a bright, red orb. Once the body part with the core is destroyed, the boss will break apart and adds will spawn. Kill the adds and repeat the process til the boss is dead.

Move out of the sand whirlpools that spawn on the ground. The whirlpools slowly pull you under the floor until you die.

Occasionally the boss will target a random player and spawn a sphere of sand. The sphere generates an circular AoE sand attack, it is advised that you move towards the edge of the battlefield if targeted.";
        }
    }
}