using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, ExternalModels.UserDTO>();
            CreateMap<ExternalModels.UserDTO, Entities.User>();
        }
    }
}
