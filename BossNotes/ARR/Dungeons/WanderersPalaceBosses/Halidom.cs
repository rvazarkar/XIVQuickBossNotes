namespace BossNotes.ARR.Dungeons.WanderersPalaceBosses
{
    public class Halidom : Boss
    {
        public Halidom()
        {
            Name = "Keeper of Halidom";
            QuickStrategy = @"If you're not a tank, don't be in front of the boss. 
Healers should cleanse the debuff.";
            InDepthStrategy = @"All non-tank players should not be in front of of Keeper of Halidom to avoid Beatdown and Moldy Sneeze. White Mages should use Esuna to remove Reduced Immunity debuff if possible. Players should spread out across the room to avoid being pulled in by Inhale. If you are pulled in, move away from the boss as soon as you can because Keeper of Halidom will use Goobbue's Grief right after Inhale. Players should also move out of the AoE ground indicator of Moldy Phlegm.

Abilities

Beatdown is an instant frontal melee attack that deals a small amount of damage.
Moldy Sneeze is an instant frontal attack that deals a moderate amount of damage and inflicts a debuff that reduces healing received on target.
Inhale is a large frontal cone AoE attack that pulls players into Keeper of Halidom's melee range.
Goobbue's Grief is a cloud of pollen that deals moderate amount of damage and Poisons all players within Keeper of Halidom's melee range.
Moldy Phlegm is a large circular AoE attack that targets a random player and deals moderate amount of damage and inflicts a debuff that reduces healing received to all players hit.";
        }
    }
}