namespace BossNotes.ARR.Trials.StepsOfFaithBoss
{
    public class Vishap : Boss
    {
        public Vishap()
        {
            Name = "Vishap";
            QuickStrategy = @"Use cannons to kill adds and boss. Avoid the boss's feet.
Dragon killers are on top of towers. Use them when boss is on red circles.";
            InDepthStrategy = @"Vishap is fought on a long bridge divided into four sections, all of which are divided by magicked barriers. Through the duration of the fight, Vishap will walk slowly across the bridge. He cannot be slowed, stopped, or aggroed, making time a serious factor. Should you fail to defeat him before he reaches the end of the bridge, you will fail the Duty.

Note that you do not fail the duty if your entire party dies. If you die just resurrect and run back to the fight.
As Vishap walks, adds will spawn around it.

Vishap is not a true damage threat besides its feet. The boss' stomps deal 5 to 6k damage Players can avoid this by standing under him between his legs or move far away from him.

The boss will perform large, conal AoE in front of him. If you are arming the cannons, do not stand in front of the boss.";
        }
    }
}