using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{
    internal class Quest07
    {
        static void Main()
        {
            List<Orders> orderlist = new List<Orders>()
            {
                new Orders {OrderId=1,ItemName="ItemA",OrderDate =new DateTime(2020,05,01), Quantity=20},
                 new Orders {OrderId=2,ItemName="ItemB",OrderDate =new DateTime(2020,05,02), Quantity=8},
                  new Orders {OrderId=3,ItemName="ItemC",OrderDate =new DateTime(2020,05,03), Quantity=6},
                   new Orders{OrderId=4,ItemName="ItemD",OrderDate =new DateTime(2020,05,04), Quantity=8},
                    new Orders {OrderId=5,ItemName="ItemE",OrderDate =new DateTime(2024,04,05), Quantity=100 }

            };

           

            bool x = (from s in orderlist
                     where s.Quantity > 0
                     select s).Count() == orderlist.Count;

           
                Console.WriteLine($"Check if all the quantities in the Order collection is > 0:{x}");

            var f = (from v in orderlist
                     orderby v.Quantity descending
                     select v.ItemName).FirstOrDefault();

            Console.WriteLine($"Item with largest Quantity:{f}");

            var c = from z in orderlist
                    where z.OrderDate.Year < DateTime.Now.Year || (z.OrderDate.Year == DateTime.Now.Year && z.OrderDate.Month == 1)
                    select z;

            bool b=c.Any();

            Console.WriteLine($"Orders placed before January of {DateTime.Now.Year} ? {b}"); 

        }
    }
}
