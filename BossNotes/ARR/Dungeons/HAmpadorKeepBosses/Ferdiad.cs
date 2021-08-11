namespace BossNotes.ARR.Dungeons.HAmpadorKeepBosses
{
    public class Ferdiad : Boss
    {
        public Ferdiad()
        {
            Name = "Ferdiad";
            QuickStrategy = @"Kill adds ASAP, especially slimes, and move out of AoEs.";
            InDepthStrategy =
                @"Tank should pull to the edge like you would with Titan. This way it is clear when Ferdiad is moving to the center for his circular AoE mechanic.

Kill all adds ASAP, especially the add(s) (Wicked Jester) with a tether to Ferdiad. Ferdiad will channel a circular AoE that gradually becomes larger. You need to kill the tethered adds so that the circle will stop growing and not consume the whole arena. If you fail, his attack will deal massive damage to all players and likely cause a wipe. Tanks and healers should also help down these adds, as Ferdiad will not auto-attack at this time.

Ferdiad will also entrap players in slime adds (Suppuration), which will prevent them from moving, and channel a cleave attack that deals heavy damage. Those not trapped should free this player immediately, who can also (and should) target and DPS the add as well (similar to the bubbles in Brayflox Longstop). Some of the more armored DPS and the tank can survive the hit, but it's best not to chance it.

In the latter half of the fight, there will be blue, spinning scythes that spawn on top of a player. Avoid this once it appears, as there will be no telegraph for it. As the fight goes on, he will summon more, as well as do criss-crossing lines of AoEs that will stretch across the stage (players will find these similar to the Manor Jester in Haukke Manor (Hard)).

In the last leg of the fight, he will combine his two possible adds, entrapping two players with slime adds (who cannot free themselves this time) while tethering itself to another single, stronger add. Depending on who was entrapped, you will need to make decision quickly. In most cases, you will want to down the tethered add immediately, as a casted AoE at full peak will cause a wipe anyway. However, if the two DPS are caught in the Suppurations, you may not have enough DPS to down the tethered add in time, in which case you should free them first (as the slime's health is much lower).

Don't be afraid to use a DPS Limit Break to kill the tethered add if you're rapidly running out of room. This attack should be the last big surprise of the fight.";
        }
    }
}