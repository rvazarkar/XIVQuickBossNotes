namespace BossNotes.Stormblood.Trials.JadeStoaBoss
{
    public class ByakkoP3 : Boss
    {
        public ByakkoP3()
        {
            Name = "Phase 3";
            QuickStrategy = @"Mostly the same as phase 1. Split to avoid AoE markers stacking";
            InDepthStrategy =
                @"Hundredfold Havoc - a set of outward-firing AoE lightning patterns that are telegraphed by an arrow icon, displaying the direction they will travel from Byakko (arena centre). Two patterns will be fired simultaneously (the second being slightly delayed), giving players enough time for the first pattern to fire outward so that they can move into the now safe area to avoid the delayed pattern. Simultaneously, the raid must contend with Bombogenesis.
Bombogenesis - Byakko places AoE markers on four random players, forcing them to split up if they wish to avoid overlapping damage onto unmarked targets.
Distant Clap - spawns a lightning-based donut AoE around Byakko's current location, forcing the raid to move towards Byakko to avoid taking damage. Alternatively, if Byakko is positioned at the outer-edge of the arena before casting Distant Clap, players can also move away from the donut to avoid damage, seeing as Distant Clap is not wide enough to cover the entire arena.
From this point onward, Byakko will begin to cycle through previous displayed mechanics with various overlaps, including more Hundredfold Havoc (outward travelling lightning AoE's), Fire & Lightning (straight-line AoE's), State Of Shock (body-slam stack-markers), Storm Pulse (unavoidable AoE), and Unrelenting Anguish (outward travelling red orbs), and more, until Byakko has been defeated (or the raid suffers a wipe). Aside from forming slightly more challenging overlaps, all mechanics are handled in the exact same manner as they were before.";
        }
    }
}