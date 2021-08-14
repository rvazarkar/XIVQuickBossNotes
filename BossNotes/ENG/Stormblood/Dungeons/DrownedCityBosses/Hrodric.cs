namespace BossNotes.Stormblood.Dungeons.DrownedCityBosses
{
    public class Hrodric : Boss
    {
        public Hrodric()
        {
            Name = "Hrodric Poisontongue";
            QuickStrategy =
                @"Some AoEs don't have ground markers. ""Rusting Claw"" = move behind. ""Tail Drive"" = move to font. Avoid ""Eye of Fire"" gaze attack.";
            InDepthStrategy = @"Rusting Claw Raise Right arm - Move away from front.
Tail Drive Raise Tail - Move away from rear.
The Spin Crouches down for Proximity AoE- Move Away.
Ring of Chaos Selected player move to boss to allow party to move to safe area.
Eye of the Fire Look away from boss to avoid confusion.
Cross of Chaos Cross shaped AoE attack from affected player - stop moving to allow other players to dodge.
Circle of Chaos Circle AoE attack from affected player - Move away from party.
Words of Woe Faces random player for Column attack.";
        }
    }
}