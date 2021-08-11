namespace BossNotes.ARR.Dungeons.HullbreakerBosses
{
    public class Sjoorm : Boss
    {
        public Sjoorm()
        {
            Name = "Sjoorm";
            QuickStrategy = @"Run into bubbles when the boss submerges";
            InDepthStrategy =
                @"This is a fairly straight forward fight. Occasionally bubbles will spawn, do not run into or contact the bubbles until the boss submerges underground for the second time and starts to cast a blue AoE wave that covers the entire boss room. By running into the bubbles, the players will be shielded from the boss' AoE damage. Players outside of the bubbles will take massive amount of damage.

Use the bubbles to avoid the boss' room-wide AoE. Otherwise do not touch the bubbles.";
        }
    }
}