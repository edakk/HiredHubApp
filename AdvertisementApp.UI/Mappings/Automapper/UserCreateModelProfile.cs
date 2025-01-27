using AdvertisementApp.Dtos;
using AdvertisementApp.UI.Models;
using AutoMapper;

namespace AdvertisementApp.UI.Mappings.Automapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
        }
    }
}
