namespace BossNotes.Stormblood.Dungeons.DrownedCityBosses
{
    public class OldOne : Boss
    {
        public OldOne()
        {
            Name = "The Old One";
            QuickStrategy = @"Kill adds ASAP. Spriggan ability is spammable.";
            InDepthStrategy = @"Mystic Light Large Frontal Cone on random player.
Mystic Flame Large Circle AoE under random players.
Shifting Light Turns Players into Spriggans with Action ability.
Round 1: Spawns 4 adds that must be destroyed ASAP to avoid self destruct. Round 2: Spawns 6 adds that must be destroyed using your Spriggan action ability to destroy adds. Spam action as necessary.";
        }
    }
}