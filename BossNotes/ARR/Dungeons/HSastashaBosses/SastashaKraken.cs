namespace BossNotes.ARR.Dungeons.HSastashaBosses
{
    public class SastashaKraken : Boss
    {
        public SastashaKraken()
        {
            Name = "Kraken";
            QuickStrategy = @"Ignore tentacles. Kraken's Arms > Kraken. Cleanse blind.";
            InDepthStrategy = @"When only Kraken and Tentacles are up, attack Kraken and ignore Tentacles

When Kraken, Tentacles and Kraken's Arms are up, kill Kraken's Arms and ignore Tentacles.

When Kraken and 6 Kraken's Arms are up, just try to survive.

Attack Kraken and Kraken's Arms, ignore Tentacles.
The ink blast AOE attacks are not worth dodging. Healers should remove the Blind they cause before resuming normal healing activities.

Alternative Method: Players should pick an Arm that is near the boss and is in a corner then kill the Arm. Then ranged DPS should hide near the hole in a position that is out of reach of other Arms and DPS the head of Kraken.";
        }
    }
}