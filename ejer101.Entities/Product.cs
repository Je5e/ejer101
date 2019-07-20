using System;
using System.Collections.Generic;
using System.Text;

namespace ejer101.Entities
{
  public  class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public List<OrderDetail> Items { get; set; }
    }
}
