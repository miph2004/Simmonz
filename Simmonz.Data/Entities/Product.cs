﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simmonz.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string ProductName { set; get; }
        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public int CategoryId { set; get; }
        public int DiscountId { get; set; }
        public string Description { set; get; }
        public string Image { get; set; }
        public DateTime CreatedDate { set; get; }
        public Category Category { get; set; }
        public Discount Discount { get; set; }
    }
}
