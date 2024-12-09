using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Product
    {
        //private const string V = @"^[0-9]+(\.[0-9]{1,2})";

        [Key]


        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,999,ErrorMessage = "Range ₹1 to ₹999.99 only")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Please Enter Two Digits After Decimal.")]


        public double Price {  get; set; }
        [Required]
        [MaxLength(2000,ErrorMessage ="Length Can't Exit More Than 30 Characters ")]
        public string Description { get; set; }

        public ICollection<PImages>?ImgUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public string? HomeImgUrl { get; set; }


    }
}
