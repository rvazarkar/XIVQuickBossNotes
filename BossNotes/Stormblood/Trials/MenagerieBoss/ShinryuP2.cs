namespace BossNotes.Stormblood.Trials.MenagerieBoss
{
    public class ShinryuP2 : Boss
    {
        public ShinryuP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Move as far from AoE as possible, kill adds as far as possible.
Mash the button to survive the active time manuever.";
            InDepthStrategy = @"Shinryu will depart the platform briefly.

Several large AoEs are laid down; move as far away as possible to minimize damage taken. These blasts have no knockback, so you can safely stand at the corners or edge of the platform (and will probably need to).

Shinryu will summon three waves of Hakkinryu and Ginryu adds.

Wave 1 is 2 Ginryu and 1 Hakkinryu; Wave 2 is 3 Ginryu and 1 Hakkinryu, and Wave 3 is 5 Ginryu.

Kill all of the adds as quickly as possible and prepare for phase transition.

Shinryu will Fetter everyone and commence an Active Time Maneuver. Mash the button so that the bar fills before the time runs out or else you'll start Phase 3 on the floor with 0 HP.";
        }
    }
}