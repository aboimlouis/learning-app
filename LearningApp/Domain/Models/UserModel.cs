namespace LearningApp.Domain.Models
{
    public class UserModel
    {
        public UserModel()
        {
            ID = 0;
            Name = "";
            UserName = "";
            Password = "";
            Characters = new List<CharacterModel>();
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<CharacterModel> Characters { get; set; }
    }
}
