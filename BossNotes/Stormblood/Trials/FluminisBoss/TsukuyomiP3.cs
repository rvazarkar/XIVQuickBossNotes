namespace BossNotes.Stormblood.Trials.FluminisBoss
{
    public class TsukuyomiP3 : Boss
    {
        public TsukuyomiP3()
        {
            Name = "Phase 3";
            QuickStrategy = @"Swap platforms when you have 3 stacks.
""Lunacy"" is a multi hit stack, don't immediately separate.
Has all the abilities from phase 1 and 2.";
            InDepthStrategy =
                @"Phase 3 will run with the same abilities you have seen so far with the addition of some others. She will also continue to cast Nightfall.

Selenomancy - Causes the platform to be split into two sections. Standing in one section stacks debuffs. If the debuffs reach 5 stacks, a Doom and bleed Debuff will be applied, and you're likely to die. Players must move between these two sections to reset their stacks. It is recommended to switch at 3 stacks since that is a safe area and she is likely to cast an AoE around that time, that way you are not trapped on one side. Doughnut AoE's and Nightfall will cast during this time so keep on your toes.
Antitwilight/Perilune - Removes Selenomancy and debuffs and deals raid-wide damage.
During Selenomancy, Tsukuyomi can also cast Midnight Haze, so be mindful of your stacks when they spawn and move to the section you need to move to so you can kill the add and reset your stacks.

Dance of the Dead - Signals final phase change, dealing heavy raid-wide damage.
Lunacy - Essentially Ahk Morn; an attack that players must stack for and remain stacked as the attack will hit multiple times. (1 hit, 2 quick hits after a pause)
Dark/Bright Blade - Lazer Sword. She will attack large sections of the arena depending on the blade she is using. Dodge the AoE's!";
        }
    }
}