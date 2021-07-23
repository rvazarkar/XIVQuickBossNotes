namespace BossNotes.ARR.Dungeons.CuttersCryBosses
{
    public class MyrmidonPrincess : Boss
    {
        public MyrmidonPrincess()
        {
            Name = "Myrmidon Princess";
            QuickStrategy = @"Kill Marshal -> Guard -> Soldiers or kite around the room.";
            InDepthStrategy = @"Myrmidon Princess is the first boss of Cutter's Cry. Her main abilities include:

Mandible Bite is a frontal cone AoE attack that damages all targets within.
Silence is a spell used to silence one of your party members for a short time.
Trap Jaws is an instant melee attack.
Haste is a spell used by the Myrmidon Princess to increase the attack speed of her adds.
At around half health Myrmidon Princess will summon 3 types of adds to aid her in combat:

Myrmidon Marshal is the most dangerous add type. It has an AoE frontal cone ability, Mandible Bite, that damages all targets caught within. The Marshal can also use an ability named Formic Pheromones. Formic Pheromones places a healing over time buff on Myrmidon Princess.
Myrmidon Guard is the 2nd add type. It also has Mandible Bite, the frontal AoE cone ability.
Myrmidon Soldier is the least dangerous add type. It has only the basic attack.
It is recommended to kill Myrmidon Marshal first, Myrmidon Guard second, and Myrmidon Soldiers last. Alternatively, the adds can be kited around the room by a healer.";
        }
    }
}