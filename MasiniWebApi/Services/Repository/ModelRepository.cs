using MasiniWebApi.Contexts;
using MasiniWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.Repository
{
    public class ModelRepository : Repository<Model>, IModelRepository
    {
            private readonly CarsContext _context;

            public ModelRepository(CarsContext context) : base(context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }
    }
}
