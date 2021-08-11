namespace BossNotes.ARR.AllianceRaids.LabyrinthBosses
{
    public class Atomos : Boss
    {
        public Atomos()
        {
            Name = "Atomos";
            QuickStrategy = @"Move onto the path that corresponds to your raid letter.
4 people need to stand on the back platform as long as its glowing.
Don't start this fight until everyone is on their stairs!";
            InDepthStrategy = @"The raid will need to divide into their 3 groups: 1 for each path, which each has a platform. 4 people need to stand on each platform (preferably including 2 healers) to allow the other groups to kill Atomos. Atomos does not need to be tanked but will continuously spawn adds. The tanks need to position these adds within range of the DPS on the platforms; alternatively, a regen effect on the forward tank/DPS will automatically let the healer pull the adds to the platform if no one in front touches them.

Note: Do not stand on the pads before the alliance has all arrived, that will start the raid and force the late players to teleport into the left chamber.

4 people stand on each colored platform. The other four focus on killing Atomos.";
        }
    }
}