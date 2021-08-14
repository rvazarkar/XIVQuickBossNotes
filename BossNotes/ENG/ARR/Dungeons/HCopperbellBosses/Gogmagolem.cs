namespace BossNotes.ARR.Dungeons.HCopperbellBosses
{
    public class Gogmagolem : Boss
    {
        public Gogmagolem()
        {
            Name = "Gogmagolem";
            QuickStrategy =
                @"Kill adds, use the blasting device, pick up bombs and try to drop them in front of the boss.";
            InDepthStrategy =
                @"Gogmagolem is a spriggan operating a rock giant. The boss not only has very high defense, it will also move back and forth in the boss room.

In the boss room, there is an object named Improved Blasting Device. One of your party members should operate the Device to spawn a Waymaker Bomb. That player should pick up the bomb. When it says it is going to explode in 5 seconds, place it in the path of the Gogmagolem. This is the main method of damaging the boss. Black bombs will also spawn near the Blasting Device and the center of the room. These will Self-Destruct, so move away quickly.

The other DPS should focus on killing all of the Kindling Sprites that spawn around the edges of the room.

When the Golem dies, the spriggan named Biggy will spawn. Kill Biggy and move away from very large bombs because these bombs will explode in a very large radius.

TL;DR:

One DPS should spawn bombs with Improved Blasting Device, then carry and drop bombs in path of Gomagolem
Other DPS focus adds
When Biggy spawns, DPS him down";
        }
    }
}