namespace BossNotes.Stormblood.Dungeons.KuganeBosses
{
    public class ZuikoMaru : Boss
    {
        public ZuikoMaru()
        {
            Name = "Zuiko-maru";
            QuickStrategy = "Stack for marker, when tethered, drag bombs to the side of the room";
            InDepthStrategy = @"Avoid the frontal cone he occasionally casts.

Stack when someone is hit with the shareable damage marker.

He will spawn up to two bombs at a time that will tether to a player, chase them, and try to bind them. When a bomb is killed, it will stay in place and damage anyone in its radius AoE. Players who get tethered should keep to one side of the room to make it easier to avoid the very large AoE.

Healers should prepare to heal through his occasional casts of Kenki Release, which hits the whole party.";
        }
    }
}