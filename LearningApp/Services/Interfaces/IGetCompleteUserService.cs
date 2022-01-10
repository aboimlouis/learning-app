using LearningApp.Domain.DTOs.User.Responses;

namespace LearningApp.Services.Interfaces
{
    public interface IGetCompleteUserService
    {
        public Task<List<CompleteUserDTO>> GetCompleteUser();
    }
}
