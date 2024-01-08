using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{

    class Order
    {
      

        public int OrderId { get; set; }
        public string  ItemName { get; set; }

        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }


    }
    internal class Quest03

    {

        static void Main()
        {
            List<Order> orderlist = new List<Order>()
            {
                new Order {OrderId=1,ItemName="ItemA",OrderDate =new DateTime(2020,05,01), Quantity=20},
                 new Order {OrderId=2,ItemName="ItemB",OrderDate =new DateTime(2020,05,02), Quantity=8},
                  new Order {OrderId=3,ItemName="ItemC",OrderDate =new DateTime(2020,05,03), Quantity=6},
                   new Order {OrderId=4,ItemName="ItemD",OrderDate =new DateTime(2020,05,04), Quantity=8},
                    new Order {OrderId=5,ItemName="ItemE",OrderDate =new DateTime(2020,05,05), Quantity=10 }

            };

            //order by date
            var x = from order in orderlist
                         orderby order.OrderDate descending
                         select order;

            Console.WriteLine("Recent to Oldest Order:");


            foreach (var order in x)
            {
                Console.WriteLine($"ID: {order.OrderId} Name:{order.ItemName} Quantity:{order.Quantity} Date:{order.OrderDate}");
            }

            //order by quantity
            Console.WriteLine("Highest to Lowest Quantity:");

            x = from order1 in orderlist
                     orderby order1.Quantity descending
                     select order1;

            foreach (var order in x)
            {
                Console.WriteLine($"ID: {order.OrderId} Name:{order.ItemName} Quantity:{order.Quantity} Date:{order.OrderDate}");
            }
           
    

        }
    }
}
