namespace BossNotes.ARR.Dungeons.HAmpadorKeepBosses
{
    public class Boogyman : Boss
    {
        public Boogyman()
        {
            Name = "Boogyman";
            QuickStrategy = @"Kill the Luminescence when the boss goes invisible. Take the buff to the boss to reveal.
Kill big adds ASAP.";
            InDepthStrategy = @"During the fight Boogyman will become partially invisible and untargetable. Kill the Luminescence orb and grab the Irradiance buff by standing in the area around it. Run to the invisible Boogyman to reveal him when the buff wears off with an illuminating AOE explosion that knocks him back.

Adds will appear as the dead bodies on the ground are reanimated. They are called Bloodmoon Sacrifice. The first set will spawn at around 55%. The next set will spawn at around 30% when Boogyman splits into two.

When his HP is low, Boogyman will split into two and both forms will become invisible. Players need to split up with the Irradiance buff to reveal both of them.";
        }
    }
}