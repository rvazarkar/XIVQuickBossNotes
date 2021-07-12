namespace BossNotes.ARR.Dungeons.SastashaBosses
{
    public class Denn : Boss
    {
        public Denn()
        {
            Name = "Denn the Orcatoothed";
            QuickStrategy = "Interact with grates to stop adds from spawning.";
            InDepthStrategy =
                @"The boss room features 4 grates with bubbling water at each corner of the room. 
                During the boss fight, adds will spawn from the bubbling water. 
                Players can interact with the grate when it's bubbling to prevent an add from spawning. To this extent, casters should position themselves to be in range to cast, while still able to quickly interact with the grates when they bubble. 
                
                Should adds spawn, try to keep their numbers down to prevent the tank from being overwhelmed. 

                If a caster is targeted by the adds, they should run to the tank so that the tank can remove hate while staying by the boss.";
        }
    }
}