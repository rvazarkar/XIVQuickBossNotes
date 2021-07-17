namespace BossNotes.Stormblood.Trials.FluminisBoss
{
    public class TsukuyomiP1 : Boss
    {
        public TsukuyomiP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"""Steel of the Underworld"" is a frontal cone. ""Lead of the Underworld"" is a line stack.
""Zashiki-asobi"" will spawn AoEs in a circle that go off in the order they spawned";
            InDepthStrategy = @"Torment Unto Death - Large frontal cone tank buster. As usual, all other players must not stand in front of the boss
Zashiki-Asobi - This is essentially Ser Adelphel from The Vault. She will spawn fans around the arena; one in the centre, and the others around. They will explode in the same order they spawned in. It is recommended to stand in another fan (ones that will explode last) as the centre one explodes to head back to the centre.
Nightfall - Casts during Zashiki-Asobi signaling an incoming AoE random attack.
Steel of the Underworld - Large frontal cone on primary target.
Reprimand - Raid-wide AoE damage; shield/heal through.
Midnight Haze Spawns two Midnight Haze adds on opposite sides of the arena. Destroy them before they reach each other or finish their casts.
Lead of the Underworld - Casts a line AoE marked by a line stack marker. Players must line up with the targeted player to share the damage. If a Midnight Haze add is still up, the targeted player can line up with the add so other players can still attack it.";
        }
    }
}