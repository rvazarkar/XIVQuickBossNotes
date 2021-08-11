namespace BossNotes.Stormblood.Trials.GreatHuntBoss
{
    public class RathalosP3 : Boss
    {
        public RathalosP3()
        {
            Name = "Phase 3";
            QuickStrategy = @"The only way to heal in this phase is Mega Potions.
If Rathalos turns towards you, sidestep.
Fireball is a stack marker.
Healers should cleanse frequently.";
            InDepthStrategy =
                @"After Rathalos has bathed the arena in flames, the background music will change, and the outer-arena will receive a flaming makeover. All players will now receive a debuff – Scalebound – which will reduce all healing received by players to 0 (except Mega Potions). As a result, each player should consider drinking a Mega Potion if their HP reaches medium or low levels. Party shielding, however, is unaffected by this debuff and can be very useful for mitigating burns, poison, or even some direct attacks from Rathalos himself.

From here on, Rathalos will assault players from the air, and a ""Down Counter"" will be displayed in the form of a Duty Gauge. This gauge will gradually fill up any time a cooldown is used against Rathalos. Once filled, Rathalos will immediately be knocked out of the air and remain prone for some time, allowing players to attack (and eventually break) his tail, inflicting substantial damage to Rathalos himself. Conversely, Rathalos' overall defence will be much higher while in the air, but not when downed; hence players must try to knock Rathalos down and perform as much damage as possible while he is vulnerable. If you wish to use a damaging Limit Break, consider doing so when Rathalos is knocked down, as using it while he is in the air will be dramatically less effective.

Much like the previous phases, Rathalos will continuously attack random players with various abilities in no particular order and with limited visual indicators for as long as he is active.

Claw Swipe is another rush attack similar to Charging Bite. After turning towards a random player (regardless of distance) and elevating slightly, Rathalos will swoop at that player with his claws after a brief delay. Players slashed by Rathalos' claws will be inflicted with a dispellable poison, a brief stun, moderate damage and a knockback. Just like Charging Bite, players can avoid this attack by quickly side-stepping out of his way before he charges.
Mangle and Sweeping Flames are frontal-cone AoE's, indicated by Rathalos rearing its head and displaying its flaming mouth for a brief moment. To avoid these, players can either move behind Rathalos, move to his flanks, or move out of range entirely.
Fireball, unlike phase 1, is now a sharable stack marker. After a brief delay, Rathalos will spit a fireball at the stack-marked player, leaving behind a persistent puddle of flame on the ground that will inflict burns on everyone sharing the damage and anyone who passes through puddles afterwards. If this ability targets a tank instead of a healer or damage-dealer, the tank may choose to mitigate the fireball by themself using defensive cooldowns. Despite healers being unable to heal other players during this final phase, they can still use Esuna to remove the resulting burns, or use shield spells to help mitigate incoming damage.
At this point, Rathalos will continue to cycle through these abilities until he is defeated, the party wipes or the 60-minute duty timer expires.";
        }
    }
}