using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Profiles
{
    public class CarsProfile : Profile
    {
        public CarsProfile()
        {
            CreateMap<Entities.Cars, ExternalModels.CarsDTO>();
            CreateMap<ExternalModels.CarsDTO, Entities.Cars>();

            CreateMap<Entities.Model, ExternalModels.ModelDTO>();
            CreateMap<ExternalModels.ModelDTO, Entities.Model>();
        }
    }
}
