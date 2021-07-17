namespace BossNotes.Stormblood.Dungeons.HSaintMocianneBosses
{
    public class Tokkapchi : Boss
    {
        public Tokkapchi()
        {
            Name = "Tokkapchi";
            QuickStrategy = @"Spread out for ""Quagmire"" as it will leave a puddle when it expires.
Don't allow the add to get by by any AoE. Attacks will push the add away.";
            InDepthStrategy = @"The arena for this fight is a grate with four solid platforms. Periodically, the mud beneath the platform will churn with the message ""The puddles begin to froth"". After a short delay, mud will explode upwards through the grate, damaging players not on a solid platform and launching them into the air.

Mudsling: Tankbuster.
Quagmire: All players are marked for an AoE. Spread out to avoid overlap, but also keep the center of the attack off the solid platforms. Allowing Quagmire to coat a platform creates a highly-damaging puddle on that platform.
Mud Pie: Tokkapchi will move to the center of the arena and create a Mud Slime add. The add cannot be killed, only pushed via damage. Keep all of the boss's area of effect attacks away from the Mud Slime, including the periodic puddle explosion. Allowing the Mud Slime to be hit with attacks will cause it to grow, causing it to deal more damage when it finally detonates.
After roughly 45 seconds, the Mud Slime will cast Corrupture, dealing damage to the entire party based on how large it became. If the Mud Slime was not allowed to grow at all, Corrupture instead only hits melee range. If the Mud Slime grows once, Corrupture will deal moderate party-wide damage. If the Mud Slime grows twice, it will explode immediately for very high damage while also inflicting Damage Down.
Royal Flush: Melee-range area of effect.
During the second cast of Mud Pie, two Muddy Dorpokkur adds will spawn. These adds have low HP and mainly serve as a distraction from the newly-created Mud Slime.
Feculent Flood: Cone attack targeting the Mud Slime. Very long cast time to allow the players to push the Mud Slime away.
Bog Bequest: Ring area of effect that leaves melee range safe. If Tokkapchi is on the edge of the arena, the opposite side is also a safe area.";
        }
    }
}