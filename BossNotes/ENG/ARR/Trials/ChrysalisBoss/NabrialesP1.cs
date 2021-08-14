namespace BossNotes.ARR.Trials.ChrysalisBoss
{
    public class NabrialesP1 : Boss
    {
        public NabrialesP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"Soak orbs by alternating types. Big heals when boss uses Double/Triple.";
            InDepthStrategy =
                @"At 80%, Players should spread out and absorb orbs. If you alternate between the big and small orbs (big gives physical vulnerability, small gives magical vulnerability) then you won't take much damage. For each orb that hits him he will gain a stack. Small adds do not have much hp and perform a cone AoE. Stack up for heals and Sacred Soil if you have 3+ stacks. 7 stacks is instant death for non tanks.";
        }
    }
}