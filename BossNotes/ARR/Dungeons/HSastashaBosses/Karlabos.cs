namespace BossNotes.ARR.Dungeons.HSastashaBosses
{
    public class Karlabos : Boss
    {
        public Karlabos()
        {
            Name = "Karlabos";
            QuickStrategy = @"Stay spread out. Interrupt ""Tail Screw"". Cleanse Slime debuff.";
            InDepthStrategy = @"Karlabos will drop Aqua Balls on players to apply a DoT called Slime. Remove the DoT ASAP with Esuna or Leeches. He will also target the highest-enmity party member with Prey. A few seconds later, Karlabos will stun the player holding the Prey effect. Prey can be passed to other players by physically running into them, resulting in a stun on that player instead. His next attack is Tail Screw, which he will use on a player that is not the tank. Tail Screw will bring the player to 1% of their HP, but will not kill them; however, the player will die if they have the Slime debuff on them. Tail Screw can be stunned; if possible, the tank should pass Prey to a nearby DPS before being stunned so they are able to stun Tail Screw immediately after.

The Aqua Balls that apply Slime can overlap to inflict Slime on nearby players. Players can therefore have more than 1 Slime debuff at a time. Avoid standing too close to other players; otherwise, the healer might need to remove Slime several times from a single party member before the Tail Screw attack is used. As long as no one has the debuff, the highest priority after that is keeping the tank's health high. Karlabos seems to hit harder the lower his health is.

So in short, the healer's priorities are as follows:

Remove Slime debuff from everyone before Tail Screw attack > Keep tank health up > Keep party members' health up.";
        }
    }
}