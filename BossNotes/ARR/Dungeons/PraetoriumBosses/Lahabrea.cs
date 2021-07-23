namespace BossNotes.ARR.Dungeons.PraetoriumBosses
{
    public class Lahabrea : Boss
    {
        public Lahabrea()
        {
            Name = "Lahabrea";
            QuickStrategy = @"Just kill him.";
            InDepthStrategy = @"Lahabrea is a straight forward fight. Players should avoid the dark pools spawned by Sea of Pitch if possible. He will also cast Shadow Flare, which players can interrupt.

Abilities

Dark Orb is an instant spell that deals a small amount of damage to a random player.
Grip of Night is an instant ability that deals a small amount of damage to all players near Lahabrea.
Sea of Pitch is an ability that spawns 4 dark circles in the boss room. Moving over the circles will cause an explosion that deals a moderate amount of damage to all players caught.
Shadow Flare is an ability that deals a moderate amount of damage to all players.";
        }
    }
}