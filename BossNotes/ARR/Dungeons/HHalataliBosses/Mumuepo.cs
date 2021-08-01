namespace BossNotes.ARR.Dungeons.HHalataliBosses
{
    public class Mumuepo : Boss
    {
        public Mumuepo()
        {
            Name = "Mumuepo the Beholden";
            QuickStrategy = @"Order is Healer > Lancer > Archer > Gladiator > Lala.
Kill mage while tank picks up big add. Use Scepter to free frozen people.";
            InDepthStrategy = @"The final boss is a series of battles. It starts with four combatants that will try to break apart your party. The Lancer seems to have no aggro table and will target someone randomly (he chose me as a Bard on our run), so just kite him around at first. There's a healer which obviously should die first. The Bard should probably die third, followed by the Gladiator. Keep in mind that these characters appear to have level 50 abilities appropriate to their job, so expect the Gladiator to be using Spirits Within and such. Overall, this section was pretty easy.

The second phase starts after the trash people are killed off. A red demon and a little Lalafell named Mumepo the Beholden show up. Tank should pick up both of them. Kill Mumoepo first because he casts more and chains players in place before starting a massive AOE with a slow cast bar (Thal's Fury or somesuch). The remaining unchained person needs to save them by finding the ""Thal's Scepter"" interactive lever in the AoE to unchain their party members before the cast finishes so the chained players can escape. The damage is pretty severe if this fails (it was doing upwards of 1/2 to 3/4 of our WHM health bar). Once Mumoepo goes down, the rest of the fight is unremarkable. The red demon thing has a rear tail swipe, so keep that in mind if you're melee, and ranged will have to deal with a targeted AoE circle randomly at their location.";
        }
    }
}