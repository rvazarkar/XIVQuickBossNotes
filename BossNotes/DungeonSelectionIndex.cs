namespace BossNotes
{
    public class DungeonSelectionIndex
    {
        public int SelectedExpansion { get; private set; }
        public int SelectedType { get; private set; }
        public int SelectedInstance { get; private set; }

        public DungeonSelectionIndex(int selectedExpansion, int selectedType, int selectedInstance)
        {
            SelectedExpansion = selectedExpansion;
            SelectedType = selectedType;
            SelectedInstance = selectedInstance;
        }
    }
}