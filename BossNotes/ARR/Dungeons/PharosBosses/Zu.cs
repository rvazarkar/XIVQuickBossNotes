namespace BossNotes.ARR.Dungeons.PharosBosses
{
    public class Zu : Boss
    {
        public Zu()
        {
            Name = "Zu";
            QuickStrategy = @"Kill birds, not eggs.";
            InDepthStrategy = @"Tank: Face the boss away from the group.

Healer: Be prepared for a lot of AoE healing.

There are two types of eggs, spotted and plain. The plain eggs spawn an add that does a minor AoE while the spotted eggs spawn an add that channels onto a player. Ignore the eggs until the emote ""The egg is threatening to hatch,"" which will cause 2-3 eggs to start to glow purple. Only kill one of them. If one of them is a spotted egg, kill it. If more than one is killed, Zu will bodyslam a party member, which can easily kill someone.

When Zu flies into the air, kill any adds that are alive. While in the air, Zu will place ground effects under the tank.";
        }
    }
}