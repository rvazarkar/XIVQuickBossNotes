namespace BossNotes.ARR.Dungeons.AurumValeBosses
{
    public class Locksmith : Boss
    {
        public Locksmith()
        {
            Name = "Locksmith";
            QuickStrategy = @"Stand near your own Morbol Fruit. When you have 2-3 stacks of the debuff, eat a fruit.";
            InDepthStrategy = @"Locksmith is the first boss of The Aurum Vale. This gigantic Ochu has several high damage mechanics that will test the capabilities of the parties' healers.

In the boss area, there are objects named Morbol Fruit along the sides of the room. Players can interact with the fruits to remove all of the Gold Lung debuff stacks on themselves. After interacting with a fruit, it will disappear. The Morbol Fruits respawn over time.

Each member of the party should stand near 1 Morbol Fruit. Players should use the Morbol Fruit after receiving 2 stacks of Gold Lung.
Abilities

Hundred Lashings is a melee attack that deals moderate to high amount of damage.
Gold Rush is an instant ability that places a damage over time debuff named Gold Lung on all players. This effect stacks. The debuff can be removed by consuming a Morbol Fruit.
Gold Dust is a circular AoE spell that appears under a random player. It deals moderate damage to all players hit.";
        }
    }
}