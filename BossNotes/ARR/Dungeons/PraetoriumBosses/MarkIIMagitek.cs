namespace BossNotes.ARR.Dungeons.PraetoriumBosses
{
    public class MarkIIMagitek : Boss
    {
        public MarkIIMagitek()
        {
            Name = "Mark II Magitek Colossus";
            QuickStrategy = @"Stand behind the boss if you're not a tank. Kill da boss.";
            InDepthStrategy = @"All non-tank players should be behind the boss. Players should avoid the Magitek Ray ability. This fight is a simple tank and spank.

Abilities

Grand Sword is an instant frontal attack that deals a moderate amount of damage.
Exhaust is an instant frontal attack that deals a small amount of damage and knocks its target back.
Magitek Ray is a circular AoE attack that targets a random player. All players caught in the AoE will take moderate amount of damage and become inflicted with the debuff Burn.
Overheat is a buff that increases Mark II Magitek Colossus' damage.";
        }
    }
}