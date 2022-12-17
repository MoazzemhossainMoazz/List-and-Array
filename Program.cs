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
                //foreach (var number in numbers)
                //{
                //    Console.WriteLine(number);
                //}
                ///Console.WriteLine(numbers[3]);

            List<string> names = new List<string>();

            names.Add("Mr.");
            names.Add("John");
            names.Add("Doe");

            names.RemoveAt(2); //Remove 2nd number name
            names.Remove("Mr."); //Remove similer this name

            for(int i = 0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
