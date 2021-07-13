namespace BossNotes.ARR.Dungeons.HaukeBosses
{
    public class JesterSteward : Boss
    {
        public JesterSteward()
        {
            Name = "Manor Jester and Manor Steward";
            QuickStrategy = "Kill Jester first and then Steward";
            InDepthStrategy =
                @"Manor Jester and Manor Steward are two bosses located in the same room. Jester is the spell caster and Steward is the tank. Players should kill Jester first because it deals more damage and has less HP. Stewart is tankier and has an interrupt-able AoE attack.";
        }
    }
}