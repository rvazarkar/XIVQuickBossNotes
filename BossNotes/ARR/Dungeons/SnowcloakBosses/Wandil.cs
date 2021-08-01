namespace BossNotes.ARR.Dungeons.SnowcloakBosses
{
    public class Wandil : Boss
    {
        public Wandil()
        {
            Name = "Wandil";
            QuickStrategy = @"Freeze happens at 4 stacks. Kill bombs to prevent extra stacks.";
            InDepthStrategy = @"Wandil has several AOE abilities (one of which is unavoidable) which add a stacking debuff to all players affected. Once this debuff reaches 4 stacks, the player is frozen (effectively stunned) for a short duration. Periodically he will summon Ice Bombs which will self-destruct after some time or when they get low health. These should be killed to avoid additional damage and more stacks of the debuff. Healers should keep an eye on their stack count and try to top up the party's health before they're stunned.

At a certain point during the fight, he'll also create a persistent ring of ice around the edges of the most arena which must be avoided, limiting the players room to maneuver and avoid AoE.";
        }
    }
}