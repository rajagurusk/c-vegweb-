﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ModelClasses.ViewModel
{
    public class SummeryVM
    {
        public IEnumerable<userCart>? userCartList { get; set; }
        public UserOrderHeader? orderSummery { get; set; }
        public string? cartUserId { get; set; }
        public IEnumerable<SelectListItem>? paymentOptions { get; set; }
        public double? PaymentPaidByCard { get; set; } = 0.0;
    }
}
