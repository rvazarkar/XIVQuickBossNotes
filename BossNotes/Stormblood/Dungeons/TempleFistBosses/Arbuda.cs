namespace BossNotes.Stormblood.Dungeons.TempleFistBosses
{
    public class Arbuda : Boss
    {
        public Arbuda()
        {
            Name = "Arbuda";
            QuickStrategy = @"Stand at a 45 degree angle from any side of the boss to easily dodge AoEs. Stand in the correct symbol to avoid damage during ""Hellseal"". ""Killer Instinct"" will parry all attacks/spells except from one side";
            InDepthStrategy = @"Arbuda is a massive, four-armed, sword-wielding statue with powerful attacks, and is best tanked at one end of the arena. Non-tank players should stand at approximately 45 degrees off any of Arbuda's cardinal directions; if you consider his front heading to be 0 degrees, you want to be at 45, 135, 225. or 315. This ensures you'll have plenty of time to reposition to avoid two of Arbuda's main attacks.

Port and Star: Massive unmarked cone AoE to Arbuda's left and right sides. Inflicts considerable damage and knockback. Stand in front or behind him.
Fore and Aft: Massive unmarked cone AoE to Arbuda's front and back sides. Inflicts considerable damage and knockback. Stand to either side of him.
Fourfold Shear: is a slice on the tank, even if you move Arbuda follows you so buff up and get healed.
Hellseal: Works identically to the Liquid Flame's 'Seal of Night and Day' from Great Gubal Library (Hard). Simply move to the corresponding glowing symbol to dodge the attack. The timing is fairly tight, but the damage tick doesn't apply the instant the cast ends, so you have a little wiggle room.
Tapas: Places invisible markers on every and chases them with AoE bursts.
Killer Instinct: Arbuda assumes a defensive stance, similiar to Ravana. 1 side will be open to attack; attacking any other side will cause him to parry the attack back at you - even spells can be deflected. Whilst this is active, he is also capable of parrying area-effect Limit Breaks.";
        }
    }
}