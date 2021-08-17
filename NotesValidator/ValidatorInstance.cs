using BossNotes;

namespace NotesValidator
{
    public class ValidatorInstance
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public ValidatorBoss[] Bosses { get; set; } = new ValidatorBoss[0];
        public ushort ZoneID { get; set; }
    }
}