namespace BossNotes.ARR.Dungeons.HSunkenTempleBosses
{
    public class Vicegerent : Boss
    {
        public Vicegerent()
        {
            Name = "Vicegerent to the Warden";
            QuickStrategy =
                @"Avoid mummy walls, stand behind the boss to avoid sword strike. Stun boss when he tethers.";
            InDepthStrategy =
                @"Do not get hit by the mummy walls. Everytime you are hit by the Mummy wall, you gain 1 stack of Curse of the Mummy. When you reach 4 stacks, you will run to a corner of the room, enter a sarcophagus and become mummified. As a mummy you lose control of your character and run around aimlessly in the center of the boss room for a short time. Mummified players can also stack the curse on other players if they run into them.

As the fight drags on, the boss will target a non-tank member of the party for a sword strike. Players can avoid the attack by running behind the boss while he is casting.

Tanks should have cooldowns ready in case healer gets mummified.
When the boss tethers a player, the player will receive stacks of Curse of the Mummy over time. The boss can be stunned to stop this.";
        }
    }
}