namespace BossNotes.ARR.Dungeons.SnowcloakBosses
{
    public class Yeti : Boss
    {
        public Yeti()
        {
            Name = "Yeti";
            QuickStrategy = @"Make the frontal cone attack target Spriggans/snowballs. Kill Frostbound adds.
When boss uses AoE, knock snowballs into him.";
            InDepthStrategy =
                @"Yeti has a frontal cone AoE that turns its spriggan adds into snowballs if they are hit by it. The tank should try to make the Yeti face as many spriggans as possible. These adds can be safely ignored otherwise, and nobody should attack the snowballs unless needed.

When Yeti performs a room-wide AoE, hit it with the snowballs (line up behind it and attack it) to stop the casting. The larger Frostbound adds will not turn into snowballs and will break snowballs if given the chance, and should be killed quickly.

Snowballs come in different sizes: small, medium and large. Snowballs that are hit by further frost cone attacks or merged together will increase in size. Larger snowballs deal more damage to the Yeti.

Small snowball deals around 2000 damage, medium deals around 10,000 damage and large deals around 30,000 damage to Yeti.
Snowballs can be destroyed by Yeti's cleave attack.";
        }
    }
}