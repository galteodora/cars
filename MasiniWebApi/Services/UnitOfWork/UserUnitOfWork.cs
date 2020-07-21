using MasiniWebApi.Contexts;
using MasiniWebApi.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.UnitOfWork
{
    public class UserUnitOfWork : IUserUnitOfWork
    {
        private readonly CarsContext _context;

        public UserUnitOfWork(CarsContext context, IUserRepository users)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Users = users ?? throw new ArgumentNullException(nameof(context));
        }

        public IUserRepository Users { get; }


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
