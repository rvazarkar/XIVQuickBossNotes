namespace BossNotes.ARR.Dungeons.LostCityBosses
{
    public class DecayingGourmand : Boss
    {
        public DecayingGourmand()
        {
            Name = "Decaying Gourmand";
            QuickStrategy = @"Kill the ""Voracious Jaw"" ASAP when someone gets eaten.";
            InDepthStrategy = @"The Decaying Gourmand will inflict a random player with Prey. The person targeted with prey will get sucked in and eaten by the Decaying Gourmand. When they do, attack the Voracious Maw to break out the person eaten. Decaying Gourmand will also drop AoE circles on the ground that remain there, inflicting damage over time to whoever stays in it.";
        }
    }
}