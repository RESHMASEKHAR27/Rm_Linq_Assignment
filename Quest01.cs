namespace Rm_Linq_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbrs = { 3, 4, 5, 6, 7,9,8 };

            var x= from f in numbrs
                   where f*f*f >100 && f*f*f < 1000
                   select f*f*f;

            foreach(var num in x)
            {
                Console.WriteLine(num);
            }
        }
    }
}
