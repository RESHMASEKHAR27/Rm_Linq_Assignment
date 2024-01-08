using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{
    class Orders
    {
       

        public int OrderId { get; set; }
        public string ItemName { get; set; }

        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }


    }
    internal class Quest04

    {

        static void Main()
        {
            List<Orders> orderlist = new List<Orders>()
            {
                new Orders {OrderId=1,ItemName="ItemA",OrderDate =new DateTime(2020,05,01), Quantity=20},
                 new Orders {OrderId=2,ItemName="ItemB",OrderDate =new DateTime(2020,05,02), Quantity=8},
                  new Orders {OrderId=3,ItemName="ItemC",OrderDate =new DateTime(2020,05,03), Quantity=6},
                   new Orders{OrderId=4,ItemName="ItemD",OrderDate =new DateTime(2020,05,04), Quantity=8},
                    new Orders {OrderId=5,ItemName="ItemE",OrderDate =new DateTime(2020,05,05), Quantity=10 }

            };


            //order by month

            var x2 = from order in orderlist
                     orderby order.OrderDate.Month
                     group order by order.OrderDate.Month;

            foreach (var items in x2)
            {
                Console.WriteLine($"the order with same month {items.Key} is list below:");

                foreach (var n in items)
                {
                    Console.WriteLine($"orderId={n.OrderId},Itemname={n.ItemName},orderDate={n.OrderDate},Quantity={n.Quantity}");
                }
            }




           
            



        }
    }
}
