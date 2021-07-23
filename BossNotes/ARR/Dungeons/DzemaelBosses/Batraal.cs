namespace BossNotes.ARR.Dungeons.DzemaelBosses
{
    public class Batraal : Boss
    {
        public Batraal()
        {
            Name = "Batraal";
            QuickStrategy = @"Kill crystals when the boss is tethered to them.";
            InDepthStrategy = @"Batraal is the final boss of Dzemael Darkhold. This demon has an instant frontal AoE cone attack that deals heavy damage to all targets hit. Be sure to have only the tank face the boss. He has has a long ranged AoE column attack named Desolation that does extremely high damage and will instantly kill most players.

Throughout the fight, a purple beam will appear between Batraal and a crystal. Batraal will mark a player with a crosshair and fires Desolation at the target. While Batraal is connected to the crystal, he is invulnerable. Be sure to kill the crystal as soon as possible while dodging Desolations. The player who was targeted should avoid aiming the Desolations at the rest of the party.

At around 30% HP and after the 3rd crystal is destroyed, Batraal will use Hellssend and become enraged. He will start using Desolation at will. Batraal will also spawn black pools under 3 players. Players within the pool will take damage over time. Move out of them immediately. The puddles will occasionally explode and deal high damage to anyone standing in them.

Avoid Desolation at all cost, since it will instantly kill most players
If you are targeted, don't point Desolation at the rest of the party
Kill crystals when they appear.
Abilities

Grim Fate is an instant frontal attack that deals heavy damage to a single player.
Grim Cleaver is an instant ranged attack that deals moderate amount of damage to a random player.
Grim Halo is an instant attack that deals moderate amount of damage to all players around him.
Desolation is an frontal AoE column that deals very heavy damage to all players caught within.";
        }
    }
}