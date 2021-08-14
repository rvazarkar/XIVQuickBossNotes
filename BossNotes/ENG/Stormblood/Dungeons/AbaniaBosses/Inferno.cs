namespace BossNotes.Stormblood.Dungeons.AbaniaBosses
{
    public class Inferno : Boss
    {
        public Inferno()
        {
            Name = "Inferno";
            QuickStrategy = "Avoid AoE, run from death claws when they come for you";
            InDepthStrategy = @"Ketu Slash: Tankbuster.
Rahu Blaster: Targeted Column AoE.
Ketu & Rahu: Ground targeted AoE and Player targeted AoE.
Roids: Periodically, Inferno will move to the back of the arena and get showered by the Magitek device there to empower his arms.
Empowered Ketu: Adds a Bleed debuff to the Tank. The second empower adds Vulnerability Up.
Empowered Rahu: Adds a multi-column room-wide AoE and a Proximity AoE. Second empower adds two player targeted AoEs.
Legion Adds: Two 12th Legion Death Claws and one 12th Legion Packer will spawn. The two Death Claws will tether to random players and will incapacitate them should they reach their tethered player. The Packer will slowly move towards the back of the arena and attempt to use Quick Charge on the device. If the Packer is able to complete Quick Charge, Inferno will immediately upgrade his arms further.";
        }
    }
}