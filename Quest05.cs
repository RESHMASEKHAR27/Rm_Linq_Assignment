using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{
    class Item
    {
        public Item(string itemName, int price)
        {
            ItemName = itemName;
            Price = price;
        }

        public string ItemName { get; set; }

        public int Price { get; set; }
       
    }

    class TotalPrice
    {
        public TotalPrice(int orderId, string itemName, DateTime orderDate, int quantity, int tprice)
        {
            OrderId = orderId;
            ItemName = itemName;
            OrderDate = orderDate;
            Quantity = quantity;
            Tprice = tprice;
        }

        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }
        public int Tprice { get; set; }

    }

      

       


        internal class Quest05
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




            var x = from f in orderlist
                    join l in list
                    on f.ItemName equals l.ItemName
                    let i=f.Quantity * l.Price
                    select new TotalPrice(f.OrderId, f.ItemName,f.OrderDate,f.Quantity,i);

            var n = from t in x
                    orderby t.OrderDate
                    group t by t.OrderDate.Month;



            foreach (var item in n)
            {
                Console.WriteLine($"month={item.Key}");

                foreach (var o in item)
                {
                    Console.WriteLine($"orderId={o.OrderId},Itemname={o.ItemName},orderDate={o.OrderDate},Quantity={o.Quantity}, Totalprice={o.Tprice}");
                }
            }
        }
    }
}
