namespace BossNotes.ARR.Dungeons.HWanderersPalaceBosses
{
    public class ZoloolJa : Boss
    {
        public ZoloolJa()
        {
            Name = "Slithy Zoolol Ja";
            QuickStrategy = @"Soak totems to keep boss from buffing. One totem will cleanse Toad.";
            InDepthStrategy = @"A shaman boss, who summons totems. If after a while no-one has claimed the totems, he will recall all of them and gain the buffs himself. Some of the totems grant buffs while some should be ignored. He will randomly hex a target and turns them into a toad for 12 seconds. He will also randomly cast Fire to the party members and while the damage is not too big, the totems can increase the damage.

Standing in a totem gives you a buff or debuff. Clean as many of the flags as possible and don't stack fire resist down.

There will be Purple, Red, Blue and Green Totems. The effects of the various colors are random. One will give you attack up (DPS should pick it up), another will give you the toad debuff or cleanse the toad debuff (only pick it up if you are a toad), another will give you fire resist down and final one will give the player Heavy debuff.";
        }
    }
}