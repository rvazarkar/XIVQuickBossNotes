namespace BossNotes.Stormblood.Dungeons.BurnBosses
{
    public class MistDragon : Boss
    {
        public MistDragon()
        {
            Name = "Mist Dragon";
            QuickStrategy = @"When the boss spawns adds, DO NOT ATTACK THE BOSS. Kill the adds.
Free players trapped in mist by attacking them. Drop star AoE in the corner.";
            InDepthStrategy =
                @"Rime Wreath: High party-wide damage, mitigate and heal through this. The Mist Dragon will spam this attack when it isn't casting anything else.
Frost Breath: Two distinct attacks cast one after another. The first attack targets a non-tank and damages everything in a line from the boss to the targeted player. The second marks the tank and hits a wide arc in the tank's direction. Several ice puddles appear in the areas the attacks hit. The attack itself inflicts a dispellable Frostbite, while the puddles also inflict Frostbite for as long as a player stands in them.
Fog Plume: Star area of effect attack on a random target. After the initial attack hits, four arena-wide line AoEs originating from the first attack's landing point will appear. Later on in the fight, the Mist Dragon will target two players with this ability. In addition to taking damage, the attack traps those hit by it in blocks of ice called Mist. The Mist prevents movement, but can be attacked by other players to free those trapped inside.
Vaporize: The Mist Dragon turns into mist in the center of the arena. Three Draconic Regard adds will spawn and tether to the Mist Dragon. Attempting to attack the Mist Dragon in this form will cause it to counterattack, freezing the offending player in Mist.
Cold Fog: An area of effect centered on the Mist Dragon's misty form that gradually expands. Slaying all of the Draconic Regard adds will prevent the attack's area from expanding further.
Deep Fog: The arena becomes shrouded in thick fog that gives an indefinite Dropsy debuff, and the Mist Dragon leaves the arena. The Mist Dragon will spray a wide line through the center of the arena with ice, dealing high damage and freezing anyone caught in it. The boss will swoop twice before the fog disperses.
Touchdown: A proximity marker will appear on the ground, indicating where the Mist Dragon is about to slam down. Free anyone still trapped in Mist and move as quickly as you can to the opposite side of the arena.";
        }
    }
}