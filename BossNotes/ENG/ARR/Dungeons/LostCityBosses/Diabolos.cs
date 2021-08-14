namespace BossNotes.ARR.Dungeons.LostCityBosses
{
    public class Diabolos : Boss
    {
        public Diabolos()
        {
            Name = "Diabolos";
            QuickStrategy = @"Move away if you get the marker. 
Mark doors with matching symbols. Open first door immediately, and second door when the boss casts ""Ruinous Omen""";
            InDepthStrategy =
                @"There are 8 doors divided into pairs of 2 in the boss room. They have four symbols, the blue goobbue, red demon, the light green dragon-like, and the dark green moth. Each symbol will appear above 2 doors. When you open both doors of the same symbol, you will get sucked into a void and you become immune to attacks for a short period of time. When Diabolos casts Ruinous Omen, you need to activate a matching pair of doors or the party will wipe. If you activate doors of the wrong symbol, they will close and there will be no effect.

The symbols will only appear at the start of the fight, and during a successful door opening. At the beginning of the fight, a responsible party member should select a symbol and remember or waymark both doors of the chosen symbol. Then, the party member should open one of these doors. When you get to about 60% of Diabolos health, he will go to the center of the arena and start to cast Ruinous Omen, once it gets about halfway through the cast bar have the party member open his matching door. If timed right you will get into the void as soon as he casts Ruinous Omen and you won't take any damage. If your damage is halfway decent you should only see Ruinous Omen once or twice.

Avoid the orbs when they appear, they apply heavy and deal more damage as the debuff gets stacked on the party.";
        }
    }
}