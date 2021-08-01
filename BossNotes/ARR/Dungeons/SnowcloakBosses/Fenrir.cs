namespace BossNotes.ARR.Dungeons.SnowcloakBosses
{
    public class Fenrir : Boss
    {
        public Fenrir()
        {
            Name = "Fenrir";
            QuickStrategy = @"Stand behind icicles for Lunar Cry and then move away to avoid explosion.";
            InDepthStrategy = @"Fenrir will cause three icicles to drop randomly on the field, two of which will then fly away in a line-shaped-AOE attack. The third will explode moments later. Fenrir will rotate between a ""Thousand Year Storm"" party wide attack and a slow cast called ""Lunar Cry"" after icicle drops. On the Lunar Cry cast, you have to run behind the remaining icicle that didn't fly away to avoid the attack and then move away to avoid the icicle's explosion. There is a way to quickly identify which icicle will persist - two of the icicles target party members, but one will be randomly placed. The one that drops randomly will be the one that remains for the party to hide behind. After the Lunar Cry, Fenrir will jump onto the tank with a moderate damage attack.";
        }
    }
}