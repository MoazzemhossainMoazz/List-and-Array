using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 20, 14, 27, 100, 90 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
