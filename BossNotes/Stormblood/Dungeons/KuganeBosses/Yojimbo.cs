namespace BossNotes.Stormblood.Dungeons.KuganeBosses
{
    public class Yojimbo : Boss
    {
        public Yojimbo()
        {
            Name = "Yojimbo";
            QuickStrategy = "Pick up gold after Payday. Inoshi-Katcho is middle of room and then outside. Destroy dragon heads whenever they spawn";
            InDepthStrategy = @"During the first Payday phase, piles of gold will spawn around the room. His dog will lunge to pick them up, knocking aside anyone in his trajectory, filling the duty gauge with each pile he successfully picks up. Interact with as much gold as you can to pick it up; his dog prioritizes gold in the order in which it drops. When the Payday phase completes, Yojimbo will deal groupwide damage according to how much the duty gauge has filled.

Be ready for occasional groupwide damage from Metta-Giri.

Inoshi-Katcho casts circle AoEs on first the center of the room, then the outskirts. Move out of these.

Avoid his circle AoE he casts on himself.

During the second Payday phase, act as before, but destroy the dragon heads he summons during this phase. They cast column AoEs on players' locations, and don't take much punishment before dying. He may summon dragon heads after the second Payday phase is complete as well; deal with them when that time comes.";
        }
    }
}