namespace BossNotes.Stormblood.Trials.MenagerieBosses
{
    public class ShinryuP1 : Boss
    {
        public ShinryuP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"When ""Tidal Wave"" spawns, run to the side of the platform with the waterspout. 
When ""Hellfire"" is cast, stand in water puddles.
When ""Judgement Bolt"" is cast, don't stand in puddles.";
            InDepthStrategy =
                @"When the gauge reaches 100 for the first time, run to the edge with the pillar of water falling from the sky to avoid being pushed off. Healers: use Rescue to save people by pulling them to the edge.

After Shinryu has used two Corrupted Aether attacks, the battle transitions to phase 2.";
        }
    }
}