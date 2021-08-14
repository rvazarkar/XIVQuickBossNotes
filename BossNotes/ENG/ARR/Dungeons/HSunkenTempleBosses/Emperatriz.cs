namespace BossNotes.ARR.Dungeons.HSunkenTempleBosses
{
    public class Emperatriz : Boss
    {
        public Emperatriz()
        {
            Name = "Sabotender Emperatriz";
            QuickStrategy = @"Kill adds ASAP";
            InDepthStrategy =
                @"Kill the adds throughout the fight. During the fight the boss will attempt to cast 100'000 needles when her health drops low enough. This must be interrupted by dealing enough damage to her, as it will hit everyone for 100'000 damage. On the third and last time a Sabotender Guardia will spawn and cast Cover on her and must be killed first.";
        }
    }
}