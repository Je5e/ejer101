using System;
using System.Collections.Generic;
using System.Text;

namespace ejer101.Entities
{
  public  class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int NumberTable { get; set; }

        public string CustomerName { get; set; }
        public int EmployeeId { get; set; }

        public List<OrderDetail> Items { get; set; }
    }
}
