namespace BossNotes.ARR.Dungeons.LostCityBosses
{
    public class Arioch : Boss
    {
        public Arioch()
        {
            Name = "Arioch";
            QuickStrategy = @"Kill adds to get a stacking debuff. The boss will only target the person with the highest stacks. Tank should kill adds.";
            InDepthStrategy = @"At first there will be a single Ranch Wamura add with the actual boss, Arioch, flying around. Kill it and have the tank stand in front of it when it dies. Anyone that stands in front of the Ranch Wamura when it dies will get a stacking debuff vulnerability down called Scale Flakes. The boss attacks whoever has the highest stacks of Scale Flakes, so make sure the tank is the one that gets the debuff. When the Scale Flakes debuff is running out, pull another Ranch Wamura add and kill it facing the tank. If the debuff runs out Arioch will start flying overhead, regenerating massive amounts of hp.";
        }
    }
}