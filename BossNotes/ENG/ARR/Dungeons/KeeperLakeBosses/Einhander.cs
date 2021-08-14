namespace BossNotes.ARR.Dungeons.KeeperLakeBosses
{
    public class Einhander : Boss
    {
        public Einhander()
        {
            Name = "Einhander";
            QuickStrategy = @"Knock small canisters away to create safe zone. Don't let the boss AoE canisters.";
            InDepthStrategy =
                @"The flying enemies will drop big and small canisters to the boss-area. Any partymember can hit the small canisters away from the boss and the rest of the party. The big canisters will stay still. The boss does AoE-breaths that ignite the canisters it hits and those canisters will explode after burning for a while. Small canisters do damage to nearby targets, but big canisters deal moderate damage to the whole party. Usually party can deal with 1 big canister exploding, but two can be fatal so you may want to have Einhander use his abilities to trigger the affect of each medium canister as it spawns and allow your healer to heal through the damage (DPS might be able to destroy the big canisters before they explode, not sure). Medium canister explosions will chain into each other, so if your room has more than one medium canister up as one is trigger, expect a wipe.

Occasionally, Einhander will suck all of the canisters in the room towards him, the tank should either reposition Einhander away from the canisters or the DPS should quickly knock them away again.";
        }
    }
}