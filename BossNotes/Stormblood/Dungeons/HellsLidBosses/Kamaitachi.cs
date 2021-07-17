namespace BossNotes.Stormblood.Dungeons.HellsLidBosses
{
    public class Kamaitachi : Boss
    {
        public Kamaitachi()
        {
            Name = "Kamaitachi";
            QuickStrategy = @"Safe zone for ""The wind begins to howl!"" is either melee range or max range. Staying close to the boss allows you to dodge ""The Patient Blade""";
            InDepthStrategy = @"Abilities

Whipping Wittret: No castbar. Tankbuster.
The wind begins to howl!: No castbar. Watch for the message on screen. Also, he will do a 360° just before it. The boss will do a large point blank AoE, save zone is close to him or far, far away.
The Patient Blade: 180 degree AoE.
The wind shifts!: Watch for the message. Large line AoE front/behind the boss.
Whispers in the Wind: Summons 4 Tsumuji-kaze adds. Places moving whirlwinds around the area. Places clouds around the area. The clouds explode and knockback on touch. From time to time fiery lines will appear between the whirlwinds. The boss will charge along those lines with a much larger hitbox than the lines themselves. Getting hit will do moderate damage and apply 1 stack of Vulnerability Up. At the end of this phase, a proximity AoE (Reaper's Gale) will be dropped at one edge of the area. First thing the boss will do after is The Patient Blade.
Suggestion: Stack somewhere near the edge and let the tank draw the adds to one spot. AoE them down but keep an eye open for the boss's charge. Group up in the middle after the proximity AoE is done. Prepare for Patient Blade.

ADDS

Tsumuji-kaze: Uses Tornado. Damage is rather low. Adds seem to be melee in general.";
        }
    }
}