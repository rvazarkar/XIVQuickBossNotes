namespace BossNotes.Stormblood.Dungeons.SirensongBosses
{
    public class Lorelei : Boss
    {
        public Lorelei()
        {
            Name = "Lorelei";
            QuickStrategy =
                "Morbid Advance and Morbid Retreat will force you to move forward and backwards respectively. Position yourself so you don't run into AoE";
            InDepthStrategy = @"Somber Melody: Party-wide AoE.
Void Water III: AoE on targeted party member.
Virgin tears: Leaves Damage over time areas, and eventually a ring all around the room. These areas will fade after she casts either Morbid Advance or Morbid Retreat
Morbid Advance and Morbid Retreat force your character to move forward, or backwards respectively. Position yourself accordingly so that you avoid Virgin Tears as much as possible. Note that ""forward"" and ""backward"" are relative to the direction you're facing; it does not mean you'll be drawn to/repelled from the boss. Pick the safest route you can based on the skill to follow.";
        }
    }
}