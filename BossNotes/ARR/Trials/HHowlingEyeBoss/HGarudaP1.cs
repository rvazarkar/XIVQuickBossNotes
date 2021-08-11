namespace BossNotes.ARR.Trials.HHowlingEyeBoss
{
    public class HGarudaP1 : Boss
    {
        public HGarudaP1()
        {
            Name = "Phase 1";
            QuickStrategy =
                @"Hide behind rocks when Garuda shrieks. Kill adds ASAP. Stay away from rocks when possible to prevent damage.";
            InDepthStrategy =
                @"Tank should pull Garuda to the far north edge of the room. Rest of the party members should spread out and stay away from the stone pillars so her Friction and Wicked Wheel will not damage the pillars. Tanks should avoid Slipstream by running out of her line of sight.

Garuda will vanish, teleport and use either Mistral Song or Mistral Shriek once every 60 seconds or so. Players need to break line of sight by hiding behind the pillars whenever she uses either of those abilities.

When Garuda vanishes the first time, she will reappear at the far north edge of the room and cast Mistral Song. Players should break her line of sight by hiding behind the stone pillars. After about 60 seconds she will vanish and appear in the center of the room. She will then cast Mistral Shriek. Players need to hide behind the pillars and break line of sight with her.

After each Mistral Song or Mistral Shriek, Garuda will spawn a group of adds called Razor Plumes. Razor Plumes must be killed immediately. If they are left alive they will damage the stone pillars.

Use AoE abilities to kill Plumes.
When Garuda is at about 50% HP, she will use her ultimate ability, Aerial Blast. The ability deals massive amount of damage to your entire party. The amount of damage dealt depends on the number of stone pillars kept alive.

Keep stone pillars alive to reduce the damage of Garuda's ult.
Phase 2 begins after Garuda uses her ult.";
        }
    }
}