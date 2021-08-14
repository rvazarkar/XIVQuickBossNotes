namespace BossNotes.ARR.Dungeons.CopperbellBosses
{
    public class Ichorous : Boss
    {
        public Ichorous()
        {
            Name = "Ichorous Ire";
            QuickStrategy = "Kill spriggans for powder, use blasting device, let blasting cap explode on boss.";
            InDepthStrategy =
                @"An Improved Blasting Device sits in the center of the boss room, next to the reddish magma stone. 
                During the fight, spriggans will periodically spawn into the room. They will drop blasting powder upon death. 

                Upon receiving blasting powder, one of the party members needs to interact with the Improved Blasting Device to spawn a Blasting Cap. 
                Before interacting with the Improved Blasting Device, Ichorous Ire should be lured to the magma stone. 
                The bomb monster will explode after sometime, dividing Ichorous Ire into 2, smaller blobs. Repeat previous steps and spawn 4 even smaller blobs. 
                Repeat the steps for the 3rd time to spawn 8 very small and vulnerable blobs. Kill the 8 blobs to finish Ichorous Ire off.

                Do not let the Blasting Cap die.
                Stay out of the Blasting Cap's AoE Self-destruct attack.";
        }
    }
}