namespace BossNotes.ARR.Dungeons.HTamTaraBosses
{
    public class Liavinne : Boss
    {
        public Liavinne()
        {
            Name = "Liavinne";
            QuickStrategy = @"Do not attack the adds, kite then. Take the orange marker into the adds to kill them.
Helps to group in the middle.";
            InDepthStrategy = @"For tanks, you do nothing. Just hold onto the boss and keep her attention. The gimmick is all on the DPS/Healer. A horde of zombies will be summoned and start chasing one of the players other than the tank. DO NOT ATTACK THEM, kite them. At some point, she will put an orange/red arrow-like mark over someone's head (again, not the tank). That person needs to run into the horde. This unleashes an AoE that will kill the zombies for you. If you kill a zombie yourself, the party takes a huge damage resistance debuff that lasts one minute and stacks up to 8 times. If you don't make the boss kill the zombies with her AoE on the first two attempts, you will take the debuff from the remaining zombies a few seconds later after she does her next attack. Go all out on damage during the breaks between hordes.

Do not attack the adds. The person with the red arrow mark should go to the person being attacked by the adds.
Players should group up in the middle so the player targeted by the adds will always be next to the player marked by the arrow";
        }
    }
}