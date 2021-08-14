using System.IO;

namespace BossNotes.ENG.Stormblood
{
    public class Stormblood : Expansion
    {
        public Stormblood(string contentLocation) : base(Path.Combine(contentLocation, "Stormblood"))
        {
            Name = "Stormblood";
        }
    }
}