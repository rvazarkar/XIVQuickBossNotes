namespace BossNotes.ARR.Dungeons.HStoneVigilBosses
{
    public class CucaFera : Boss
    {
        public CucaFera()
        {
            Name = "Cuca Fera";
            QuickStrategy = @"Dont attack boss when the shell is up. Use cannons to kill everything.
Second cannon ability interrupts ""Hard Stomp""";
            InDepthStrategy =
                @"For this Cuca Fera, the players will operate 4 cannons in the 4 corners to the room to attack the boss. These cannons have two abilities. First ability is a normal damaging shot with low cooldown. The second ability is a shot that stuns the boss but has long cooldown. Use the normal shots to damage the boss but Do NOT fire at it when it turtles. You can notice it's turtling when its shell glows red. While turtled, your shots will bounce back, hurting you instead of the boss.

Designate two people to be ""stunners"". The Boss has a group wide AoE called Hard Stomp. Use the second ability of the cannon to interrupt its casting. Two people rotating the stuns should be enough to let CD's recharge. The boss has an attack where it sets itself on fire and charges a cannon. Very easy to avoid if you're paying attention.

When adds spawn, players should kill them with their cannons. Because cannons cannot fire at targets nearby, party members should help each other to clean up the adds.

Do not allow all of the NPCs die. If they do, the boss will do an unstunnable Hard Stomp that instantly wipes the party.";
        }
    }
}