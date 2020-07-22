using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.ExternalModels
{
    public class CarsDTO
    {

        public Guid Id { get; set; }

        public string Make { get; set; }

        public string Name { get; set; }

        public Guid ModelId { get; set; }

        public ModelDTO Model { get; set; }

    }
}
