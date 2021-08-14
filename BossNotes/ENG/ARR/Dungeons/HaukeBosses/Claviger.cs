namespace BossNotes.ARR.Dungeons.HaukeBosses
{
    public class Claviger : Boss
    {
        public Claviger()
        {
            Name = "Manor Claviger";
            QuickStrategy = "Avoid AoE, kill the boss";
            InDepthStrategy =
                @"Manor Claviger has a melee cleaver attack. The attack can do massive physical damage to lightly armored party members. Make sure your tanks have her attention. Claviger can cast Void Fire II, a ranged AoE spell. Throughout the fight, a large red circle will appear underneath the feet of party members. Move out of the circle as soon as possible.";
        }
    }
}