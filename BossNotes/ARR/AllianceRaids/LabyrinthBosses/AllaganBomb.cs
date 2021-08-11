namespace BossNotes.ARR.AllianceRaids.LabyrinthBosses
{
    public class AllaganBomb : Boss
    {
        public AllaganBomb()
        {
            Name = "Allagan Bomb";
            QuickStrategy = @"Big adds should be separated onto markers. Kill bomb adds ASAP";
            InDepthStrategy = @"Allagan Bomb initially does nothing. Each group takes one of the large sword adds. Those Vassagos WILL NOT aggro anyone automatically, so MT should stand in front of each adds to avoid the boss running to the middle. The boss will periodically spawn balloon adds that need to be killed before they explode (high priority). In addition, a Napalm add may spawn and will have the highest priority to kill. The boss can be damaged once the 3 adds are down.

A Vassago will get invulnerability if it has too little HP compared to the healthiest Vassago.

MT should stand in front of Vassago before starting fight
Kill Priority for adds: Napalm first, Balloon second and Sword third.";
        }
    }
}