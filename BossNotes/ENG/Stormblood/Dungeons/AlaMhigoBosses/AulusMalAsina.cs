namespace BossNotes.Stormblood.Dungeons.AlaMhigoBosses
{
    public class AulusMalAsina : Boss
    {
        public AulusMalAsina()
        {
            Name = "Aulus Mal Asina";
            QuickStrategy =
                @"Safe zone for overlap is inside. When ""Out of Body"", get back to your body while dodging adds";
            InDepthStrategy = @"The fight could be separated in 3 phases:

Phase 1: Pre-Out-of-Body.
Phase 2: Out-of-Body.
Phase 3: Post-Out-of-Body.
Abilities

Mana Burst: Area wide moderate damage.
Order to Charge: Places 3 drones somewhere in the area.
Order to Fire: Shortly after Order to Charge, places large AOE circles somewhere in the area. After the AOE is done, three (3) larger, overlapping circles will appear. Save zones are inside.
Magitek Disruptor: Stuns and sucks the player in.
Mindjack: Knocks back and applies Out of Body. Player must reach and touch their body (Unconscious Adeventure - linked by fiery line with the player). Prototype Death Claws will spawn. These mobs stun at melee range.Prototype Bits spawn around the area. They will shoot blue laser that stun on hit. Recommendation: Dodge the Death Claws by moving to a side, away from the mobs. Avoid the blue lasers and get your body. Do note, that player may die in this phase. Death Claws must be killed a soon as normal gamplay is resumed.
Demimagicks: Places a marker and AOE under each player. Uses overlapping circles from Order to Fire but to a larger extent at the same time.";
        }
    }
}