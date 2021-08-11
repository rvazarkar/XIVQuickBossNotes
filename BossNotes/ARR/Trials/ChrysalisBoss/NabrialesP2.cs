namespace BossNotes.ARR.Trials.ChrysalisBoss
{
    public class NabrialesP2 : Boss
    {
        public NabrialesP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"At 20%, pop all your buffs and then run into the rift. They will last 10x as long.
Tanks should soak meteors.";
            InDepthStrategy =
                @"He will cast triple and then cast spark three times, again, tanks can taunt to help with this.

After second orb phase he will teleport around and cast end of days, a dodge-able straight line, but the teleports are quite annoying. He will also randomly cast Quake 3, which does AoE damage to party for about 2500 damage on non tanks.

At 20%, he will perform Meteor:

Floor will turn red and give you a bleed. You can run to the edge and keep running while you are sucked in, after the bleed hits 0 you are instantly sucked in. After you are sucked in, you are sent to a new room. Any buffs/debuffs that were affecting you before you were sucked into the vortex will have their duration multiplied by 10. To make the next segment easier, all DPS should use all damage buffs and Tanks should use Hp and Defense buffs.

Meteors fall continuously. If a meteor doesn't land on a player, it deals damage to the entire party, so one player should tank each meteor.

Only tanks (and optionally one healer) should try to get hit by meteors. Only one player needs to be in any particular meteor's landing circle.

Healers may wish to both run to one each time to split the damage. If your tanks applied proper buffs, they should lose less than half their health each meteor.

After the first meteor falls, a tear will appear on its location that you must kill to end the phase. DPS should immediately focus this tear, using a Limit Break if needed. There is a visual tell in the middle of the room, an extremely large meteor that slowly falls and will wipe the party if it manages to hit the ground before the tear is destroyed. Meteors will continue to fall and tanks and healers should continue to run to the next empty meteor zone.";
        }
    }
}