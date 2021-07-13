namespace BossNotes
{
    public class Instance
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Boss[] Bosses { get; set; } = new Boss[0];
    }
}