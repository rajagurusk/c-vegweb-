﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class PImages
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]

        public Product Product { get; set; }

        public string ImageUrl { get; set; }

        public string ProductName { get; set; }
    }
}
