namespace BossNotes.Stormblood.Dungeons.GhimlytBosses
{
    public class Prometheus : Boss
    {
        public Prometheus()
        {
            Name = "Prometheus";
            QuickStrategy = @"When boss burrows, move out of the way of the red wall.";
            InDepthStrategy =
                @"Nitrospin: Moderate damage on the entire party. Prometheus always casts this ability first, surrounding the arena in fire.
Unbreakable Cermet Drill: Tankbuster.
Needle Gun: 90 degree Cone directly in front of the boss.
Oil Shower: 270 degree Cone directly behind the boss, hitting everywhere Needle Gun doesn't.
After a few attacks, Prometheus will burrow underground and a section of the wall surrounding the arena will glow red. After a delay, a fiery blast will launch from the red area to the opposite wall, dealing damage. The attack lingers, continuing to deal damage for a few seconds. The second time Prometheus uses this attack, it will first cast Freezing Missile.
Freezing Missile: Four proximity AoEs that hit at each cardinal direction.";
        }
    }
}