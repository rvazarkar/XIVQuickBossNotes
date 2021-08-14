using System;

namespace BossNotes
{
    [Serializable]
    public class Instance
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Boss[] Bosses { get; set; } = new Boss[0];
        public ushort ZoneID { get; set; }
    }

    internal static class Rand
    {
        private static readonly Random rnd = new();

        public static int GetRandom()
        {
            return rnd.Next(1000, 6000);
        }
    }

    public class PlaceholderInstance : Instance
    {
        public PlaceholderInstance()
        {
            Name = "Placeholder";
            Level = 0;
            ZoneID = (ushort) Rand.GetRandom();
            Index = 0;
            Bosses = new Boss[]
            {
                new PlaceholderBoss()
            };
        }
    }

    public class PlaceholderBoss : Boss
    {
        public PlaceholderBoss()
        {
            Name = "Placeholder";
            QuickStrategy = "";
            InDepthStrategy = "";
        }
    }
}