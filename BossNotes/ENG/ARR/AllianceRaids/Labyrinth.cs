using BossNotes.ARR.AllianceRaids.LabyrinthBosses;

namespace BossNotes.ARR.AllianceRaids
{
    public class Labyrinth : Instance
    {
        public Labyrinth()
        {
            Name = "Labyrinth of the Ancients";
            Level = 50;
            ZoneID = 174;
            Bosses = new Boss[]
            {
                new BoneDragon(),
                new Atomos(),
                new Thanatos(),
                new AllaganBomb(),
                new KingBehemoth(),
                new Phlegethon()
            };
        }
    }
}