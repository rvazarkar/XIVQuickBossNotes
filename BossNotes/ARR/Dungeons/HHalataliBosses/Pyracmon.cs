namespace BossNotes.ARR.Dungeons.HHalataliBosses
{
    public class Pyracmon : Boss
    {
        public Pyracmon()
        {
            Name = "Pyracmon";
            QuickStrategy = @"When the room glows, hit the button and stand in the shield.";
            InDepthStrategy = @"The fight is similar to The Aurum Vale's Coincounter, with all basic Cyclops abilities (move away when he's casting something with two hands on his mace, run through him when he's casting something with only one hand on his mace). He will use Eye of the Beholder. Avoid his lasers. Throughout the fight, a mechanical Mammet will start marching aimlessly around the room with a tether attaching it to a lever at the back of the room. Interacting with the lever will cause the Mammet to stop and start radiating a blue aura that, after a short pause, will grant the Manawall buff to anyone standing inside it before it fades away about 10 seconds later. The trick is to wait until the cyclops starts charging his 1000 Tonze Swing attack, which will cover the entire arena, and then activate the lever and get the buff before his charge bar fills. The Manawall effect will negate his swing attack, which would likely be lethal otherwise.";
        }
    }
}