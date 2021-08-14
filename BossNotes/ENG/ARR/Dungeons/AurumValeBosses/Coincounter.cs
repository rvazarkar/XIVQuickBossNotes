namespace BossNotes.ARR.Dungeons.AurumValeBosses
{
    public class Coincounter : Boss
    {
        public Coincounter()
        {
            Name = "Coincounter";
            QuickStrategy = @"Stand in midrange to be able to avoid all AoE. When his eye glows, move close";
            InDepthStrategy =
                @"Coincounter is the cyclops boss of the dungeon. He has a few powerful frontal AoE attacks. All non-tank players should stay away from the front of the boss. He has 2 types of 100-Tonze Swipe abilities. The first type can be identified when he holds his mace with only 1 of his hands. This is a frontal cone AoE attack. The second type can be identified when he holds his mace with 2 of his hands. This is a circular AoE attack that does an enormous amount of damage to all targets around him. Neither of these attacks have ground indicators. Since a few patches back, all of Coincounter's attacks have ground indicators. Players should interrupt or avoid these attacks.

At about half HP, Coincounter will start using Eye of the Beholder, a long range, frontal cone, AoE spell. Ranged damage dealers and healers should spread apart and avoid his Glower and Eye of the Beholder abilities if possible.

Abilities

10-Tonze Swipe is an instant frontal AoE attack that does moderate amount of damage.
100-Tonze Swipe (1 Hand) is a frontal cone AoE attack that does a large amount of damage to all targets hit.
100-Tonze Swing (2 Hand) is a circular AoE attack that does extremely large amount of damage to all targets close to the Cyclops.
Glower is a laser fired from the eye of Coincounter onto a random player. The player will take moderate amount of damage and become inflicted with the debuff Paralysis.
Eye of the Beholder is a long range, frontal, cone AoE spell that deals a moderate amount of damage and inflicts a DoT named Electrocution. Coincounter will face a random player and use the emote ""The Coincounter takes a moment to reconsider..."" before using this spell.
100-Tonze Swipe, 100-Tonze Swing and Eye of the Beholder can be interrupted with stuns.";
        }
    }
}