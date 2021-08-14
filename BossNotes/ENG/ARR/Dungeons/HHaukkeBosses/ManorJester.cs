namespace BossNotes.ARR.Dungeons.HHaukkeBosses
{
    public class ManorJester : Boss
    {
        public ManorJester()
        {
            Name = "Manor Jester";
            QuickStrategy = @"Healers should cleanse Slow. Kill Steward and adds ASAP.";
            InDepthStrategy =
                @"Manor Jester will cast Void Blizzard. The spell will not only damage players but also applies the debuff Slow. Healers should remove the debuff with spells such as esuna. Additionally, players should kill the adds that spawn and avoid the AoE ice patches spawned by the boss.";
        }
    }
}