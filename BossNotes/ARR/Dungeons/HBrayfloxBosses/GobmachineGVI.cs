namespace BossNotes.ARR.Dungeons.HBrayfloxBosses
{
    public class GobmachineGVI : Boss
    {
        public GobmachineGVI()
        {
            Name = "Gobmachine G-VI";
            QuickStrategy = @"Knock bombs away from the center to create a safe zone. Destroy big bomb.";
            InDepthStrategy = @"The machine itself doesn't have many attacks, a straight forward flamethrower attack with no AoE cone, and a Bombardment Circle-AoE attack that'll target a random player.

At around 75% HP, the boss will start circling the room's outer perimeter and become un-targetable. The party needs to immediately gather in the center of the room to avoid the circling tank. Two Illuminati adds will spawn, one of which is tethered to a party member.A few seconds later, it will launch a massive amount of bombs that cover the entire area. These can be knocked away with attacks and should be moved away from the center with AoE attacks quickly before they explode. Afterwards the boss will stop and becomes targetable again.

This will repeat twice more at 50% and 25%, but in the latter case it will be followed up with a Big Bomb, which must be killed quickly. The boss will also try to ram into players at this point.";
        }
    }
}