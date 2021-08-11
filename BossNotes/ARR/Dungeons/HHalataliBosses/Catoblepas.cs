namespace BossNotes.ARR.Dungeons.HHalataliBosses
{
    public class Catoblepas : Boss
    {
        public Catoblepas()
        {
            Name = "Catoblepas";
            QuickStrategy = @"Assign one person to each pedestal. Click the pedestal when the boss casts ""Demon Eye""";
            InDepthStrategy =
                @"The boss room has four pedestals placed in a square around the edges. Once the battle begins, each pedestal will light up with a Tainted Eye activate-able lever. They're important, make sure you assign one to each party member. Throughout the fight, he will periodically use Demonic Eye, which has a fairly long cast timer. When he starts to cast Demon Eye, each party member has to activate the Tainted Eye to gain a buff called Gloam that prevents you from taking damage.

Catoblepas will also make his eye target-able from time to time. This is a DPS check. It starts out blue, then turns yellow, and then red. When the eye turns red the boss starts stacking damage taken debuffs on the entire party. Lastly, this boss has some rough cone AOEs. It can turn toward a player and cover a good 1/3rd of the arena in a massive cone AOE that can be somewhat hard to dodge if you're directly in the center of it.";
        }
    }
}