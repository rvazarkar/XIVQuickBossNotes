﻿namespace BossNotes.ARR.Trials.HNavelBoss
{
    public class HTitan : Boss
    {
        public HTitan()
        {
            Name = "Titan";
            QuickStrategy = @"ALWAYS DODGE LANDSLIDE.
Always stand inside the red border during jumps. Don't bother trying to kill rocks.
Free allies trapped in boulders. Bombs explode in the same order they spawn. ";
            InDepthStrategy =
                @"1. You can instant-die if you get pushed off the ledge. This mostly happens when he uses his ""Landslide"" attack (rectangular AoE in front of him, will push you off if you get hit) -- consider it a one-hit-KO move and avoid at all cost!

2. During ""Geocrush"" (boss jumps up in the air, disappears, then slams the ground) you don't risk being pushed off the ledge from the shockwave itself. However, the arena will be broken beyond (outside) the red outline that will appear near the edge of the battlefield. Therefore, stay inside the red circle (so you don't fall off), but try to stay as close to the red line (inside its perimeter!) as possible to minimize damage.

3. When the rock boulders spawn, simply ignore them (stay away to avoid damage, but don't try to destroy them -- they are just a waste of dps).";
        }
    }
}