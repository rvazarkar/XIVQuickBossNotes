namespace BossNotes.ARR.Dungeons.HullbreakerBosses
{
    public class Sasquatch : Boss
    {
        public Sasquatch()
        {
            Name = "Sasquatch";
            QuickStrategy =
                @"Kill adds then boss. When boss is angry, activate a banana tree. Dont let adds get bananas.";
            InDepthStrategy =
                @"Kill adds then the boss. Every now and then Sasquatch will get hungry and repeatedly pound his chest. When this occurs, players should activate one of the banana trees and allow the boss to eat the banana dropped from the tree. The bananas calm him down, stopping his debuffs and AoE attacks for a while. Throughout the fight, monkey adds will spawn. Kill these adds and do not let them eat the bananas.

When the boss pounds his chest, activate the Bananas Tree and spawn banana. Do not let the adds go near the spawned bananas.";
        }
    }
}