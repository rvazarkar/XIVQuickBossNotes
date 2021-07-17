namespace BossNotes.Stormblood.Trials.MenagerieBosses
{
    public class ShinryuP3 : Boss
    {
        public ShinryuP3()
        {
            Name = "Phase 3";
            QuickStrategy = @"When ""Aerial Blast"" spawns, stay close to center.
When ""Tidal Wave"" spawns, run to the side of the platform with the waterspout.
When ""Earthen Fury"" is cast, get off the platform.
When ""Diamond Dust"" is cast, don't move
""Akh Morn"" hits multiple times, don't unstack until its over.
Break chains by moving apart from each other.";
            InDepthStrategy =
                @"This phase opens with the party landing on a three-by-three grid of large platforms, with Shinryu using his new line charge attack almost immediately. This has a short knockback, so either get clear of it entirely (corners) or stand as far away from the edges as possible and soak the damage.

The inner grey platform is unbreakable, but the outer blue platforms can be broken by Shinryu's Tail Slam and Corrupted Earth Aether attacks. The former marks two platforms, whilst the latter marks one. After using the Tail Slam, Shinryu's tail is vulnerable and should be attacked immediately. Reducing it to 0% transfers the damage to Shinryu and can take a decent chunk (around 5-6%) out of his health in the process, making the fight a lot easier.

Every two Corrupted Aether attacks, Shinryu will use his line charge and switch which side of the platform he's attacking from, but otherwise his attacks are mostly on shuffle now, and nothing new will come up.";
        }
    }
}