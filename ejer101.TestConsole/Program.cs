using System;
using ejer101.DAL;
using ejer101.Entities;

namespace ejer101.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Order nueva = new Order
            {

               
                CreatedAt = DateTime.Today,
                CustomerName = "Juan Perez",
            };
            nueva.Items = new System.Collections.Generic.List<OrderDetail>();
            nueva.Items.Add(
                new OrderDetail {
                   
                    Cantidad =2,
                    Product = new Product { ProductName="Pasta"}

                });
            nueva.Items.Add(
               new OrderDetail
               {
                   
                   Cantidad = 1,
                   Product = new Product { ProductName = "Coffe" }

               });

            NWindContext context = new NWindContext();
            context.Orders.Add(nueva);
            context.SaveChanges();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
