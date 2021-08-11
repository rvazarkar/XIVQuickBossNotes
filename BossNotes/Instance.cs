using System;

namespace BossNotes
{
    public class Instance
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Boss[] Bosses { get; set; } = new Boss[0];
        public ushort ZoneID { get; set; }
    }

    internal static class Rand
    {
        private static readonly Random rnd = new Random();

        public static int GetRandom()
        {
            return rnd.Next(1000, 6000);
        }
    }

    public class PlaceholderInstance : Instance
    {
        public PlaceholderInstance()
        {
            var rand = new Random();
            Name = "Placeholder";
            Level = 0;
            ZoneID = (ushort) Rand.GetRandom();
        }
    }
}