﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ejer101.Entities
{
  public  class OrderDetail
    {

        public int Id { get; set; }
        public int ProductId { get; set; }

        public int Cantidad { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

    }
}
