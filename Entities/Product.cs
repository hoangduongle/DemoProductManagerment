using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProductManagerment.Entity
{
    public class Product
    {
        [Required]
        [Key]

        public int proId { get; set; }

        [Required]
        [StringLength(50)]
        public string proName { get; set; }

        [Required]
        [Range(50,999)]
        public double price { get; set; }

        [Required]
        public int amount { get; set; }

        [ForeignKey("category")]
        public int cateId { get; set; }

        public virtual Category category { get; set; }

    }
}
