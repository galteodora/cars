using MasiniWebApi.Contexts;
using MasiniWebApi.Entities;
using MasiniWebApi.Services.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.UnitOfWork
{
    public class CarsUnitOfWork : ICarsUnitOfWork
    {
        private readonly CarsContext _context;

        public CarsUnitOfWork(CarsContext context, ICarsRepository cars, IModelRepository model)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Car = cars ?? throw new ArgumentNullException(nameof(context));
            Models = model ?? throw new ArgumentNullException(nameof(context));
        }

        public ICarsRepository Car { get; }

        public IModelRepository Models { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
