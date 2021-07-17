namespace BossNotes.Stormblood.Trials.Susano
{
    public class SusanoP3 : Boss
    {
        public SusanoP3()
        {
            Name = "Phase 3";
            QuickStrategy = @"Kill the stone that has a player trapped in it (is initially marked)";
            InDepthStrategy = @"All abilities from Phase 1 are present during this phase.

Stormsplitter - Tank Buster. Pop mitigation cooldowns.

Ama-no-iwato - ""Earth and stone at our beck and call!"" - Susano will trap a player in a chained stone. Two ""dummy stones"" will also spawn. The stone containing the player will be marked and then the stones will be shuffled. Only the stone containing a player needs to be destroyed. If the stone finishes casting 'The Sealed Gate', the player is killed (not confirmed).

Ukehi - Moderate party-wide damage that can hit 1 or 2 times";
        }
    }
}