namespace BossNotes.ARR.AllianceRaids.LabyrinthBosses
{
    public class BoneDragon : Boss
    {
        public BoneDragon()
        {
            Name = "The Bone Dragon";
            QuickStrategy = @"Stand on the raised platform. Kill skeletons ASAP. Skeletons must die before the dragon.";
            InDepthStrategy =
                @"Bone Dragon is the 1st boss of the Labyrinth of the Ancients. Players will encounter the Dragon when they take the left path from the entrance. Bone Dragon must be killed 3 times before it is finally defeated.

The arena has platforms similar to previous rooms. Poison will occasionally fill all lower areas of the room so be aware of this. The boss will spawn 3 waves of skeleton adds. Each group should stand in a separate side of the room and pull one add to the outside of the room on a platform. Each add must be killed on a separate platform. Once the bone dragon dies, all skeleton adds will respawn and move towards the dragon. If two skeletons were close to each other when they died, they will move too fast to be killed. Each skeleton that reaches the boss will do 1500 unblockable damage to the raid. This phase will repeat once. The second time the dragon comes back to life, he will spawn floating eyes instead. These should be picked up by tanks but dps should focusing on killing boss instead of adds then the dragon will die for good this time.

Tank the Bone Dragon on the center platform. This allows for an even spread of adds around the room, while minimizing confusion on where to pull the adds as 1 spawns per ""path"". This will also reduce damage taken by the DPS, as they will spend more time on the raised sections out of the poison.
Kill skeletons on different platforms, kill skeletons before they reach dragon.
Pick the floating eyes, leave them with tank only";
        }
    }
}