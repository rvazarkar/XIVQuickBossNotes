namespace BossNotes.ARR.Dungeons.SastashaBosses
{
    public class CaptainMadison : Boss
    {
        public CaptainMadison()
        {
            Name = "Captain Madison";
            QuickStrategy = "Phase 1, kill adds. Phase 2, AoE adds with boss and then kill boss.";
            InDepthStrategy =
                @"Players will need to defeat Captain Madison twice. In the first encounter, he will be accompanied by crew member adds. Kill them first and then focus on the boss until he runs away. In the second encounter, he will summon a pack of guard dogs once his HP has dropped to 50%. AoE the dogs down then attack the Captain until he flees.";
        }
    }
}