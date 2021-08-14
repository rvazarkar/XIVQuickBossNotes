namespace BossNotes.ARR.Dungeons.PraetoriumBosses
{
    public class Nero : Boss
    {
        public Nero()
        {
            Name = "Nero tol Scaeva";
            QuickStrategy = @"Tank the boss at the exit door to save time and prevent knockbacks.";
            InDepthStrategy =
                @"The boss room is surrounded by an electrical field. While in the electrical field, players will take damage over time. All non-tank players should not be in front of Nero tol Scaeva. Ranged damage dealers and healers should stay out of the melee range. Occasionally, Magitek Death Claw add will spawn. A purple line connects the claw to a random player. The targeted player should move away from the Death Claw while rest of the players should kill the claw as soon as possible. If the claw reaches the targeted player, the player will be knocked into the electrical field.

Abilities

Spine Shatter is an instant melee attack that deals a small amount of damage.
Sideswing is an instant frontal attack that deals damage to all players in front of the Nero tol Scaeva.
Wheel of Suffering is an instant attack that deals damage to all players near the boss.
Iron Uprising is an instant frontal attack that deals a moderate amount of damage to all players in front of Nero tol Scaeva and knocks them back.
Augmented Shatter is an instant attack that deals a moderate amount of damage to one random player. When performing this attack, Nero tol Scaeva leaps into air and strikes the ground with its hammer.
Augmented Uprising is a frontal AoE attack that deals a moderate amount of damage and inflicts the debuff Heavy to all players hit. Additionally, this ability knocks all players backward.
Augmented Suffering is an circular AoE attack that deals moderate amount of damage, inflicts the debuff Heavy and knocks back all players around the boss.
Adds

Magitek Death Claw targets one player with a purple line. If the claw reaches the targeted player, that player will be knocked into the electrical field.
Targeted player should run away from the claw while rest of the players should kill it.";
        }
    }
}