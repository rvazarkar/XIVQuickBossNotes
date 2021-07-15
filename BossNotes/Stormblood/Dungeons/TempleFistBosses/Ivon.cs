namespace BossNotes.Stormblood.Dungeons.TempleFistBosses
{
    public class Ivon : Boss
    {
        public Ivon()
        {
            Name = "Ivon Couerlfist";
            QuickStrategy = @"Stand behind the boss to avoid AoE. Stack for ""Rose of Destruction"". Everyone should collect orbs when they spawn. Dodge ""Silent Roar""";
            InDepthStrategy = @"A powerful ancient monk in search of worthy challengers, Ivon is a formidable challenge even for veteran adventurers.

Spirit Wave: Drop a whirlwind with an AoE Windzone on one random player, typically Ranged DPS or the Healer. Just move out of it. Doesn't last very long.
Hurricane Kick: A short-ranged 270° roundhouse kick AoE, front-facing, leaving a 90° safe-spot for melee. Inflicts Stun for a short time if it hits you.
Touch of Slaughter: Marks one player at random and knocks them down to 1 HP, typically either the Tank or one of the DPS. Rarely directly fatal by itself, but healers should heal the victim up immediately.
Rhalgr's Piece: places a mine that causes AoE damage if triggered, best move away to the outer edge of the platform.
Rose of Destruction: Will mark one player with a large orange crosshair marker, requiring the party to stack to split damage.
Furious Fist: Ivon begins powering up for a super attack, filling the room with glowing chakra orbs that are tethered to him. Collecting the orbs reduces the strength of this attack and will grant you a short-lived stacking Damage Up buff. Once the cast completes, Ivon will float over the center of the arena and punch down around 4-5 times, followed by a finishing Impact strike that does significantly more damage. If all orbs are collected, the first barrage will be around 1,500 damage for each hit, and the final hit will be around 12,000 damage.
Silent Roar: will mark one player and casts a tidalwave towards that player. Getting hit by the wave will knock you back with a chance to fall off
Ivon will also periodically summon glowing white heads that travel across the room, similar to the walls of mummies in The Sunken Temple of Qarn (Hard). These aren't too hard to avoid as they are fairly slow-moving. Later on he'll summon two waves at once, crossing the arena perpendicular to each other.";
        }
    }
}