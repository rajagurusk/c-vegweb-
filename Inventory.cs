﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Inventory
    {
        [Key]


        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 999, ErrorMessage = "Range ₹1 to ₹999.99 only")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Please Enter Two Digits After Decimal.")]


        public double Purchase_Price { get; set; }
        public string Category { get; set; }
        public int Quanlity { get; set; }
    }
}
