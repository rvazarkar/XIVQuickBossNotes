namespace BossNotes.Stormblood.Dungeons.SwallowsCompassBosses
{
    public class Otengu : Boss
    {
        public Otengu()
        {
            Name = "Otengu";
            QuickStrategy = @"Look away for Gaze attacks. Avoid embers floating around.";
            InDepthStrategy = @"Clout of the Tengu: Large AOE centred around Otengu.
Yama-kagura: Line AOE of medium width, directed at one of the player other than the tank.
Wile of the Tengu: One of the Eye themed abilities. Looking away from Otengu will dodge its effect. Not doing so will apply the Hysteria debuff.
Tengu Ember: A number of Tengu Ember will appear. Those flames will start to move around the arena. Player hit by one of them will suffer minor damage and one (1) debuff stack of Suppuration (Maximum HP is reduced and damage taken is increased.). After some time the remaining ember will explode in medium sized AOE's.
Might of the Tengu: A tank buster ability.";
        }
    }
}