namespace BossNotes.ARR.Dungeons.BrayfloxBosses
{
    public class Aiatar : Boss
    {
        public Aiatar()
        {
            Name = "Aiatar";
            QuickStrategy = "Avoid puddles, and move boss out of puddles or he heals. Healers can cleanse poison";
            InDepthStrategy =
                @"Aiatar has an AoE cone attack that happens fairly quickly and should be avoided by the squishier members of the party. During the fight, the dragon will spit green poisonous goo at members of the party, dealing a moderate amount of damage. The goo leaves a green puddle on the ground which not only poisons anyone standing in it, but also heals the dragon. Get out of the puddle quickly. Tank should make sure that Aiatar is not standing in the puddle and getting healed.

Conjurers and Scholars can use Esuna to cure poison from any party member.
Once Aiatar targets a player for the goo, they can position the poisonous goo. Pick a place to put all of the goo, it will be easy to avoid all the goo if they are all in one place.";
        }
    }
}