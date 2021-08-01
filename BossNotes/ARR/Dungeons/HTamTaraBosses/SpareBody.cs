namespace BossNotes.ARR.Dungeons.HTamTaraBosses
{
    public class SpareBody : Boss
    {
        public SpareBody()
        {
            Name = "Spare Body";
            QuickStrategy = @"Protect the NPC! Intercept balls so they dont reach him. Keep the boss away";
            InDepthStrategy = @"The friendly NPC, Paiyo Reiyo, is trapped in the middle and you must protect him. The boss has a lot of HP so this can take a while. The key is to stop the NPC in the middle from taking any damage. Any time he takes damage the boss will grow bigger and stronger. If he dies, the boss does a full party wipe attack. At various points during the fight purple balls of energy will come out of the portals and head towards the NPC. You need to have everyone run through them to prematurely detonate them to protect the NPC. Later, there will be two larger balls instead of the bunch of smaller ones. They seem to move slow enough so just knock them out. The boss also has an AoE attack that will leave a danger zone on the floor that causes bleeding type DoT. I was able to keep it on the edge of the map but really be careful not to let the NPC get hit by it.

Intercept the orbs spawned by the portals at the edge of the boss room. Do not let the orbs reach the center of the room!";
        }
    }
}