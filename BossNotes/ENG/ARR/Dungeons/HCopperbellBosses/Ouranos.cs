namespace BossNotes.ARR.Dungeons.HCopperbellBosses
{
    public class Ouranos : Boss
    {
        public Ouranos()
        {
            Name = "Ouranos";
            QuickStrategy =
                @"Healer should pick up rocks and drop them on the sand only when worms are looking for food.";
            InDepthStrategy =
                @"Non-tank players should not stand in front of the boss. Avoid its circular AoE attacks and kill Giga adds when they spawn.

Occasionally, a Sand Worm will spawn. When the text ""The abyss worm is searching for fodder"" appears on screen, one of the players should pick up the object Crystallized Rock (found around the edges of the arena) and place it somewhere in the sand. Players should move away from the rock to avoid taking damage from the Sand Worm. If the rock is not placed in time, the Sand Worm will cast Bottomless Desert and pull all players to the middle of the room and deal heavy damage to all players. Bottomless Desert can easily lead to a wipe, so make sure someone is on dedicated rock duty.
TL;DR:

Burn down boss
When Sand Worm is Searching for Fodder, carry Crystallized Rock onto the sand and drop it to distract the worm";
        }
    }
}