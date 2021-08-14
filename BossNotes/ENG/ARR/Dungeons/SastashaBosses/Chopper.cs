namespace BossNotes.ARR.Dungeons.SastashaBosses
{
    public class Chopper : Boss
    {
        public Chopper()
        {
            Name = "Chopper";
            QuickStrategy = "Stay out of Charged Whisker AoE";
            InDepthStrategy =
                @"Once in a while Chopper performs an AoE attack called ""Charged Whisker"" which paralyzes all players around it. A red circle will appear on the ground before it executes the attack. Get out of the circle as soon as possible.";
        }
    }
}