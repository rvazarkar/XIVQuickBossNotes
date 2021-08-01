namespace BossNotes.ARR.Dungeons.HBrayfloxBosses
{
    public class IlluminatiCommander : Boss
    {
        public IlluminatiCommander()
        {
            Name = "Illuminati Commander";
            QuickStrategy = @"Dodge AoEs, they hurt.";
            InDepthStrategy = @"Illuminati Commander will spawn sniper add that will fixate on a player, does damage for around 600HP, through the battle, several vertical and horizontal AoE attacks will cover the arena, these will get harder as the battle progresses.";
        }
    }
}