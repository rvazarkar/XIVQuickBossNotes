namespace BossNotes.Stormblood.Dungeons.ShisuiBosses
{
    public class ShisuiYohi : Boss
    {
        public ShisuiYohi()
        {
            Name = "Shisui Yohi";
            QuickStrategy =
                @"Kill adds. When arena goes dark, look for ripples on the ground and avoid them. Avoid ""Mad Stare"" gaze attack, kill sharks ASAP.";
            InDepthStrategy =
                @"The boss will use Foul Nail on its primary target, which does two attacks for moderate damage. Cooldown and heal as necessary.
Shisui Yohi will cast Thick Fog, dealing group-wide damage, filling the arena with water and hiding the boss. Three Churn enemies (bubble adds) will spawn, each applying a stacking Dropsy debuff until they are killed. When all three Churns have been killed, Shisui Yohi will re-enter the battlefield.
During the Thick Fog phase the boss will move around the arena, look for a large mass of churning ripples. Standing in these bubbles will damage the player. The boss will re-emerge from these ripples.
When the boss re-enters the arena after the Churns are destroyed, it will instantly cast Black Tide which will deal a moderate amount damage to any player standing near it and debuff any player hit with Vulnerability Up. Players should pay attention to the location of the ripples and avoid standing in that area of the arena.
Periodically the boss will summon two Shark adds, Naishi-no-jo and Naishi-no-Kami, which lock onto a specific player with a line AoE, Bite and Run which will do large amounts of damage will follow the targeted player. These should be killed ASAP, before they can execute their rush attack. The Naishi-no-jo is weaker, and will target a random DPS. The Naishi-no-Kami is stronger and targets the healer, but will take longer to complete its cast.
After summoning the shark adds, the boss will cast Mad Stare, a gaze attack which will debuff affected players with Hysteria, making them uncontrollable and wander the arena. Turn away before the cast finishes to avoid the attack.
Note that if the Shark adds are still up when the boss enters the next Thick Fog phase, they will be hidden and untargetable, but still perform their rush attacks. This can cause large damage spikes unexpectedly and can lead to wipes.";
        }
    }
}