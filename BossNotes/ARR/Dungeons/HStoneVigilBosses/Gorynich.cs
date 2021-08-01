namespace BossNotes.ARR.Dungeons.HStoneVigilBosses
{
    public class Gorynich : Boss
    {
        public Gorynich()
        {
            Name = "Gorynich";
            QuickStrategy = @"Stay behind the boss. Kill adds ASAP. Healer should stay away from boss to aggro adds.";
            InDepthStrategy = @"Gorynich fight is similar to the first boss fight in the normal Stone Vigil. He moves around and uses Swinge. Use Sprint to stay behind him to not get hit. When he spawns adds, the adds will automatically attack the healer. DPS should kill the adds ASAP. Please note that these adds will perform an AoE on death (one is a large conal in front and the other is a large circle around them). If the boss is in range of these AoE's, it will gain Haste and Damage Up.

Try to tank the boss in a corner and place your healer away from him.";
        }
    }
}