namespace BossNotes.Stormblood.Trials.JadeStoaBoss
{
    public class ByakkoP1 : Boss
    {
        public ByakkoP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"Stack up for ""State of Shock"" and then move directly behind the boss after the attack.
Avoid orbs during ""Unrelenting Anguish"". Pick up and kill the add when it spawns.
Move away from marked players during add phase.";
            InDepthStrategy = @"Storm Pulse - causes Byakko to blast the raid with unavoidable damage.
Heavenly Strike - a vicious tank-buster against Byakko's primary target that should be mitigated via cooldowns whenever possible.
State Of Shock - causes Byakko to lunge towards a random target and scoop them up in his tiger-fist. Shortly afterward, a stack-marker will appear within the arena, indicating where Byakko will slam the grabbed target. Teammates should make an effort to stand within the stack-mark location to help soak the slam, as failure to do so will lead to victim being slain.
Sweep Of The Leg - Byakko prepares to kick all players in-front and beside him via a frontal-cone AoE that covers the entire platform, except for a safe cone directly behind him. Simply move behind Byakko as soon as possible to avoid tremendous damage. Bear in mind that Sweep Of The Leg will always happen directly after State Of Shock.
Unrelenting Anguish - Byakko teleports to the arena centre and begins to emit patterns of outward-travelling red orbs that all raid participants must avoid. Melee players must be especially careful as they will be extremely close to where the orbs spawn, though they do travel very slowly and can still be avoided. During Unrelenting Anguish, Byakko will unleash multiple casts of Fire & Lightning.
Fire & Lightning - a massive straight-line AoE aimed at a random player that everyone must avoid. Initially, Byakko will execute multiple casts at the arena centre, forcing players to avoid massive AoE's and the orbs at the same time. Eventually, Byakko will leap to the outer-edge of the arena and cast another Fire & Lightning while the remaining orbs begin to expire.
Hakutei - having successfully avoided the onslaught, players will witness Byakko leap from the arena while Hakutei - the White Tiger usually connected to Byakko's own arm - enters the fray. Hakutei is a mini-boss that must be picked up by a tank and turned away from the group. If not done so, players risk being swiped by Hakutei's vicious cleave attacks. Whilst dealing with Hakutei, players will also have to dodge AoE attacks that bombard the arena, leaving behind persistent puddles that inflict bleed on anyone who remains within them.
White Herald - causes Hakutei to leap from the arena and place a proximity marker (flare) on its primary target. After a delay, Hakutei will inflict heavy damage by slamming down onto the marked player. Unmarked players must move away from the marked player beforehand to avoid taking too much proximity damage from the AoE slam.
Fire & Lightning - executed immediately after White Herald. On landing, Hakutei will charge a straight-line AoE towards a random player, forcing the raid to move out of the way to avoid damage.
On reaching this point, Hakutei will leap to the arena centre and begin to charge Roar Of Thunder, indicating the arrival of the next phase. However, the damage inflicted by Roar Of Thunder will depend on how much health Hakutei has remaining, so players must burn down Hakutei as fast as possible to avoid tremendous damage (or a potential wipe). Survivors will be stunned and eventually launched high into the air, indicating the arrival of the next phase.";
        }
    }
}