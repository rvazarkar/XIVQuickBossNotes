using BossNotes.ARR.Dungeons;

namespace BossNotes.ARR
{
    public class ARR : Expansion
    {
        public ARR()
        {
            Name = "A Realm Reborn";
            Dungeons = new Instance[]
            {
                new Sastasha(),
                new TamTara()
            };
        }
    }
}