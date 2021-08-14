namespace BossNotes.ENG.Heavensward.Dungeons.DuskVigilBosses
{
    public class ToweringOliphant : Boss
    {
        public ToweringOliphant()
        {
            Name = "Towering Oliphant";
            QuickStrategy = @"When charged, get as far away as possible.";
            InDepthStrategy = @"Casts Rear, an AoE around himself
Roomwide Prehistoric Trumpet attack
Will occasionally target a player and use Rock of Ages (stun), Wooly Inspiration (conal pull attack), and/or Rout (charge) When Rout is used, one of the party (usually tank) can stand between the Oliphaunt and the targeted player to share the damage. This will result in less damage taken from the attack.";
        }
    }
}