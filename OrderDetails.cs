using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class OrderDetails
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public int OrderHeaderId { get; set; }
        [Required]

        public UserOrderHeader? OrderHeader { get; set; }
        [Required]

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]

        public Product? Product { get; set; }
        [Required]

        public int Count { get; set; }
        [Required]

        public double Price { get; set; } = 0;
    }
}
