namespace BossNotes.ARR.Dungeons.HCopperbellBosses
{
    public class Hecatoncheir : Boss
    {
        public Hecatoncheir()
        {
            Name = "Hecatoncheir Mastermind";
            QuickStrategy = @"Kill adds before they reach the flames.";
            InDepthStrategy =
                @"Hecatoncheir Mastermind will use Darkfire every 45 - 60 seconds. The fire will cover a portion of the platform, forcing players to move further down the bridge. Whenever Hecatoncheir uses Darkfire, a Flamebeau (bomb type monster) spawns. The Flamebeau will attempt to move towards the fire. Kill the Flamebeau ASAP. If it reaches the burning ground, it will explode and kill all players. If it is left alone it will self-destruct and wipe the party. Stun the bomb if necessary.

Do not let Flamebeau touch the burning ground cast by the boss.
Kill Flamebeau ASAP or it will explode and insta-kill the entire party.";
        }
    }
}