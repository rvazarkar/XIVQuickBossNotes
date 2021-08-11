namespace BossNotes.ARR.Dungeons.StoneVigilBosses
{
    public class Isgebind : Boss
    {
        public Isgebind()
        {
            Name = "Isgebind";
            QuickStrategy = @"When the boss takes off, stand near the middle to avoid the AoE.
Otherwise, stand near the edges of the room to keep ice away from center.";
            InDepthStrategy =
                @"Isgebind is the final boss of The Stone Vigil. This icy dragon has powerful breath attacks along with massive AoE capabilities. Non-tank party members should stay away from the front of the dragon to avoid its breath attacks. Occasionally, Isgebind will cast Sheet of Ice on a random party member, players should move out of the red ground indicator circle when it appears underneath them.

Throughout the fight, Isgebind will take flight and about half of the room will glow in a icy blue light. After a few seconds Isegebind will fly over the area and use its frost breath. Players caught in the area will take heavy damage. Squishier players (e.g. healers and ranged DPS) can be killed instantly by this, so be careful. This attack with either fill one half of the room, or a strip down the middle. Stand near the middle and be prepared to run toward one side.

Players should try to stand near the outside of the room when possible. The AoE from Sheet of Ice is persistent. If too many Sheet of Ice AoEs are in the middle of the room, it can make it difficult to dodge Cauterize.

Be sure to avoid the red ground indicators and glow blue areas
Try to stand near the outside of the room whenever possible to keep the middle clear of Sheet of Ice AoEs
Abilities

Rime Wreath is an ice ability that damages all players for moderate amount of damage.
Frost Breath is a frontal cone AoE attack that deals heavy damage to all targets hit.
Sheet of Ice is frozen orb ability that targets a random player. It deals a moderate amount of damage and inflicts the debuff Paralysis. After the orb explodes, an ice effect is placed on the location of its explosion. The frozen ground inflicts the debuff Frostbite to all players standing on it.
Cauterize is an ability that turns about half of the room into a icy blue color. After a few seconds, Isgebind flies to the area and deals damage and inflicts the debuff Frostbite to all targets in area. This deals very heavy damage and can insta-kill squishier players.
Touchdown is an ability used by Isegebind after it uses Cauterize, Isgebind crashes to the player with the highest enmity, dealing small amount of damage to all players nearby.";
        }
    }
}