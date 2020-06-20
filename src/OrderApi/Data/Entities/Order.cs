﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Data.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        
        public string OrderCode { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public int UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; }
    }
}