namespace BossNotes
{
    public class Instance
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Boss[] Bosses { get; set; } = new Boss[0];
        public ushort ZoneID { get; set; } = 0;
    }

    public class PlaceholderInstance : Instance
    {
        public PlaceholderInstance()
        {
            Name = "Placeholder";
            Level = 0;
        }
    }
}