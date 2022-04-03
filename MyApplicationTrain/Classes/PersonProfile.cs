using AutoMapper;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace MyApplicationTrain.Classes
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonViewModel>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => $"{src.LastName}")
                )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}")
                )
                .ForMember(
                    dest => dest.UserName,
                    opt => opt.MapFrom(src => $"{src.UserName}")
                )
                .ForMember(
                    dest => dest.GroupId,
                    opt => opt.MapFrom(src => $"{src.GroupId}")
                )
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => $"{src.Id}")
                );
        }
    }
}
