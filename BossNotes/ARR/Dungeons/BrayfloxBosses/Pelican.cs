namespace BossNotes.ARR.Dungeons.BrayfloxBosses
{
    public class Pelican : Boss
    {
        public Pelican()
        {
            Name = "Great Yellow Pelican";
            QuickStrategy = "Kill adds and then kill boss";
            InDepthStrategy =
                @"Great Yellow Pelican is a giant bird and the first boss of Brayflox's Longstop. During the fight, Pelican will summon small birds called Violet Back. Kill the birds quickly before they overwhelm the party. Additionally, the Pelican can poison the tank.";
        }
    }
}