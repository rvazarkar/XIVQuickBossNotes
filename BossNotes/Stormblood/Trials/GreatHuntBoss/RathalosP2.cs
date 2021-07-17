namespace BossNotes.Stormblood.Trials.GreatHuntBoss
{
    public class RathalosP2 : Boss
    {
        public RathalosP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Coeurl should be killed ASAP.
Rathalos can damage adds in this phase and vice versa.
Tank must pick up Garula and a DPS needs to mount Rathalos and spam the active time maneuver.
Stand behind the Garula corpse to avoid ""King of the Skies""";
            InDepthStrategy = @"For the most part, phase two is almost identical to phase one, except now the party must contend with some of the local wildlife joining the fray. On entering the arena, various types of adds will initially begin attacking Rathalos, all with their own AoE attacks. Unlike Rathalos, however, these adds are effected by enmity and can be tanked. It is worth noting that Rathalos' attacks will also damage these adds (and vice-versa); thus a good method is to grab all the stray adds and tank them close to Rathalos so that they damage each other until all adds are defeated. The Coeurl is the most problematic as it will occasionally use a massive conal AoE that can cover a large portion of the arena, thus it is wise to focus on this add first whenever possible, or at least turn it away from the party.

After being reduced to around 70% health, Rathalos will head towards the centre of the arena and inflict a roaring stun on the party. Simultaneously, a large Garula will enter the arena from the east side and charge into Rathalos after a short wind-up animation, knocking him down and damaging any players caught in the path. From here, the Garula will begin attacking the party and must be picked up by a tank as soon as possible. At the same time, Rathalos will become mountable, prompting a player to leap onto his back and repeatedly stab him via an active time event.

This chain of events serves as a DPS check. If the party fails to kill the Garula fast enough, or if a player mounts Rathalos and fails the active time event for any reason, Rathalos will escape the arena and wipe the raid with a massive flaming attack, King of the Skies. It is possible to kill the Garula without mounting Rathalos, though this will require very high DPS.

Bear in mind that the player who mounts Rathalos will take continuous damage-over-time and may require healing - a possible reference to the use of stamina when mounting a monster in Monster Hunter: World. If the player who has mounted Rathalos is reduced to 0 HP, they will be knocked off Rathalos, and the party will wipe to King of the Skies. The Garula's auto-attacks are also incredibly vicious, even against tanks, and it will also frequently perform a frontal AoE cleave for massive damage to anyone caught in its path. This cleave can also hit the player who has mounted Rathalos and quickly lead to a raid wipe. Due to this, it is best to face the Garula away from the party as soon as possible.
Assuming the Garula has been defeated in time and a party member has successfully mounted Rathalos without being KO'd, Rathalos will leave the arena and prepare to unleash King of the Skies. After standing behind the Garula's corpse to avoid this attack, the final phase of the encounter will begin.";
        }
    }
}