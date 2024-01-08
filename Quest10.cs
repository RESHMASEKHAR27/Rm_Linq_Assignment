using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{
    internal class Quest10
    {
        static void Main()
        {
            List<Orders> orderlist = new List<Orders>()
            {
                new Orders {OrderId=1,ItemName="ItemA", Quantity=20},
                 new Orders {OrderId=2,ItemName="ItemB",Quantity=8},
                  new Orders {OrderId=3,ItemName="ItemC", Quantity=6},
                   new Orders{OrderId=4,ItemName="ItemD",Quantity=8},
                    new Orders {OrderId=5,ItemName="ItemE",Quantity=10 }

            };

            var s = from o in orderlist
                    group o by o.ItemName into itemGroup
                    select new
                    {
                        ItemName = itemGroup.Key,
                        sumofquantities = itemGroup.Sum(o => o.Quantity)
                    };

            var i = (from r in s
                     orderby r.sumofquantities descending
                     select r).FirstOrDefault();

            Console.WriteLine("Sum of quantities for each item:");

            foreach(var r in s)
            {
                Console.WriteLine($"{r.ItemName}:{r.sumofquantities}");
            }

            Console.WriteLine($"Item with overall maximum orders:{i.ItemName}");



        }
    }
}
