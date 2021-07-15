namespace BossNotes.Stormblood.Dungeons.SirensongBosses
{
    public class Lugat : Boss
    {
        public Lugat()
        {
            Name = "Lugat";
            QuickStrategy =
                "Stay close to boss to dodge AoE. Stack to split Hydroball. When pulled to the middle be prepared to run out. If pushed to edge, be prepared to run in.";
            InDepthStrategy = @"Try to stay near this boss - it will help you avoid his half-screen AOEs.

Amorphous Applause: Large directional AOE. Stay tight to the boss so you have a chance to dodge.
Hydroball: One party member is targeted. Stack to split the damage.
Sea Swallows All -> Concussive Oscillation: When the boss sucks you in, be prepared to run out. Several AOEs will go down. Find a safe spot, but head back in to the center after so you can dodge the Amorphous Applause that follows.
Overflow -> Hydroball: Everyone is knocked to the arena edge; run back to the middle ASAP. Hydroball is coming, and you'll want to stack up.";
        }
    }
}