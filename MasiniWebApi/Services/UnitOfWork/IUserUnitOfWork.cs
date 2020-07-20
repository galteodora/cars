using MasiniWebApi.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.UnitOfWork
{
    public interface IUserUnitOfWork : IDisposable
    {
        
        IUserRepository Users { get; }

        int Complete();
    }
}
