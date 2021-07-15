namespace BossNotes.Stormblood.Dungeons.AbaniaBosses
{
    public class MagnaRoader : Boss
    {
        public MagnaRoader()
        {
            Name = "Magna Roader";
            QuickStrategy = "Kill adds and fire cannons at boss to interrupt his rush.";
            InDepthStrategy = @"Wheel: Tankbuster.
Magitek Fire II: Targeted Circle AoE
Magitek Fire III: Group-wide AoE damage
Wild Speed: Rushes around the room in line patterns. During this attack, two 12th Legion Optio adds will spawn and activate the cannons on the sides of the arena, bombarding random players with avoidable AoEs. Defeat the adds to commandeer their cannons and use its ability on Magna Roader to disrupt this attack. This attack will continue indefinitely until Magna Roader is hit with a cannon shot. Be warned that the Magna Roader cannot be harmed while it is speeding across the arena - wait for it to pause before firing.";
        }
    }
}