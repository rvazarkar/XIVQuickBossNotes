namespace BossNotes.ARR.Dungeons.SunkenTempleBosses
{
    public class Teratotaur : Boss
    {
        public Teratotaur()
        {
            Name = "Teratotaur";
            QuickStrategy =
                "Kill adds ASAP to prevent final sting. Interrupt if needed. When boss uses Mortal Ray, step on glowing orange platform";
            InDepthStrategy =
                @"The boss fight has multiple instant death mechanics, involving adds and three square plates positioned around the arena.

Instant Death Mechanics
Occasionally he summons a pair of Dung Wespes. The Wespes are like the Temple Bees found throughout the area or Palace Hornets from the Palace of the Dead, and will cast Final Sting if they are not defeated quickly. Final Sting deals damage equal to ninety percent of the target's maximum health (e.g. 100 Max HP = 90 damage). Whilst this is survivable from full health, the Teratotaur may finish off a wounded Tank quite easily - or the Wespes may both target the same character and deal extreme damage to them. Either defeat the wespes before they cast Final Sting or interrupt the ability with stuns and silences.
When Teratotaur is under 50% HP, he will periodically ""begin to growl"", and then use Mortal Ray. This room-wide AoE ability places the Doom debuff on your entire party; the debuff lasts 12 seconds and will instantly kill anyone still afflicted by it when the timer ends. Players can remove this debuff by stepping on the square plate that is glowing orange; only one of them will turn orange at a time. It may be preferable to tank the Teratotaur in the middle of the room between all three plates so that they are within easy reach of the Tank and Melee DPS, but the duration is long enough that it should not be a problem.
            Other Abilities
            Frightful Roar is a circular AoE ability that causes Physical Vulnerability Up on all of the targets hit.
                Mow is a frontal cone AoE attack that inflicts poison on targets hit.
                Triclip is an instant attack that does heavy damage to its primary target.";
        }
    }
}