namespace BossNotes.ARR.Dungeons.DzemaelBosses
{
    public class AllSeeingEye : Boss
    {
        public AllSeeingEye()
        {
            Name = "All-seeing Eye";
            QuickStrategy = @"Stand near crystals to get the buff. Move between crystals when they fade.";
            InDepthStrategy = @"All-seeing Eye is the first boss of Dzemael Darkhold. This Ahriman Boss has an ability called Eyes on Me. The ability does heavy damage to all players near it. Players with the buff Crystal Veil are immune to this damage. Players receive this buff when they are near the glowing crystals. The effect of the crystals fade over time. Players need to move to a new cluster of crystals when this occurs.

Throughout the fight, All-seeing Eye will spawn adds. Avoid Adds AoE attacks and kill them asap.

Fight the All-seeing Eye near the crystal clusters to gain the Crystal Veil buff. When ""The power of the crystal begins to dim"" appears on screen, move to a new crystal cluster immediately. The All-seeing Eye is invulnerable to attack except when it is near a cluster of crystals.
Abilities

Dread Gaze is a frontal cone AoE attack that inflicts the debuff Paralysis to all targets hit.
Cursed Gaze is a frontal cone AoE attack that inflicts the debuff Amnesia to all targets hit.
Eyes on Me is an ability that deals heavy damage all players near the All-seeing Eye. Players under the effect of Crystal Veil are immune to this damage.";
        }
    }
}