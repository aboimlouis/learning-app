using AutoMapper;
using LearningApp.Domain.DTOs.Character.Responses;
using LearningApp.Domain.Models;

namespace LearningApp.Domain.Profiles.Character
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<CharacterModel, CharacterDTO>().ForMember(x => x.UserName, d => d.MapFrom(z => z.User.Name));
        }
    }
}
