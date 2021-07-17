namespace BossNotes.Stormblood.Dungeons.HSaintMocianneBosses
{
    public class Lakhamu : Boss
    {
        public Lakhamu()
        {
            Name = "Lakhamu";
            QuickStrategy = @"Avoid the edges of the arena.
Try to end up in safe areas after conveyor belts. Earthquake hits close and then far. Avoid ""Empty Gaze"" by turning away from boss.";
            InDepthStrategy = @"When the fight begins, the edges of the arena will be coated in thorny vines, damaging players who come in contact with them as well as inflicting a stack of Vulnerability Up.

Stone II: Tankbuster.
Tectonics: Party-wide damage.
Landslip: The arena is covered in four ""conveyor belt"" line markers, and a few Silt Golem adds will spawn on the outside of the arena. When the cast completes, all players will be pushed in the direction of the arrows a distance roughly equivalent to half the arena. As players are being pushed, the Silt Golems will cast Rockslide, damaging in a line ahead of them and inflicting Vulnerability Up.
            Players should do their best to be pushed into a safe area, as there's little time to avoid Rockslide after being pushed.
                Earthquake: Melee-range area of effect followed immediately by a ring area of effect. Move to melee range or far range to dodge.
                Earth Shaker: Marks the two DPS players, dealing damage in a line from the boss to the player.
                Empty Gaze: Gaze attack that inflicts Hysteria.";
        }
    }
}