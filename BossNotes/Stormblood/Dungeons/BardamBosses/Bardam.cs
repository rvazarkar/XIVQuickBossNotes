namespace BossNotes.Stormblood.Dungeons.BardamBosses
{
    public class Bardam : Boss
    {
        public Bardam()
        {
            Name = "Bardam";
            QuickStrategy =
                @"Phase 1: Avoid AoE, avoid gaze attack. Phase 2: Stand in towers to dodge initial attack, avoid AoE. Safe spot behind golems. Phase 3: Avoid AoE. Hide behind Star Shard to dodge meteor when cast is finishing";
            InDepthStrategy = @"Phase 1
Magnetism Pulls all players towards the center of the room.
Travail (shockwave) Occurs immediately after Magnetism. A circle AoE will appear in the center, followed by a circle AoE covering the remainder of the outer arena. Stand just outside the inner AoE facing away from the Hunter of Bardam. Wait for the inner AoE to cast, then immediately walk backwards to avoid the outer AoE. If you use Legacy camera, press all 3 of left strafe, right strafe, and backwards in order to walk backwards, e.g. ASD if using WASD movement.
Spear charge Spears appear along to edge of the map and fire off AoEs that makes the map a chessboard of safe zones.
Empty gaze Empty Gaze will charge while Travail and Spear charges are running. Turn away to dodge it.
Phase 2
Travail (lightning) Lightning attack on the whole party. Stand on prism towers to dodge the attack.
Travail (firestorm) All players are marked and rings of fire drops periodically over their heads. Rings will remain active for a few seconds after dropping. To prevent dropping your AOE onto an ally's escape path, everyone should spread out and run clockwise.
Heavy strike 270 degree front cone. Safe spot is behind the golem.
Star fall Spawns 4 large circular AoEs that leaves behind Star shards to be used in the next phase. Safe spots include the center and the outer edge of the arena.
Phase 3
Looming Shadow Meteor attack with an extremely long cast time. Hide behind Star shard to dodge.
Travial (summon warriors) Breaks the East and West star shards.
Magnetism + Spear charge + Heavy Strike + Shockwave combo The floor is lava. Find safe spot. Will destroy one of the two remaining star shards. After these attacks, the meteor will land. Hide behind the last star shard.
This is a non-combat boss fight. Phases are composed of various mechanics players will have to successfully complete or dodge. Players who fail twice during any phase will receive a fetters debuff until the end of the phase. Debuffs will be cleansed at the end of each phase. At least one player must survive the mechanics to proceed to the next phase. If all players fail the mechanics, you'll be forced to repeat the fight.";
        }
    }
}