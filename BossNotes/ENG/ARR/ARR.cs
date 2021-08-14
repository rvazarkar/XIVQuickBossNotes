using System.IO;

namespace BossNotes.ENG.ARR
{
    public class ARR : Expansion
    {
        public ARR(string contentLocation) : base(Path.Combine(contentLocation, "ARR"))
        {
            Name = "A Realm Reborn";
        }
    }
}