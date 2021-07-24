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
                new TamTara(),
                new Copperbell(),
                new Halatali(),
                new ThousandMaws(),
                new HaukkeManor(),
                new BrayfloxLongstop(),
                new SunkenTemple(),
                new CuttersCry(),
                new StoneVigil(),
                new Dzemael(),
                new AurumVale(),
                new CastrumMeridianum(),
                new Praetorium(),
            };
        }
    }
}