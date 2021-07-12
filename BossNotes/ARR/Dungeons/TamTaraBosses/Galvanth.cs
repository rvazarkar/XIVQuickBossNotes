﻿namespace BossNotes.ARR.Dungeons.TamTaraBosses
{
    public class Galvanth : Boss
    {
        public Galvanth()
        {
            Name = "Galvanth the Dominator";
            QuickStrategy = "Dodge AoE, kill adds to remove the bosses' damage immunity.";
            InDepthStrategy =
                @"Galvanth the Dominator (Soulflayer) is the main boss of Tam-Tara Deepcroft. He will cast an AoE spell that will paralyze anyone caught in it. A giant red circle appears on the ground before he casts the spell. Move out of it as soon as possible. Galvanth summons adds 3 times during the fight. The first wave of adds consist of an imp that shoots fire balls. The second wave of adds consist of an imp along with skeletons and mitelings. The third wave consist of two imps along with skeletons and mitelings.

                Attacks from the imps will interrupt spell casting.
                The imps make Galvanth immune to damage, so prioritize killing them quickly before killing the other adds.
                Once the imps are dead in the 3rd wave of adds use the AoE Limit Break to take out all the remaining adds and possibly the boss as well.";
        }
    }
}