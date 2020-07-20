using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.ExternalModels
{
    public class CarsDTO
    {

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid ModelId { get; set; }

      ///  public AuthorDTO Author { get; set; }
    }
}
