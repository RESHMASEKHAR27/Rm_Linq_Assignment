using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{

   

    internal class Quest06
    {
        static void Main()
        {
            List<Orders> orderlist = new List<Orders>()
            {
                new Orders {OrderId=1,ItemName="ItemA",OrderDate =new DateTime(2020,05,01), Quantity=20},
                 new Orders {OrderId=2,ItemName="ItemB",OrderDate =new DateTime(2020,05,02), Quantity=8},
                  new Orders {OrderId=3,ItemName="ItemC",OrderDate =new DateTime(2020,05,03), Quantity=6},
                   new Orders{OrderId=4,ItemName="ItemD",OrderDate =new DateTime(2020,05,04), Quantity=8},
                    new Orders {OrderId=5,ItemName="ItemE",OrderDate =new DateTime(2020,04,05), Quantity=10 }

            };


            Item[] list = {
                new Item("ItemA",200),
                new Item("ItemB",50),
                new Item ("ItemC",40),
                new Item("ItemD",10),
                new Item("ItemE",67)
            };

            var result = from s in orderlist
                         join e in list
                         on s.ItemName equals e.ItemName

            select new { id = s.OrderId, Name = s.ItemName, date = s.OrderDate, price = s.Quantity * e.Price };


            var n = from t in result
                    orderby t.date
                    group t by t.date.Month;

            foreach (var item in n)
            {
                Console.WriteLine($"month={item.Key}");

                foreach (var o in item)
                {
                    Console.WriteLine($"orderId={o.id},Itemname={o.Name},orderDate={o.date}, Totalprice={o.price}");
                }
            }



        }
    }
}
