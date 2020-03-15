using System;
using System.Linq;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 50);

            var groups = numbers.GroupBy(x => x % 2);

            foreach (var group in groups)
            foreach (var number in group)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
