namespace BossNotes.Stormblood.Dungeons.HSaintMocianneBosses
{
    public class Nullchu : Boss
    {
        public Nullchu()
        {
            Name = "Nullchu";
            QuickStrategy = @"Stack for ""Fault Warren"". Stand near the boss to avoid AoE on ""Devour""";
            InDepthStrategy = @"Odious Air: A cone that deals damage and inflicts Poison.
Vine Whip: Tankbuster.
Fault Warren: Stack marker on a random player.
Every so often, a non-targetable Rafflesia add will spawn on the edge of the arena with a notification of ""The hall echoes with the twitching of roots and vines"". It will target two random players with markers that create poisonous pools that inflict Leaden while the players stand in them.
            Devour: The Nullchu will leap to the Rafflesia's position and consume it. It will then turn towards the center of the arena and breathe poison, which deals damage every second a player stands in it and also inflicts Poison. The best way to avoid this is to stand near the Rafflesia, as the poison breath casts extremely quickly. Nullchu telegraphs this attack by turning to face the Rafflesia, with a notification of ""The Nullchu has found its next meal!""
            Taproot: All players are targeted with AoEs, spread out to avoid overlapping damage.";
        }
    }
}