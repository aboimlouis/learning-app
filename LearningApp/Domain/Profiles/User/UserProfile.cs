using AutoMapper;
using LearningApp.Domain.DTOs.User.Responses;
using LearningApp.Domain.Models;

namespace LearningApp.Domain.Profiles.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, CompleteUserDTO>();
        }
    }
}
