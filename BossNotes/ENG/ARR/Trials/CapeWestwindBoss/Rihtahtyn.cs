namespace BossNotes.ARR.Trials.CapeWestwindBoss
{
    public class Rihtahtyn : Boss
    {
        public Rihtahtyn()
        {
            Name = "Rihtahtyn sas Arvina";
            QuickStrategy = @"Mostly just tank and spank. Offtank should pick up adds.";
            InDepthStrategy =
                @"Rihtahtyn sas Arvina is the hulking, armored Roegadyn general of Garlean Empire. He has two shields, one on each of his arm.

Throughout the fight, Rihtahtyn will spawn flaming circles on the ground. Players standing in the circles will take damage over time. Avoid these circles if possible. He will charge up magitek missiles. Players can avoid these missiles by moving away from where the boss is standing.

At around 2/3 HP, he will spawn 2 adds at the doorway. One of the tanks should take the aggro of these adds.";
        }
    }
}