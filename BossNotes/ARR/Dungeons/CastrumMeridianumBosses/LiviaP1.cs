namespace BossNotes.ARR.Dungeons.CastrumMeridianumBosses
{
    public class LiviaP1 : Boss
    {
        public LiviaP1()
        {
            Name = "Livia sas Junius (Phase 1)";
            QuickStrategy = @"Load the cannons with the loader, shoot the boss with the cannons.
If you get aggro, MOVE TO TO MIDDLE AND TANK. Tank's cannot hold aggro.";
            InDepthStrategy = @"In this fight, players have to defeat Livia sas Junius in her Magitek Armor. In the boss room, there are Mark XLIII Artillery Cannons with Magitek Missle piles near them. When players click on these cannons, Magitek Loaders will load the cannons with missiles. Players can fire the cannons to do 3000 damage to Livia. One of the tanks should fire the cannons because the act draws the aggro of the boss. Tanks should tank Livia in the center of the room, away from the cannons, because Livia's cleave attacks could damage and destroy them.
The cannons are controlled by a skill bar change. Click on the ammo pile to cause the claw to load the cannon nearby, then click on the cannon, and use the ability on the temporary skill bar to aim the cannon at Livia and fire it.

She will spawn adds throughout the fight. One of the tanks should take their aggro and prevent them from destroying the cannons.
Abilities
Photon Stream is an instant frontal attack that deals a small amount of damage
Magitek Cannon is a large circular AoE attack that targets a random player. It deals heavy damage to all players caught in the AoE.";
        }
    }
}