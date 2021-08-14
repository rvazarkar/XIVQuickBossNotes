namespace BossNotes.ARR.Trials.HStrikingTreeBoss
{
    public class Ramuh : Boss
    {
        public Ramuh()
        {
            Name = "Ramuh";
            QuickStrategy = @"Hit ""Terrorized"" players with lightning circles to free them. Kill adds ASAP.
If tethered in phase 2, one person should grab 3 orbs. ";
            InDepthStrategy =
                @"Chaotic Strike - Fears 2 players that are not top enmity after a short cast time. They will walk slowly toward Ramuh then get killed by the melee AoE Thunderspark by Ramuh if Chaos/Seduced is not broken by Thunderstorm. Player with the Thunderstorm needs to move to the feared players. This is a team coordination mechanic, think T8 ballistic missile.

Grey Arbiter - Adds that spawn at 65%, just kill them all so the party does not wipe to Judgement Bolt. Because they fire lightning beams at random targets, these adds do not need to be tanked. They also have an ability that fires at Ramuh and lowers the time left until Judgement bolt, so kill them sequentially. Melee should begin from behind the boss and ranged from in front of the boss, and move clockwise.

Judgement Bolt - Negligible damage if all Grey Arbiter adds were killed, otherwise dealing 30k damage and instantly kills the player.

Orbs - Eat 3 to give a shield for a minute that prevents you from dying to Shock Strike, otherwise it does around 17k damage and goes through Hallowed. Building shield also removes tether. The more orbs are out, the more damage Thunderstorm deals. Managing shield duration is the tank swap mechanic. Eating more than 3 will give an 'overcharged' shield that reduces healing per stack but still blocks Shock Strike. It caps at 3 stacks.

Rolling Thunder - After the add phase, two random people can get chained by a lightning. These two players need to stop all actions and one, and only one, of the chained players need to quickly gather 3 orbs to break the chain. If the off-tank gets the chain, he picks up the orbs and provokes Ramuh afterwards.

Shock Strike - AoE attack on tanks. Tanks need to gather three to get a debuff (Surge Protection) that makes them able to survive Shock Strike. The current off-tank picks up 3 orbs from every second Thunderstorm and Provokes Ramuh. Tanks keep swapping like this until the end. Tanks can get more than three stacks of orbs but any extra after third reduces healing received (Static Condensation).

Thunderstorm - Happens all throughout the fight. AoE circles at random spots and three following random players. Some of them leave orbs behind that empower Ramuh but can be picked up. The orbs and Thunderstorm circles leave a stacking debuff (Electroconductivity) on anyone hit, which will be the main mechanic of the fight. The water in the arena will also electrify after Thunderstorm, dealing more damage if stood in.

Thunderspark - melee AoE, moderate damage, but kills Chaotic Strike targets.";
        }
    }
}