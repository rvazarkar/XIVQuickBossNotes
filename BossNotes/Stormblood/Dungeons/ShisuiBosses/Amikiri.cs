namespace BossNotes.Stormblood.Dungeons.ShisuiBosses
{
    public class Amikiri : Boss
    {
        public Amikiri()
        {
            Name = "Amikiri";
            QuickStrategy = "Kill boss's leg when it uses Shuck to free trapped player. Kill adds ASAP";
            InDepthStrategy = @"This is, for the most part, a tank-and-spank fight.
The boss will use Sharpstrike on its primary target, which deals a moderate amount of damage. Cooldown and heal as necessary.
The boss will periodically target a single player and drop a puddle AoE under them, immobilizing the target and any other player near them. The boss will immediately move to the stunned target and begin to cast Shuck which will usually kill the target.
While the boss is casting Shuck, one of the boss's legs will become targetable. Destroying the leg interrupts the cast of Shuck, and also sends the boss tumbling onto its back for a few seconds, preventing it from performing any actions and inflicting Vulnerability Up.
Periodically, a Kamikiri add will spawn and the three non-tank players will be marked for Digest. If Kamikiri spawns while Amikiri is casting Shuck, Digest instead targets the three players not targeted by Shuck. The attack leaves a water puddle under each target, which inflicts Dropsy as long as a player stands in it.
If the Kamikiri add is slain before Digest's cast completes, the cast is interrupted.";
        }
    }
}