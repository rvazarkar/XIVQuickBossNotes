namespace BossNotes.ARR.Trials.UrthsFountBoss
{
    public class Odin : Boss
    {
        public Odin()
        {
            Name = "Odin";
            QuickStrategy = @"Kill ""Gungnir"" as fast as possible, cleanse slow when applied.
Don't overlap purple circles. Pop cooldowns when he casts ""Shin-Zantetsuken"" (DPS race)";
            InDepthStrategy =
                @"Hall of Sorrow: Raid-wide magical damage, unavoidable. Hits for about ~1700 damage. Casts periodically.

Hall of Lead: Targets 3 random raid members (never MT) for magical damage with a medium AoE. Hits for about ~1500 damage, unavoidable. Inflicts 10s Slow on all affected targets. Can be cleansed.

Hall of Stone: Targets random raid members with a ground-based AoE. Can be avoided, you have ~2s to run out. Number of raid members targeted increases as fight drags on. Will create two circles from the second or third cast on. Hits for about ~2600 damage, and inflicts 8s Petrifaction on hit targets. Cannot be cleansed.

Einherjar: Raid-wide unavoidable magic attack. Has a 3s cast time. First Einherjar is followed by Gungnir immediately after, recommend Divine Seal->Medica II for WHM. Second Einherjar has no Gungnir near. Third Einherjar happens after the second Gungnir's gone down and after Odin uses Sanngetal. Hits for about ~2700 magical damage, and inflicts a 30s DOT on the entire raid; this DOT can be cleansed. Parser only registers ""unknown dot tick"", so exact damage from these is unknown, but I think about ~300 damage. Additional data required.

Valknut: Medium-sized AoE around Odin. Can be avoided. Hits for about ~6,000 damage. Happens periodically, but guaranteed after each Gungnir. Seems % based, a la 'Gravity' - does terrifying damage to unsynced characters.

Sanngetall: Death-sentence-like attack. Single-target damage against whoever has highest aggro (usually tank). Hits for about ~8000 physical damage unmitigated. Should be Virused, as it happens once every minute or so; off-tank can also provoke right after it hits. Has a 3s cast time. (Need confirmation on damage numbers.)

Gagnrath: Attributed to Gungnir instead of Odin, so damage can't be reduced. Red spears appear on the outside of the arena and dash in a straight line across. Avoidable. Two patterns: Three lines horizontal towards east, then three lines towards west. Two lines from North and East through centre, then two lines from North-East and South-East through centre, both to opposite side, so two crosses. Initially will only have one dash and not the second one, later on will be two. Valknut often happens during these Gagnrath attacks. Hits for about ~2700 physical damage, and knocks its targets back about 1/3rd of arena. Can be Parried, Manawalled, etc.

Gungnir: Three random targets (never MT) are targeted with a large purple circle AoE that centres on target (moves when you move). After 3~5s, Gungnirs drop down on the targets for ~1300 physical damage to everyone in AoE. Can be mitigated with Parry, Manawall, etc. Note that Hall of Sorrow goes off at the same time as the Gungnirs go off, for ~3000 physical and magical damage to Gungnir targets total. Gungnir also inflicts a raid-wide DOT field for as long as the three spears remain alive. Unknown how much damage this DOT does. Cannot be cleansed. Need data on Gungnir HP -- Roughly 30k hp.

Auto-attack: Hits for about 1300 slashing physical damage. No cleave apparently?

Shin-Zantetsuken: Unavoidable 99,999 damage to the entire raid. Cannot be interrupted. Starts the cast at about 15% HP, or after 6 minutes. Not sure on how much time you have to kill him after he starts cast, but eyeballed at about ~30s. XivDB also says the cast time is 30s. There's a 7s or so cast animation afterwards during which you can still kill him to acquire a win. Shortly after this, even if this attack is weathered due to unsync, the duty will reset.";
        }
    }
}