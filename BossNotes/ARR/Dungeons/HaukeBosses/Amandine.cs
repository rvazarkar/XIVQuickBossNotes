namespace BossNotes.ARR.Dungeons.HaukeBosses
{
    public class Amandine : Boss
    {
        public Amandine()
        {
            Name = "Lady Amandine";
            QuickStrategy = "Click lanterns at edge of room to turn them off. Kill bomb adds ASAP. Don't stand in AoE.";
            InDepthStrategy =
                @"In the boss room, there are 4 lanterns. During the fight, the lanterns will periodically light up, doing AoE damage to the entire party. Players should turn off the lanterns as soon as possible. Lady Amandine will cast Void Fire and Void Thunder. Interrupt her spell cast if possible. Throughout the fight, She will summon Bombs into the room. Kill the bombs asap. If you leave them alone, they will explode after a while. Be sure to get out of the large red circle when the bomb explodes. When Lady Amandine is low on health, she will summon a group of adds and become invincible for a short time. AoE the adds down, use limit breaks if needed.";
        }
    }
}