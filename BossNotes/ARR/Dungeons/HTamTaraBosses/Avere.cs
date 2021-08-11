namespace BossNotes.ARR.Dungeons.HTamTaraBosses
{
    public class Avere : Boss
    {
        public Avere()
        {
            Name = "Avere Bravearm";
            QuickStrategy = @"Kill crawlers ASAP.";
            InDepthStrategy =
                @"Edda stands in the middle of the room in a circle that causes bleeding. She cannot be targeted and will periodically summon demons outside the arena to execute linear aoe attacks which all seem to converge on the tank.

Avere Bravearm, while the boss, does not have any notable abilities himself.

At certain points during the battle a bunch of crawling zombies similar to the Siren fight will appear from the edges and make their way towards the center of the room. If any of them reach the circle, a rune on the floor will light up. The more runes light up, the stronger the boss's ""Red Wedding"" attack will hit at the end of this.

Do not let crawling zombie adds reach the center of the room. They will spawn at the edge, kill them ASAP!";
        }
    }
}