namespace BossNotes.Stormblood.Dungeons.HFractalBosses
{
    public class Motherbit : Boss
    {
        public Motherbit()
        {
            Name = "Motherbit";
            QuickStrategy = @"When bits form a line, get behind them.";
            InDepthStrategy =
                @"Electrochemical Transfer: Bits reactivate and form a pattern - Attacks tank and throws out linear AoEs. Move out of the damage zones when they appear.
Allagan Gravity: Circle AoE - Leaves behind a puddle that will pull you in if too close.
Citadel Buster: The bits form a line in the center of the arena, facing one direction. Quickly get behind them to avoid massive damage and knockback.";
        }
    }
}