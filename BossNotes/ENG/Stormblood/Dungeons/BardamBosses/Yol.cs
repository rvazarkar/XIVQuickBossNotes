namespace BossNotes.Stormblood.Dungeons.BardamBosses
{
    public class Yol : Boss
    {
        public Yol()
        {
            Name = "Yol";
            QuickStrategy =
                "Phase 1: Avoid stacking orange markers, turn away for gaze attack. Phase 2: Green marker will knock you back. Stay close to center.";
            InDepthStrategy = @"Phase 1
Feathercut Frontal cleave tank-buster.
Wind Unbound Group-wide AoE. Spawns a number of orbs around the outer edge of the arena. Orbs will periodically fire line AoEs.
Flutterfall Marks all players with orange markers. Players need to spread to avoid overlapping splash damage.
Eye of the Fierce Gaze attack that causes Confusion. Look away to avoid status infliction.
At the end of this phase, Yol will retreat and spawn a Corpsecleaner Eagle. Once the first is killed, Yol will spawn one more and after killing it Yol will return to the arena. During this time, Yol will periodically appear the edge of the arena, performing line AoE attacks with no markers. Move out from in front of Yol when it appears to avoid damage.

Phase 2
Wingbeat Marks a player with a green marker. The marked player will be knocked to the outer edge of the arena. Get back to the center of the arena to avoid outer AoEs.
At the start of this phase, Yol's wings will become targetable and Yol will become untargetable. Players must kill both wings to proceed. During this time, Yol will spawn three circular AoEs that will rotate clock-wise around the outer edge of the arena. Players should stay close to the center to avoid these. Once Yol's wings are shattered, the fight's mechanics will repeat until Yol is defeated.

Note: This phase can be entirely skipped with a well-timed Limit Break just before Yol starts his second phase.";
        }
    }
}