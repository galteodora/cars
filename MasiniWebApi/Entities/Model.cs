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
        public string Year { get; set; }

        [Required]
        public string Mileage { get; set; }

        [Required]
        public string  Power { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required]
        public string Transimission { get; set; }

        public bool? Deleted { get; set; }
    }
}
