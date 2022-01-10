using LearningApp.Domain.Models;

namespace LearningApp.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<UserModel>> GetCompleteUser();
    }
}
