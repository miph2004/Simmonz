﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simmonz.ViewModel.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public int Status { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int TransactionId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
