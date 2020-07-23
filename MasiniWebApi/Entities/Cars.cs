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
        public Guid id { get; set; }
       
        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public Guid ModelId { get; set; }

        [ForeignKey("ModelId")]
        public virtual Model Model { get; set; }

        public bool? Deleted { get; set; }
    }
}
