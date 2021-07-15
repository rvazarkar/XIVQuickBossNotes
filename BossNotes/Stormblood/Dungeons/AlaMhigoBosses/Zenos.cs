namespace BossNotes.Stormblood.Dungeons.AlaMhigoBosses
{
    public class Zenos : Boss
    {
        public Zenos()
        {
            Name = "Zenos Yae galvus";
            QuickStrategy = "Avoid outer edge of ring. When Zenos copies himself, stay close to him after tether to avoid Lightless Spark. Kill adds.";
            InDepthStrategy = @"The fight could be separated into three phases:

Phase 1: Pre-Aether Transfer.
Phase 2: Aether Transfer.
Phase 3: Post-Aether Transfer.
In all phases: Avoid touching the outer ring of the area. It would inflict some damage and one stack of Damage Down.

Zenos will, at around 15% HP, start charging his ultima. An Aether Transfer meter will indicate the time you have to kill the three adds.

There is no ""best"" order; just destroy them ASAP. However, The Swell will occasionally kick you into the outer ring.


            Abilities

                Art of the Storm: PBAoE centred on Zenos. Don't stay in it.
                Art of the Swell: PBAoE centred on Zenos. Knocks back, stay in it.
                Art of the Sword: Line AoE targeted at each player. Do not stack or you will get hit by more than one ray.
                Vein Splitter: Places 4 copies around Zenos. Large PBAoE around Zenos, followed by large PBAOEs around the copies. The AoEs of the copies do not overlap near Zenos. Zenos will jump one player and tether to that player. After a few seconds he will execute Lightless Spark.
                Lightless Spark: Cone AoE targeted at a chosen player.
                Concentrativity: Area wide AoE, high damage.

                ADDS

            Ame-no-Habakiri: Uses Art of the Sword.
                The Swell: Uses Art of the Swell.
                The Storm: Uses Art of the Storm.";
        }
    }
}