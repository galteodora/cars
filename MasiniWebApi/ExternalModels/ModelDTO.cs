using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.ExternalModels
{
    public class ModelDTO
    {
        public Guid Id { get; set; }

        public string Year { get; set; }

        public string Mileage { get; set; }

        public string Power { get; set; }

        public string Fuel { get; set; }

        public string Transimission { get; set; }

    }
}
