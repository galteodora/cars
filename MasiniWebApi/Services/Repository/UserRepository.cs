using MasiniWebApi.Contexts;
using MasiniWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly CarsContext _context;

        public UserRepository(CarsContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<User> GetAdminUsers()
        {
            return _context.Users
                .Where(u => u.IsAdmin && (u.Deleted == false || u.Deleted == null))
                .ToList();
        }
    }
}
