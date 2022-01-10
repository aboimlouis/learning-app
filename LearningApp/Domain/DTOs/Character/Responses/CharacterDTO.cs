namespace LearningApp.Domain.DTOs.Character.Responses
{
    public class CharacterDTO
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? UserName { get; set; }
    }
}
