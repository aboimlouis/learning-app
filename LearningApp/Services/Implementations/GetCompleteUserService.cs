using AutoMapper;
using LearningApp.Data.Repositories.Interfaces;
using LearningApp.Domain.DTOs.User.Responses;
using LearningApp.Domain.Models;
using LearningApp.Services.Interfaces;

namespace LearningApp.Services.Implementations
{
    public class GetCompleteUserService : IGetCompleteUserService
    {
        private IUserRepository _userRepository { get; set; }
        private IMapper _mapper { get; set; }
        public GetCompleteUserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<CompleteUserDTO>> GetCompleteUser()
        {
            return _mapper.Map<List<UserModel>, List<CompleteUserDTO>>(await _userRepository.GetCompleteUser());
        }
    }
}
