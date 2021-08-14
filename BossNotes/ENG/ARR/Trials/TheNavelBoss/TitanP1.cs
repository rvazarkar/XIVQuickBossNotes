namespace BossNotes.ARR.Trials.TheNavelBoss
{
    public class TitanP1 : Boss
    {
        public TitanP1()
        {
            Name = "Phase 1";
            QuickStrategy = @"Stand just inside the red ring on the outside of the ring when Titan jumps.
DO NOT GET HIT BY LINE AoEs or walk off the edge. Free party members from rock prison.";
            InDepthStrategy = @"* don't fall off!
* Leap -- run to the edge of the red circle (not ON it or OUT of it) and face the center
* Landslide -- will knock you off; dodge out. If you can't dodge run towards him (it might help).
* rock gaols on random members; get them out";
        }
    }
}