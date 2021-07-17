namespace BossNotes
{
    public class DungeonSelectionIndex
    {
        public DungeonSelectionIndex(int selectedExpansion, int selectedType, int selectedInstance)
        {
            SelectedExpansion = selectedExpansion;
            SelectedType = selectedType;
            SelectedInstance = selectedInstance;
        }

        public int SelectedExpansion { get; }
        public int SelectedType { get; }
        public int SelectedInstance { get; }
    }
}