using System.IO;

namespace BossNotes.ENG.Shadowbringers
{
    public class Shadowbringers : Expansion
    {
        public Shadowbringers(string contentLocation) : base(Path.Combine(contentLocation, "Shadowbringers"))
        {
            Name = "Shadowbringers";
        }
    }
}