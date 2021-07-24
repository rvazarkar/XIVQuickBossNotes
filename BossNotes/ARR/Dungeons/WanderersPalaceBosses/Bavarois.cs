namespace BossNotes.ARR.Dungeons.WanderersPalaceBosses
{
    public class Bavarois : Boss
    {
        public Bavarois()
        {
            Name = "Giant Bavarois";
            QuickStrategy = @"Kill adds. When the boss focuses you, run away";
            InDepthStrategy = @"Giant Bavarois will use the spell Fire. Players can interrupt his spell cast by stunning the boss or moving behind him while he is casting. Throughout the fight Giant Bavarois will spawn White, Blue, Green and Purple Bavarois adds in groups of 3-4. Purple and White adds are most dangerous because they inflict paralysis and heavy debuffs. They should be killed as soon as possible. Healers should remove the debuffs if possible. Occasionally, Giant Bavarois' eyes will focus onto a single target, causing him to chase that player, using Amorphic Flail when he gets close. The targeted player should run away to avoid the Amorphic Flail.

Abilities

Fire is a spell that deals a moderate amount of damage to one target.
Amorphic Flail is a attack that deals a large amount of damage to the focused player.
Adds

White Bavarois has a Blizzard spell that deals small amount of damage and inflicts the debuff Heavy.
Blue Bavarois has a Water spell that deals a small amount of damage.
Green Bavarois has an Aero spell that deals a small amount of damage and inflicts a DoT named Windburn.
Purple Bavarois has a Thunder spell that deals a small amount of damage and inflicts the debuff Paralysis.";
        }
    }
}