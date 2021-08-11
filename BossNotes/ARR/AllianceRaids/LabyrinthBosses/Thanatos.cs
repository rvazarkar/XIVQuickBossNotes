namespace BossNotes.ARR.AllianceRaids.LabyrinthBosses
{
    public class Thanatos : Boss
    {
        public Thanatos()
        {
            Name = "Thanatos";
            QuickStrategy = @"Heal pots to full when they're tethered.
If ethereal, attack the boss. If not, kill adds.";
            InDepthStrategy =
                @"Thanatos is the 3rd boss of the dungeon. Players will encounter the boss when they take the right path from the labyrinth entrance.

Thanatos is a ghostly iron giant that is surrounded by three Magic Pots on the corner of his chamber. The Magic Pots are friendly mobs, and should be healed if they're damaged. If all three die, then you will be unable to harm the boss and will wipe.

Thanatos is “ghostly” and cannot be harmed ordinarily. At the beginning of the fight, one of the Magic Pots will shoot green lines out to several alliance members, giving them an “Intangible” debuff. The first group to receive buff is always A. This debuff allows you to deal damage to the boss. A tank with the debuff should pick up the boss immediately, and a tank swap should occur whenever a tank picks up the debuff and the one on the boss loses it. Thanatos does have a cleave, so he should be faced away from the group and the pots.

Anyone not having that debuff should focus on killing the adds that spawn throughout the fight. They will charge the Pots and attack, and occasionally will have a red line connecting them to a pot. Anytime you see this, these adds must be killed immediately. While that red line is active, Thanatos will be pulling the Pot to himself with a giant Holmgang chain -- if he gets it to him, he will kill it pretty fast. Once the adds connected to the Pot die and the Pot is healed, it can escape back to its safe spot.

This fight progresses fairly straightforwardly from here, just repeating the basic mechanics until he dies or all three Pots die.

If you're a ghost (invisible), DPS the boss. If you're visible, kill adds. Healers should keep the pots alive.";
        }
    }
}