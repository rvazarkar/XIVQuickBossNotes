using System.IO;
using BossNotes.ARR.AllianceRaids;
using BossNotes.ARR.Dungeons;
using BossNotes.ARR.Trials;
using Dalamud;

namespace BossNotes.ARR
{
    public class ARR : Expansion
    {
        public ARR(string assemblyLocation, ClientLanguage language) : base(Path.Combine(assemblyLocation, "ENG", "ARR"), language)
        {
            Name = "A Realm Reborn";
        }
    }
}