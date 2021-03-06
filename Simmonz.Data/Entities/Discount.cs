﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simmonz.Data.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double DiscountPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
        public List<Product> Products { get; set; }
    }
}
