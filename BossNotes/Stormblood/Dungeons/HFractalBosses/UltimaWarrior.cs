namespace BossNotes.Stormblood.Dungeons.HFractalBosses
{
    public class UltimaWarrior : Boss
    {
        public UltimaWarrior()
        {
            Name = "The Ultima Warrior";
            QuickStrategy = @"""Zurvan"" = run to the matching circle. ""Sephirot"" = spread green markers far apart. ""Sophia"" = stack with player of opposite color. 
Stack for Mass Aetheroplasm.";
            InDepthStrategy = @"Atherplasm Tankbuster + Damage around Tank.
Citadel Buster Targets random player.
Ceruleum Vent Group Wide Damage & Knockback.
Primordial Aether Channels power from a Primal Statue and gains special abilities.
If Zurvan Players affected by fire or ice must stand in appropriate marker. ex Fire > Fire Ice > Ice
Mass Aetheroplasm Stack Damage on Group.
If Sophia Stack Black & White markers together.";
        }
    }
}