namespace LearningApp.Domain.Models
{
    public class CharacterModel
    {
        public CharacterModel()
        {
            ID = 0;
            Name = "";
            Level = 0;
            UserID = 0;
            User = new UserModel();
        }

        public long ID { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public long UserID { get; set; }

        public UserModel User { get; set; }
    }
}
