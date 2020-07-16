using MasiniWebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Contexts
{
    public class CarsContext :DbContext
    {
        public CarsContext(DbContextOptions<CarsContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Cars> Car { get; set; }
    }
}
