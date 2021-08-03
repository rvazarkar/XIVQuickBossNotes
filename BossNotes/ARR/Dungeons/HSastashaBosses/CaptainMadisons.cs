namespace BossNotes.ARR.Dungeons.HSastashaBosses
{
    public class CaptainMadisons : Boss
    {
        public CaptainMadisons()
        {
            Name = "Captain Madisons";
            QuickStrategy = @"Kill adds ASAP and focus boss when he focuses a player.";
            InDepthStrategy = @"Kill the adds as soon as they spawn because they are quite weak. After Captain Madison charges a player and knocking them back. He immediately marks a random player and starts shooting at them with his gun. He will keep shooting until enough damage is dealt to him. He cannot be stunned while firing. At very low HP, Captain Madison will spawn a bunch of adds then run away.

Players should gather in the center of the boss room for the 3rd set and the 4th set (final set) of adds then AoE them down. Use caster Limit Break on the 3rd set if needed.

DUMP DPS on him after he charges someone and starts shooting because he will keep shooting until enough damage is dealt.";
        }
    }
}