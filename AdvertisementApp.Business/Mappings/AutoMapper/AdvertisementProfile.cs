﻿using AdvertisementApp.Business.ValidationRules;
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
    public class AdvertisementProfile : Profile
    {
        public AdvertisementProfile()
        {
            CreateMap<Advertisement, AdvertisementCreateDto>().ReverseMap();
            CreateMap<Advertisement, AdvertismentUpdateDtoValidator>().ReverseMap();
            CreateMap<Advertisement,AdvertisementListDto>().ReverseMap();


        }
    }
}
