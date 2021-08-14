using BossNotes.ARR.Dungeons.PraetoriumBosses;

namespace BossNotes.ARR.Dungeons
{
    public class Praetorium : Instance
    {
        public Praetorium()
        {
            Name = "The Praetorium";
            Level = 50;
            ZoneID = 224;
            Bosses = new Boss[]
            {
                new PraeIntro(),
                new MarkIIMagitek(),
                new Nero(),
                new Gaius(),
                new UltimaWeapon(),
                new Lahabrea()
            };
        }
    }
}