namespace BossNotes
{
    public class Expansion
    {
        public string Name { get; protected set; }

        public Instance[] Dungeons { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] Trials { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] HighEndTrials { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] Raids { get; protected set; } =
        {
            new PlaceholderInstance()
        };

        public Instance[] AllianceRaids { get; protected set; } =
        {
            new PlaceholderInstance()
        };
    }
}