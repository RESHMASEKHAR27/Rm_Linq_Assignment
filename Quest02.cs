using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{

    class Player
    {
        public Player(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; set; }
        public string Country { get; set; }
    }
    internal class Quest02
    {
        static void Main()
        {
            List<Player> list1 = new List<Player>()
            {
                new Player ("player1 ","india"),
                new Player("player2","us"),
            };

            List<Player> list2 = new List<Player>()
            {
                new Player ("player 3","india"),
                new Player("player4","uk"),
            };

            var x = from l1 in list1
                    from l2 in list2
                    where l1.Country != l2.Country
                    select new { op = l1.Name, op1 = l2.Name };
            foreach (var p in x)
            {
                Console.WriteLine($"{p.op}*{p.op1}");
            }
        }
    }
}
