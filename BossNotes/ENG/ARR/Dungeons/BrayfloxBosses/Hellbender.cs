namespace BossNotes.ARR.Dungeons.BrayfloxBosses
{
    public class Hellbender : Boss
    {
        public Hellbender()
        {
            Name = "Hellbender";
            QuickStrategy = "Kill bubbles when they're put on party members.";
            InDepthStrategy =
                @"During the fight, it will periodically crowd control a party member in a bubble. Kill the bubble quickly and free your teammate. At the end of Hellbender's lifespan, Aiatar, the dragon, flies in and consumes the amphibian. Attack Aiatar until his HP is about 50%, then it will fly away.";
        }
    }
}