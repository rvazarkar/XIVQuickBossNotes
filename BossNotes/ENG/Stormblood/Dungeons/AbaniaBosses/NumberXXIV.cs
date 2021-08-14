namespace BossNotes.Stormblood.Dungeons.AbaniaBosses
{
    public class NumberXXIV : Boss
    {
        public NumberXXIV()
        {
            Name = "Number XXIV";
            QuickStrategy =
                @"Step in the elemental platform that aligns with the boss. It will always be the one he doesn't include in his yell (""My cup runneth over with X and Y"")";
            InDepthStrategy = @"Stab: Tankbuster.
Gale Cut: Targeted Circle AoEs under the three non-Tank players. Step away to avoid.
Elemental Pillars: Three pillar AoEs appear on the platform that transform into Fire, Ice, and Lightning elemental attunement puddles after landing. Move into the puddle to attune yourself to that element.
Barrier Shift: Number XXIV gains a shield that reflects all damage dealt by players not attuned to the same element as him. As he casts this ability, Number XXIV shouts ""My cup runneth over with element and element!"". Attune yourself to the element he does not mention.";
        }
    }
}