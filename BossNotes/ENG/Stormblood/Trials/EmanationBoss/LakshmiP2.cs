namespace BossNotes.Stormblood.Trials.EmanationBoss
{
    public class LakshmiP2 : Boss
    {
        public LakshmiP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Use your duty mechanic to shield yourself from her ultimate.
Use your duty action whenever the boss goes to the middle and casts the big AoE.
Don't pick up an orb if you already have one.";
            InDepthStrategy =
                @"The trial begins with Lakshmi surrounded by a barrier, and flanked by a pair of Dreamer Ananta. Defeat them to lower Lakshmi's barrier and begin the fight, but bear in mind that Lakshmi will use area of effect attacks that also heal the Dreamers, so the party should concentrate on them one at a time rather than splitting attention.

Shortly after she begins fighting for herself, Lakshmi will leave the platform and prepare to use a special attack that is an instant kill on anyone not shielded by the Duty mechanic - Vril. Players can hold a single charge of Vril at any time and activate it whenever they wish; once activated, the charge lasts for around 30 seconds and significantly reduces the effect of Lakshmi's attacks. After this attack has been used once, she will not attempt to use it again during the regular version of the trial.

Replacement Vril orbs will spawn shortly before the time comes to actually use them; do not touch an orb if you already have a charge, as it will still consume the orb (meaning another party member won't be able to use it). The main times to use them are when Lakshmi moves to the centre of the platform and casts a platform-wide AoE with no safe zone. This inflicts heavy damage and knockback if you do not use your Vril, and falling off the platform is an instant KO (though you will return to the starting position and can be Raised).

Aside from the Vril mechanic, the fight is fairly straightforward and mostly involves positioning her area attacks. Lakshmi will apply the Target Left or Target Right states depending on which ""Hand"" ability she is using; one corresponds to a circular blue pool effect that grows larger if it deals damage to players, and the other corresponds to cross-shaped effects that originate from 2-3 random players at a time. She will also periodically mark someone with a large orange effect with arrows that point toward the target; when this occurs, stack up to spread the damage.

The fight is otherwise fairly straightforward until Lakshmi is defeated, though visually noisy and chaotic. Just don't stand in the AoEs (apart from the one you need to stack for) and you'll be fine.

Important information
Kill adds 1 at a time
You will need to pick up a replacement blue orb to use, only pick up one
Use the button ...
Shortly after the adds are gone in the beginning of the fight
When she moves to the centre of the platform";
        }
    }
}