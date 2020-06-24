﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDTO>();
            CreateMap<Entities.City, Models.CityDTO>();
        }
    }
}
