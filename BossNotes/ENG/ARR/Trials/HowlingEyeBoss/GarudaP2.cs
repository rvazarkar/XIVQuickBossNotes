namespace BossNotes.ARR.Trials.HowlingEyeBoss
{
    public class GarudaP2 : Boss
    {
        public GarudaP2()
        {
            Name = "Phase 2";
            QuickStrategy = @"Kill adds, don't stand in clouds. 
First jump, get behind boss. Second jump get as far away as possible.";
            InDepthStrategy =
                @"After Garuda uses her signature ability, Aerial Blast, phase 2 begins. In this phase Garuda uses Eye of the Storm to limit the size of the boss room to a circular center. Any player outside of the swirling vortex will take heavy damage from Eye of the Storm.

When teleports to the opposite side of the room, she will start casting Mistral Shriek. Players should run away from her as soon as possible. Everyone near her will take massive damage.

When Garuda teleports to the center of the room, she will start casting Mistral Song. Players need to get out of her line of sight by getting behind her to avoid the massive amount of damage.

At about a quarter HP, she will spawn Razor Plumes. These adds will do damage to random players. Kill them as soon as possible.";
        }
    }
}