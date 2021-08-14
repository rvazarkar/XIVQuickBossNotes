namespace BossNotes.Stormblood.Dungeons.SwallowsCompassBosses
{
    public class QitianDasheng : Boss
    {
        public QitianDasheng()
        {
            Name = "";
            QuickStrategy = @"Normal Staff = Move Out. Glowing Staff = move in. Kill adds when they spawn.
Clones need to be killed at the same time. Tethered players should face the boss away.";
            InDepthStrategy = @"The Short End: Tankbuster.
Both Ends: This ability has two flavours.
The first will be signified by the normal weapon, raised. It will create a medium AOE around Qitian Dasheng. Getting hit by this AOE will knock the player back into the bluish outer ring. This debuff area will apply Bleeding and one (1) stack of Vulnerability Up.
The second will be signified by an enlarged weapon with electric current on it, lowered. It will do the same, but with a save zone near Qitian Dasheng.
In short: Normal weapon - stay away from the boss. Enlarged, electrified weapon - stay near the boss.
Mount Huaguo: Area wide medium AOE.
Monkey Magicks: ADD phase. Kill all Servant of the Sage before the Monkey Magicks meter is fully charged.
Second Heaven: Ultimate, after Monkey Magicks meter is fully charged or all Servant of the Sage are killed. The amount of damage done depends on the level of the charge of the Monkey Magicks meter.
Splitting Hairs: Qitian Dasheng splits in two Shadow of the Sage. Both mobs must be killed to end the fight. If only one is killed, the remaining will split again. It is suggested to damage both equally and kill them in very short succession, so a to avoid another split.
ADD

Servant of the Sage: Spawn during Monkey Magicks phase. Frequently use an AOE.
Shadow of the Sage: Two lesser copies of Qitian Dasheng. Both must be killed. Both retain the abilities or the original Qitian Dasheng. Note, that those copies share the health pool of the original Qitian Dasheng. That is, the health of the copies will drop according to the damage dealt.";
        }
    }
}