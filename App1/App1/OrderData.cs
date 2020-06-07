using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class OrderBundle
    {
        public int Id { get; set; }
        public decimal ProfitUSDT { get; set; }
        public decimal ProfitPerc { get; set; }
        public List<Order> Bundle { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string Coin { get; set; }
        public decimal Price { get; set; }
    }
}
