namespace BossNotes.ARR.AllianceRaids.LabyrinthBosses
{
    public class KingBehemoth : Boss
    {
        public KingBehemoth()
        {
            Name = "King Behemoth";
            QuickStrategy = @"Click towers when they begin to glow.
Do NOT drop green marker inside the boss. Stand behind rocks when Meteor is cast.";
            InDepthStrategy =
                @"King Behemoth is the 3rd boss of the labyrinth. Players will encounter Behemoth when they take the center path from the entrance.

Each tower should be covered by one ranged DPS or healer, activating it when it begins to glow; DPS priority is Iron Giant/Moving adds, and then boss. King behemoth will target a few players with a comet (green mark above head). These players need to run to the center and drop the comet to be used later. Adds will continually spawn and attempt to reach the towers. These need to be killed as soon as possible. In addition, an iron giant will spawn that will try to destroy the comets. The giant needs to be killed before all comets are destroyed or you will wipe. When King Behemoth stands up, he is casting meteor. The entire raid needs to drop what they're doing and get behind a comet (put a comet between you and him). Rinse and repeat and the fight is done.";
        }
    }
}