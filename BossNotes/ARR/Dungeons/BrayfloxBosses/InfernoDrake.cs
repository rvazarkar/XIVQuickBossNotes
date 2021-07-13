namespace BossNotes.ARR.Dungeons.BrayfloxBosses
{
    public class InfernoDrake : Boss
    {
        public InfernoDrake()
        {
            Name = "Inferno Drake";
            QuickStrategy = "Avoid AoE, kill the add when it spawns.";
            InDepthStrategy =
                @"Inferno Drake is a fire-breathing drake. It has an AoE cone attack that should be avoided by casters and melee dps. Halfway through the way, Brayflox will run into the boss room with a drake named Tempest Biast, chasing him. Kill the smaller drake, save Brayflox, then kill the Inferno Drake.";
        }
    }
}