namespace BossNotes
{
    public class Expansion
    {
        public string Name { get; protected set; }
        public Instance[] Dungeons { get; protected set; } = new Instance[0];
        public Instance[] Trials { get; protected set; } = new Instance[0];
        public Instance[] HighEndTrials { get; protected set; } = new Instance[0];
        public Instance[] Raids { get; protected set; } = new Instance[0];
        public Instance[] AllianceRaids { get; protected set; } = new Instance[0];
    }
}