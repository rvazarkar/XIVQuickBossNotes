namespace BossNotes.Stormblood.Dungeons.BardamBosses
{
    public class Garula : Boss
    {
        public Garula()
        {
            Name = "Garula";
            QuickStrategy = "When targetted by Rush, run as far away as you can. Other players should avoid the path.";
            InDepthStrategy = @"Heave Frontal cone AOE. Tank to dodge as required.
Crumbling Crust After a short cast time, 4 telegraphed quick casting AoEs appears around Galura. Deals moderate damage, but AoEs can stack. Melees to dodge as required.
Rush Galura will mark an off-aggro target and channel a straight line charge. Marked players should distances themselves from Galura to reduce damage taken. Other players should move out of Galura's path.
Earthquake Occurs immediately after Rush, stunning all players. Animals marked with a '!' symbol in the pen will begin charging up their AoE attacks. The type of animal determines the type of attack that will occur. Galura does this three times in his fight.
Ram: Straight line AoE. Appears in all 3 phases.
Coeurl: Large frontal cone AoE. Appears after the second time Rush is used.
Kukurul: Small circle AoE. Appears after the third time Rush is used.";
        }
    }
}