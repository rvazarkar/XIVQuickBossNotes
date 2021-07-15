namespace BossNotes.Stormblood.Dungeons.KuganeBosses
{
    public class DojunMaru : Boss
    {
        public DojunMaru()
        {
            Name = "Dojun-maru";
            QuickStrategy = "Kill clones ASAP, spread out for markers";
            InDepthStrategy = @"Avoid the narrow column AoEs that stretches from one end of the room to the other.

Kill the clones as soon as possible to avoid heavy groupwide damage.

When marked with the electric circle marker, spread out to avoid catching anyone in more than their own damage AoE.";
        }
    }
}