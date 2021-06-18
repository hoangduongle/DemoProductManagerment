using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProductManagerment.Entity
{
    public class Category
    {
        [Required]
        [Key]
        public int cateId { get; set; }

        [Required]
        [StringLength(50)]
        public string cateName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
