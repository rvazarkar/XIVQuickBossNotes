namespace BossNotes.ARR.Dungeons.StoneVigilBosses
{
    public class ChudoYudo : Boss
    {
        public ChudoYudo()
        {
            Name = "Chudo-Yudo";
            QuickStrategy = @"All non-tanks should be behind the boss. Dont stand in front of ""Swinge""";
            InDepthStrategy =
                @"Chudo-Yudo is the first boss of the dungeon. He has powerful frontal breath attacks that all players besides the tank should avoid. One strategy is to only have the tank stand in front of Chudo-Yudo, rest of the party members stand behind the dragon at all times. By staying out of his breath attacks, the fight should be fairly easy.

All non-tanks stand behind the dragon at all times.
Abilities

Rake is an instant melee attack that deals a small amount of damage.
Lion's Breath is a casted breath attack that moderate amount of damage and inflicts the debuff burn to all targets hit.
Swinge is a frontal AoE cone attack that deals a moderate amount of damage and inflicts the debuffs Silence and Pacification for 5 seconds to all targets hit.";
        }
    }
}