namespace BossNotes.Stormblood.Trials.GreatHuntBoss
{
    public class RathalosP1 : Boss
    {
        public RathalosP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"Most attacks aren't telegraphed.
Melee should try and stick to the left side of the boss.
If Rathalos turns towards you and roars, side step the incoming charge.
If Rathalos looks to the left, move to the sides or away.
If Rathalos looks to the right, move out of range.";
            InDepthStrategy =
                @"Rathalos will rotate between a set of ground-based attacks against randomly chosen players. All players must keep an eye on where Rathalos is facing and what animation he is performing if they wish to avoid damage during his relentless onslaught.

Whipping Bite is indicated by Rathalos staring slightly to its left while opening his mouth and raising his tail. After a short delay, he will snap at players immediately in front of him while simultaneously swiping behind him with his tail. You can safely avoid this short-ranged attack by moving to either of Rathalos' flanks or by backing away.
Tail Swipe is a two-part attack indicated by Rathalos looking to his right side and menacingly raising his tail. After a brief delay, Rathalos will swing his tail in a 180-degree counterclockwise motion. Immediately after this, Rathalos will perform another 180-degree sweep after a short delay in the same counterclockwise motion. Anyone caught in the path of a Tail Swipe will receive moderate damage and a massive knockback, with a possibility of being stunned. To avoid this, players should either move to Rathalos' left flank or move out of range during the wind-up animation.
Charging Bite is a rush-attack indicated by Rathalos turning towards a player (regardless of distance) and performing a brief roar-like animation. After a short delay, Rathalos will then lunge directly at that player with a vicious bite, be they near or far. All players caught in the path of his charge will be inflicted with moderate damage and knockback, as well as a chance of being stunned. To avoid it, players should watch out for the brief wind-up animation and side-step out of its path as soon as possible.
Fireball is indicated by an overhead marker on the target player and is one of the few telegraphed attacks Rathalos uses. After rearing up for a few seconds, Rathalos will expel an unavoidable fireball at the marked player, inflicting moderate splash damage as well as a dispellable burns debuff. Players with the marker should move away from the party to avoid inflicting unnecessary damage to others.
Evasive Breath is indicated by Rathalos turning towards a target player and lowering its head and body. After a short delay, Rathalos will blast the area directly in front of him with fire during a backward leap, damaging, burning and knocking away anyone directly in front of him. This particular attack is one of the most dangerous as the telegraph is very short.
Rathalos will continuously target random players and use these abilities in no particular order until the third and final phase. Once Rathalos has been reduced to around 80% health, the add phase will begin.";
        }
    }
}