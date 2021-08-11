namespace BossNotes.ARR.Dungeons.WanderersPalaceBosses
{
    public class TonberryKing : Boss
    {
        public TonberryKing()
        {
            Name = "Tonberry King";
            QuickStrategy =
                @"Avoid killing adds when possible. Stay near the middle when adds spawn around the room and burn boss";
            InDepthStrategy =
                @"Tanks should stay in the middle of the room and within the melee range of the Tonberry King to avoid Scourge of Nym. Throughout the fight, Tonberry King will spawn small Tonberry adds. When they die they will give Tonberry King a stack of Rancor. Tonberry King will use Everybody's Grudge and deal moderate damage for every stack of Rancor it has. The ability also removes all the Rancor stacks on the boss. Do not let the Tonberry King have too many stacks of Rancor, avoid killing Tonberries if they aren't an issue.

At around quarter HP, Tonberry King will spawn multiple Tonberry Slashers around the room. These adds will periodically move closer to the center of the room. Players should away from the slashers and toward the center of the room. Slashers will do heavy amount of damage to players nearby and players that aggro them. Players should focus down the Tonberry King.

Abilities

Lateral Slash is a instant melee attack that deals a small amount of damage one player.
Whetstone is an instant ability that gives the buff Sharpened Knife to Tonberry King. Tonberry King's next Lateral Slash will be Sharpened Knife and deal extra damage.
Sharpened Knife is an instant melee attack that deals a moderate amount of damage to one player.
Scourge of Nym is an instant ranged attack that deals a heavy amount of damage and inflicts the debuff heavy Heavy. Tonberry King will only use this attack if its target is not in melee range.
Everybody's Grudge is an ability that consumes all the stacks of Rancor on Tonberry King and deals a moderate amount of damage for every stack of Rancor.
Adds

Tonberry has an ability named Scourge of Nym that inflicts the debuff Heavy to its target when the target is not in melee range. When Tonberry dies, Tonberry King gains 1 stack of Rancor.
Tonberry Slasher has a powerful instant melee strike named Throat Stab that deals a heavy amount of damage. Its Scourge of Nym deals massive amount of damage and inflicts heavy to its target when the target is outside of melee range.
Do not get close or attack the Tonberry Slashers.";
        }
    }
}