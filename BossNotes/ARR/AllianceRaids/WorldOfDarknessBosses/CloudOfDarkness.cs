namespace BossNotes.ARR.AllianceRaids.WorldOfDarknessBosses
{
    public class CloudOfDarkness : Boss
    {
        public CloudOfDarkness()
        {
            Name = "Cloud of Darkness";
            QuickStrategy = @"Keep moving if you get red crosshairs. Never stand in front of the boss.
Kill clouds when they spawn. Move to your marker when lines appear on ground.";
            InDepthStrategy = @"Cloud of Darkness targets the tank with a powerful auto-attack that also deals damage over time, so keep your tank safe.

A random player will get targeted with red crosshairs (Feint Particle Beam). After a few seconds, blasts will start chasing after the target player at running speed damaging anyone nearby. Each blast adds a Vulnerability Up debuff and it kills you quickly if you stop moving. The player targeted should run towards the outside edge of the area, away from all other players.

Any time she moves around the ring, she fires a massive laser (Zero-form Particle Beam) through the center of the area. When she disappears, immediately move to the sides. This attack will give a vulnerability debuff.

Throughout the fight, she will spawn comets on yellow circle markers. At least one person should stand in each one before the comet reaches the ground or the raid suffers moderate damage (several empty comets will wipe the raid). The person in the comet area will take a small hit.

Mid-fight, the floor of the area will light up and cloud and storm adds will start spawning. Kill them before they get close enough for the boss to eat them, or she will wipe you if she eats enough. The clouds can be affected by Heavy but not by Bind. If anyone stands between the clouds and CoD, it will add the Heavy effect to them. After the cloud phase is done she will do a raid-wide attack.

Next, she will spawn 3 clouds in a triangle formation. These clouds have a box shaped outline around them and cannot be damaged outside the box after a few seconds, so move into one of the boxes and kill the clouds. A, B, and C should have their own cloud and this should be marked ahead of time.

If your raid DPS is very low, worm adds will spawn around the area before the cloud phase. Hitting them once or twice causes them to disappear. The worms add many debuffs like Morbol's Bad Breath to anyone standing too close to them. Stay away and let the ranged DPS handle.";
        }
    }
}