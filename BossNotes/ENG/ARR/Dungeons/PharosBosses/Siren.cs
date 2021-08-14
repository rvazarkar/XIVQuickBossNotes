namespace BossNotes.ARR.Dungeons.PharosBosses
{
    public class Siren : Boss
    {
        public Siren()
        {
            Name = "Siren";
            QuickStrategy = @"Heal party members that get ""Siren Song"" to full to remove the debuff.
Kill Sergeants ASAP. When boss vanishes, run to middle.";
            InDepthStrategy =
                @"Tank: Position the boss near the center of the room and be ready to pick up the Zombie Storm Privates. Kite the Zombie Storm Sergeants.

Healer: A debuff, Siren Song (Ghost Face Icon), will be placed on random party members. You have 12 seconds to heal them to full HP or they will become charmed for a period of time. You should also remove the bleed debuff, which is applied to the tank periodically.

Along with Storm Privates, Zombie Storm Sergeants will also spawn. These will slowly move towards a target and should be kited while the DPS kill them. If they reach their target, they will stun them. When Siren vanishes, she will either appear in the center of the room or on an edge. If she is in the middle, stack on top of her to avoid getting hit with an AoE Siren Song debuff. If she is on an edge, move out from in front of her to avoid a charge.

Interrupt Lunatic Voice to avoid an AoE healing reduction debuff. It is remove it with Esuna/Leeches if it does go off.";
        }
    }
}