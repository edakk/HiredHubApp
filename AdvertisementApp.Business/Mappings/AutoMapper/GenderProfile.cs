using AdvertisementApp.Business.ValidationRules;
using AdvertisementApp.Dtos;
using AdvertisementApp.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Business.Mappings.AutoMapper
{
     public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            CreateMap<GenderCreateDto, Gender>().ReverseMap();
            CreateMap<GenderUpdateDto, Gender>().ReverseMap();
            CreateMap<GenderListDto, Gender>().ReverseMap();
        }
    }
}
