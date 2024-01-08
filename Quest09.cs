using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rm_Linq_Assignment
{
    internal class Quest09
    {
        static void Main()
        {
            int[] numbers = { 22, 45, 34, 67, 89 };

            var evennum = (from n in numbers
                           where n % 2 == 0
                           select n);

            int count = evennum.Count(); 

            Console.WriteLine($"Count of even numbers:{count}");
            
            Console.WriteLine("Even numbers are :");


            foreach(var s in evennum)
            {
                Console.WriteLine(s);
            }

        }
    }
}
