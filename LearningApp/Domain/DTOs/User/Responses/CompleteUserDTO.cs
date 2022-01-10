using LearningApp.Domain.DTOs.Character.Responses;

namespace LearningApp.Domain.DTOs.User.Responses
{
    public class CompleteUserDTO
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }

        public ICollection<CharacterDTO>? Characters { get; set; }
    }
}
