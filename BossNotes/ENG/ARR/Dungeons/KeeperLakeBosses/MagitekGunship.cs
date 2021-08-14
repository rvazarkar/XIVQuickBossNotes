namespace BossNotes.ARR.Dungeons.KeeperLakeBosses
{
    public class MagitekGunship : Boss
    {
        public MagitekGunship()
        {
            Name = "Magitek Gunship";
            QuickStrategy =
                @"Kill adds. Stay behind boss for flamethrower. When targetted, move to the edge of the arena.";
            InDepthStrategy =
                @"The boss will summon adds two times. First time he summons 4 cohorts and second time he summons a big robot. All of the adds should be killed. The Gunship has a Flamethrower attack that comes out in a cone infront of him and remains active for a few seconds, so tanks should be mindful not to move back into it too early. Sometimes the boss will target a random party member and fly to the edge of the arena. After a while, he will charge towards the party member, dropping fiery circular AoE's on the ground. Party member who is targeted should stay near the edge of the arena, so that the AoE doesn't cover the middle of the fight. As the fight continues, the boss will charge two party members in a row.";
        }
    }
}