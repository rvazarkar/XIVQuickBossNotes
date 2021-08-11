namespace BossNotes.ARR.AllianceRaids.WorldOfDarknessBosses
{
    public class Cerberus : Boss
    {
        public Cerberus()
        {
            Name = "Cerberus";
            QuickStrategy = @"Alliance A kills adds.
Alliance B gets hit by Orb and then stands in Purple Goo to go belly.
Alliance C drags chains to Cerberus";
            InDepthStrategy = @"When Cerberus becomes unchained and starts Thrashing, a group of players (usually Alliance B, plus any DPS that want to) needs to execute the following in order:

Stand next to the Gastric Orb mob to get hit by Mini spell and shrunk to a small size.
Stand in the Purple Goo to get eaten by the boss. (Do not stand in the purple goo if you don't have the Mini debuff, as Cerberus will kill you.)
Once inside, kill the adds on the wall in his stomach.
When the adds are dead he will stop thrashing, and will slump to the ground in pain. Groups outside the stomach need to use the two tethers to re-chain him while he is weakened - both tethers need to be re-attached to each of the Open Fetters on his sides by interacting with them.";
        }
    }
}