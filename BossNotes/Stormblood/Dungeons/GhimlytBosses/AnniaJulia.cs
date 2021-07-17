namespace BossNotes.Stormblood.Dungeons.GhimlytBosses
{
    public class AnniaJulia : Boss
    {
        public AnniaJulia()
        {
            Name = "Annia and Julia quo Soranus";
            QuickStrategy = @"Avoid AoE, bombs will explode in a chain reaction from the one the boss targets.";
            InDepthStrategy =
                @"As the battle begins, whichever sister was attacked first will remain in the arena, while the other will support from outside the arena, untargetable. Annia utilizes a fist weapon, while Julia has a gunblade.

Delta Trance: Annia's tankbuster.
Innocence: Julia's tankbuster.
Artificial Plasma: Used by both sisters. Deals moderate damage to the entire party.
Commence Air Strike: Used by Julia. Eight Ceruleum tanks will drop from the sky, four on the outer edge, and four inside. Occasionally, Julia will use Roundhouse to knock the tanks around, with the added effect of dealing damage to and knocking back players in melee range. Regardless of if she uses Roundhouse or not, she will then follow up with Heirsbane targeting a tank to detonate it, dealing damage in a large area around the tank and causing all other tanks in the radius to also detonate.
Order to Bombard: Used by Annia. Three large AoEs will cover the arena, leaving small safe spots at the edge of the arena, while Julia and Annia perform Crossbones and Angry Salamander
Crossbones: Used by Julia. Carving four ""X""es into the air that travel across the arena to deal damage. When used as part of Order to Bombard, each X unerringly targets a player and inflicts knockback when it hits.
Heirsbane: Used by Julia. Marks a random player with a crosshair, then deals moderate damage to the target a short time after.
Angry Salamander: Used by Annia. A Line attack in the direction of a random player.
Stunning Sweep: Used by Annia. She jumps to a random player, then begins casting. Deals damage to players in melee range.
The Order: Used by Julia. Julia moves to the center of the arena and surrounds herself with four Crossbones projectiles. Ground AoEs will appear beneath each player, while the Crossbones launch in a cross pattern.
After the first sister is defeated, the two will perform Crosshatch, launching a Crossbones projectile back and forth across the arena, their path denoted by very narrow lines appearing. After this attack, the two will tag out and the fight will continue.
When the other sister is defeated, they will perform Crosshatch again with the addition of Covering Fire, an AoE targeting each player that requires the party spread out to avoid overlap.
Once the second cast of Crosshatch is complete, the two will regain 20% of their HP and begin casting Imperial Authority at the center of the arena. This attack will wipe the party if either is allowed to finish casting.";
        }
    }
}