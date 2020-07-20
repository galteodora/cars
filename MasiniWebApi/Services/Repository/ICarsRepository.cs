﻿using MasiniWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.Repository
{
    public interface ICarsRepository : IRepository<Cars>
    {
        
            Cars GetCarsDetails(Guid carsId);
    }
}
