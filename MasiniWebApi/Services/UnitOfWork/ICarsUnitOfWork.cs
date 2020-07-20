using MasiniWebApi.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Services.UnitOfWork
{
    public interface ICarsUnitOfWork : IDisposable
    {
        ICarsRepository Car { get; }

        IModelRepository Models { get; }

        int Complete();
    }
}
