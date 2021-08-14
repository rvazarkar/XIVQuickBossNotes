using System.IO;

namespace BossNotes.ENG.Heavensward
{
    public class Heavensward : Expansion
    {
        public Heavensward(string contentLocation) : base(Path.Combine(contentLocation, "Heavensward"))
        {
            Name = "Heavensward";
        }
    }
}