namespace BossNotes.ARR.Dungeons.PharosBosses
{
    public class Symond : Boss
    {
        public Symond()
        {
            Name = "Symond the Unsinkable";
            QuickStrategy = @"Kill adds ASAP. If you reach 3 stacks, run away from everyone.";
            InDepthStrategy = @"Abilities in this encounter add a stack of Corrupting Crystal to each player. At three stacks, it will explode, dealing damage to all nearby players.

Stay spread out, avoid the long, narrow column attack, and kill the hounds as quickly as possible to limit stacks.

When the large circles appear, quickly move to one side of the room. It can be beneficial for the ranged to go to one side, while the melee go to the other to prevent an explosion from killing everyone. These circles will leave a persistent yellow pool which adds more stacks of the debuff.

If you reach 3 stacks of the debuff, run away from everyone. Since you are at 3 stacks, you can run into the yellow pool if you have to.

Around 15% HP, either use the melee LB to end the boss, or use the caster LB to kill the 3-4 hounds that spawn.";
        }
    }
}