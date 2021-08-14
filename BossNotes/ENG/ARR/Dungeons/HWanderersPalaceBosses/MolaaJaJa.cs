namespace BossNotes.ARR.Dungeons.HWanderersPalaceBosses
{
    public class MolaaJaJa : Boss
    {
        public MolaaJaJa()
        {
            Name = "Manxome Molaa Ja Ja";
            QuickStrategy =
                @"Kill idols and adds ASAP. Pull boss just outside of standards. Heal to full HP to remove Doom.";
            InDepthStrategy =
                @"Stay very close to him to avoid a huge cone AoE. Move away for rotting gas. Person with rotting lung has to stay away from the party when Rotting Gas pops. The person with the lungs will also AoE around them.

The boss drops multiple banners on the ground during the fight. The banners' buff the boss' damage and armor, so the tank should just pull the boss away from the banner-range. Tank needs to keep moving the boss so the party doesn't have to fight in the banner AoE.

Do not allow the boss to stand in purple circle of Sacred Standard, by kiting him around the outer edge of the boss room.
He will cast debuffs that makes healing worse and Doom random party members. Healers can remove doom by healing the target to full hp. Doom can also be negated by turning around as he casts the spell. Don't face the boss and it doesn't take effect.

When Scared Idol spawns (the Idol with a tether to the boss), kill it ASAP!";
        }
    }
}