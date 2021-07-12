namespace BossNotes
{
    public class Expansion
    {
        public string Name { get; protected set; }
        public Instance[] Dungeons { get; protected set; }
        public Instance[] Trials { get; protected set; }
        public Instance[] Raids { get; protected set; }
    }
}