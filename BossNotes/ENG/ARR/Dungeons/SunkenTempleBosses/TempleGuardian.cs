namespace BossNotes.ARR.Dungeons.SunkenTempleBosses
{
    public class TempleGuardian : Boss
    {
        public TempleGuardian()
        {
            Name = "Temple Guardian";
            QuickStrategy = "Kill Golem Soulstone when it appears, otherwise kill boss";
            InDepthStrategy =
                @"Temple Guardian is a gigantic rock golem boss. Throughout the fight, Temple Guardian will spawn Golem Soulstone onto its chest. While the Soulstone is alive, Temple Guardian takes virtually no damage. When the Golem Soulstone is destroyed, the golem is stunned and becomes vulnerable for a period of time before the Soulstone respawns. Players should switch their target to the Soulstone when it spawns. The Guardian will target random players with most of his abilities.

Abilities
Rockslide is a frontal column AoE attack that deals massive amount of damage to targets hit.
True Grit is a frontal cone AoE attack that deals moderate amount of damage to targets hit.
Boulder Clap is a frontal AoE attack that deals massive amount of damage to targets hit.
Obliterate is an instant attack that deals a moderate amount of damage to the entire party.
Stone Skull is an instant attack that deals a moderate amount of damage to a single player and stuns them for a short period of time.";
        }
    }
}