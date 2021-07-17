namespace BossNotes.Stormblood.Trials.PoolOfTributeBoss
{
    public class SusanoP1 : Boss
    {
        public SusanoP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"Move out of the path of the marked player, and then stack immediately after the knockback.";
            InDepthStrategy = @"Rasen Kaikyo - Places a circular AoE under each party member

Yata No Kagami - ""The seas part for we alone!"" - A player will be marked (Red). After a short time, they will be damaged and knocked back. The path of their knockback will determine the safe area of the platform-wide AoE that follows. This AoE applies Lightning Resistance Down.

Brightstorm - Immediately following Yata No Kagami, a stack marker will appear on the previously marked party member. Stack to share damage.

Dark Cloud - Susano will periodically spawn Dark Clouds. These clouds will each cast a wide line AoE that inflict Paralysis.

At around 65%, Susano will start Phase 2";
        }
    }
}