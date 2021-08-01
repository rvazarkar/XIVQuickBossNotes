namespace BossNotes.ARR.Dungeons.AmpadorBosses
{
    public class DemonWall : Boss
    {
        public DemonWall()
        {
            Name = "Demon Wall";
            QuickStrategy = @"Dodge pattern is Side -> Middle -> Side -> Middle -> Middle.
Kill adds when they spawn.";
            InDepthStrategy = @"Demon Wall will use his abilities in a pattern. He will first use Liquefy (Middle), followed by Liquefy (Sides). After two rotations of these abilities, Demon Wall will use Repel. Places should move to the edges of the platform when Demon Wall uses Liquefy (Middle), dark column in the center of the room. Players should move to the center when Demon Wall uses Liquefy (Sides), dark columns in the left and right sides of the room. When the Demon Wall uses Repel, players should be in the center of the boss room to avoid being thrown off the platform.

Liquefy (Middle) -> Liquefy (Sides) -> Liquefy (Middle) -> Liquefy (Sides) -> Repel
After Demon Wall uses 2nd Repel, a dark pool spawns in the back of the platform. Avoid the dark pool if possible. He will also summon 2 adds named Bloodlapper. Bloodlapper can paralyze players with AoE spells. Interrupt their casting of Thunderstorm and kill them as soon as possible.

Abilities

Murder Hole is an instant ability that deals a small amount of damage to a random player.
Repel is an ability that knocks all players back and deals a moderate amount of damage.
Liquefy (Middle) is an ability that spawns a long black column in the middle of the boss room. It will do a large amount of damage and inflict the debuff Heavy to all players hit.
Liquefy (Sides) is an ability that spawns two long black columns at the sides of the boss room. It will do a large amount of damage and inflict the debuff Slow to all players hit.
Adds

Bloodlapper has an ability named Thunderstorm. Thunderstorm is a circular AoE spell that inflicts the debuff Paralysis to all targets caught within. The spell should be interrupted with a stun because it is difficult to avoid the ground indicator.";
        }
    }
}