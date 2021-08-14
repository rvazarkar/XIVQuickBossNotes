namespace BossNotes.ARR.Dungeons.PharosBosses
{
    public class Tyrant : Boss
    {
        public Tyrant()
        {
            Name = "Tyrant";
            QuickStrategy = @"Just burn the boss";
            InDepthStrategy = @"Tank: Face the boss away from the group and pick up the Sailor adds.

Move out of the circular AoE that appears under Tyrant during Bombination.

The boss seems to have quite low HP. Either AoE the adds with the boss or just burn the boss down.";
        }
    }
}