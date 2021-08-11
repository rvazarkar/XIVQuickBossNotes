using BossNotes.ARR.AllianceRaids;
using BossNotes.ARR.Dungeons;
using BossNotes.ARR.Trials;

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
                new WanderersPalace(),
                new AmpadorKeep(),
                new Pharos(),
                new HCopperbell(),
                new HHaukkeManor(),
                new LostCity(),
                new HHalatali(),
                new HBrayfloxLongstop(),
                new Hullbreaker(),
                new HStoneVigil(),
                new HTamTara(),
                new Snowcloak(),
                new HSastasha(),
                new HSunkenTemple(),
                new KeeperLake(),
                new HWanderersPalace(),
                new HAmpadorKeep()
            };
            Trials = new Instance[]
            {
                new BowlOfEmbers(),
                new TheNavel(),
                new HowlingEye(),
                new CapeWestwind(),
                new Chrysalis(),
                new StepsOfFaith(),
                new HBowlOfEmbers(),
                new HHowlingEye(),
                new HNavel(),
                new HThornmarch(),
                new HWhorleater(),
                new HStrikingTree(),
                new HAfkAkah(),
                new UrthsFount()
            };
            AllianceRaids = new Instance[]
            {
                new Labyrinth(),
                new SyrcusTower(),
                new WorldOfDarkness()
            };
        }
    }
}