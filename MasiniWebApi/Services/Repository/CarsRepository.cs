using MasiniWebApi.Contexts;
using MasiniWebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.Repository
{
    public class CarsRepository : Repository<Cars>, ICarsRepository
    {
        private readonly CarsContext _context;

        public CarsRepository(CarsContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Cars GetCarsDetails(Guid carsId)
        {
            return _context.Cars
                .Where(b => b.Id == carsId && (b.Deleted == false || b.Deleted == null))
                .Include(b => b.Model)
                .FirstOrDefault();
        }

        Cars ICarsRepository.GetCarsDetails(Guid carsId)
        {
            throw new NotImplementedException();
        }

        Cars ICarsRepository.GetCarsDetails(Guid carsId)
        {
            throw new NotImplementedException();
        }
    }
}
