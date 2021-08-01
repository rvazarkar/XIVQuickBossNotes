namespace BossNotes.ARR.Dungeons.AmpadorBosses
{
    public class Psycheflayer : Boss
    {
        public Psycheflayer()
        {
            Name = "Psycheflayer";
            QuickStrategy = @"Burn the first enemy before focusing boss.
Kill ""Stone Marionette"" and ""Marble Marionette"" as fast as possible.";
            InDepthStrategy = @"At first only the Lunatic Priest is available. It has a circular AoE spell named Void Fire II that players should avoid. At around half HP, he will summon the Psycheflayer. Burst down the Lunatic Priest while the tank pulls the Psycheflayer to the far right side of the room, near the lantern.

Players should attempt to interrupt Void Fire III with stuns and avoid Void Fire II by moving out of the ground indicator. White Mages should remove the disease debuffs with esuna if possible.

Psycheflayer will spawn Stone Marionette and Marble Marionette throughout the fight. Be sure to kill them as soon as they spawn. Players should avoid Stone Marionette's frontal column AoE ability and interrupt Marble Marionette's Obliterate spell.

At around half HP, Psycheflayer will summon the Megalith Marionette. The giant golem will slowly walk around the boss room and cast Plaincracker, the giant circular AoE ability, occasionally. When you are positioned at the right side of the room, near the lantern, you can easily avoid Plaincracker by hugging the right wall. Players should ignore Megalith Marionette and keep their focus on the Psycheflayer.

Abilities

Water is a spell that deals a small amount of damage to a player.
Void Thunder III is a spell that deals a large amount of damage to a player.
Canker is a spell that deals the debuff disease on a random player.
Mind Melt is an instant ability that deals a moderate amount of damage to all players near Psycheflayer.
Adds

Lunatic Priest is the add that summons Psycheflayer. Players should dodge his circular AoE spell named Void Fire II. At around half HP, He summons the Psycheflayer.
Stone Marionette has a frontal column AoE ability named Rockslide. It deals heavy damage to all players hit.
Marble Marionette has a spell named Obliterate that deals a moderate amount of damage to all players nearby.
Megalith Marionette has a very large circular AoE attack that centers around itself. The attack, named Plaincracker, deals massive amount of damage to all players hit.";
        }
    }
}