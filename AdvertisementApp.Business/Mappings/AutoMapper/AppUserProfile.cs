﻿using AdvertisementApp.Dtos;
using AdvertisementApp.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile() 
        {
            CreateMap<AppUser, AppUserCreateDto>().ReverseMap();
            CreateMap<AppUser,AppUserUpdateDto>().ReverseMap();
            CreateMap<AppUser,AppUserListDto>().ReverseMap();   
        }
    }
}
