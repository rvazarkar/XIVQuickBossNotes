namespace BossNotes.Stormblood.Dungeons.TempleFistBosses
{
    public class CouerlSmriti : Boss
    {
        public CouerlSmriti()
        {
            Name = "Couerl Smriti";
            QuickStrategy = "When add spawns, focus boss and then add. Avoid stacking up during purple markers";
            InDepthStrategy =
                @"Coeurl Smriti is a straight forward Boss. His attack are based on claws and jumping without a marker, though he will also use an AoE around him called Radial Blaster; if you get hit by it, you gain stacks of ""Magical Damage received up"".

            At around 77% he will summon his minion Coeurl Sruti who will claw and jump around like Coeurl Smriti. Instead of Radial Blaster, he uses Windblaster in a cone of aprox 150° in front of him.

                Sruti has health comparable to Smriti, so you should treat this like the Giruveganaus fight in The Stone Vigil (Hard); focus on the wounded Smriti and finish him off, then engage Sruti.

                Around every 20% Coeurl Smriti will cast Electric Blaster, which places purple markers on players. After a short time, there will be an AoE Thunder hit on the marker that applies ""Physical Damage received up"".";
        }
    }
}