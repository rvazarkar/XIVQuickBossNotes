namespace BossNotes.ARR.Dungeons.AurumValeBosses
{
    public class MisersMistress : Boss
    {
        public MisersMistress()
        {
            Name = "Miser's Mistress";
            QuickStrategy = @"Eat a morbol fruit around 2-4 stacks of Burrs. Kill ""Strange Morbol Fruits"" as fast as possible.";
            InDepthStrategy = @"Miser's Mistress is the final boss of The Aurum Vale. This Morbol boss has powerful frontal AoE attacks and should be faced away from all non-tank players. The debuffs from Bad Breath could be deadly.

Similar to Locksmith, there are objects named Morbol Fruit around the boss room. Players can consume the fruit to remove all the stacks of the debuff Burrs on them. Players should consume the fruit at around 2-4 Burrs stacks.

Adds

After half HP, Miser's Mistress will occasionally spawn 5 strange Morbol Fruits. DPS must destroy these fruits immediately. Use AoE abilities if possible. These fruits will hatch into adds named Morbol Seedlings. The Seedlings will add Burr stacks with every attack. Focus your attacks on the seedlings when they appear. If the seedlings hatch, it can easily lead to a wipe from the Burr stacks.
Abilities

Bad Breath is a frontal cone AoE spell that inflicts the debuffs Paralysis, Silence, Poison, Blind, Slow, Heavy, HP Penalty, and Determination Down to all targets hit. If the healer gets hit by Bad Breath, it can very quickly lead to a wipe. Healers should stay far away from the boss, and Esuna or Leech the debuffs as quickly as possible if someone else gets hit. Tanks and DPS should avoid Bad Breath as much as they can. The affected target can also quickly clear the debuffs with a Morbol Fruit.
Vine Probe is a frontal column AoE attack that deals a moderate amount of damage to all targets hit.
Hooked Burrs is an ability that deals a small amount of damage and adds one stack of Burrs on a random player.
Burr Burrow is an ability that inflicts the player with the debuff Burrs and deals small amount of damage per stack of Burrs already on the player. If a player has enough Burr stacks, this can do a considerable amount of damage.";
        }
    }
}