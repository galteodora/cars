using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Entities
{
    public class Model
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }


        public bool? Deleted { get; set; }
    }
}
