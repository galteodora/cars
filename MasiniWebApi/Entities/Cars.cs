using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MasiniWebApi.Entities
{
    public class Cars
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(2500)]
        public string Descriptiom { get; set; }

        [Required]
        public string ModelId { get; set; }

        [ForeignKey("ModelId")]
        public virtual Model Model { get; set; }

        public bool? Deleted { get; set; }
    }
}
