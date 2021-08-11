namespace BossNotes.Stormblood.Trials.OhashiBoss
{
    public class YojimboP2 : Boss
    {
        public YojimboP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"At 50% dodge the dragon heads that move across the arena.
Stack together when you get a red triangle marker.
Orange markers will drop two AoEs, one small one ring.";
            InDepthStrategy =
                @"After reaching 80% HP, Yojimbo will move to the center of the arena, become untargetable, and shout ""Now we fight like men. And ladies. And men who dress like ladies! For Yojimbo... It is Gilgameshing time!"". Yojimbo will sink into a black vortex, then emerge from a golden light as Gilgamesh and toss his hat away. Phase 1 will then resume until Gilgamesh reaches 50% HP.
Dragon Night: Six dragon heads appear on one edge of the arena and slowly travel across in a straight line, dealing damage to players they touch and inflicting a stack of Vulnerability Up. After reaching the other end of the arena, the heads bombard the ground for moderate party-wide damage. Yojimbo says: ""Uh-oh! Someone woke the dragon...""
???: Ice spears will appear on the edges of the arena, firing off in checkerboard pattern line AoEs.
Gekka: Each player is marked with a peach-colored orb above their head and a small AoE at their feet. After a short delay, the attack hits in the small AoE for minor damage, then strikes as a ring AoE around each initial hit for higher damage. Despite what the indicators may seem, it's safer to stack with allies than to spread apart, though players should never stack with more than two others.
Occasionally, the ring AoEs from the most recent use of Gekka will reappear a short time later and strike again. Gilgamesh says: ""Divide and conquer, Gilgamesh style!""
Tiny Song: Red triangle markers over each player. Players not stacking with at least one other person are inflicted with the Minimum debuff. Gilgamesh says: ""This should cut you down to size!""
Zanmato: Reduces the entire party's HP to 1. Gilgamesh says: ""Behold, the sword art of legend—Zanmato!""";
        }
    }
}