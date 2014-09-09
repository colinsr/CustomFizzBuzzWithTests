using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClassLibrary;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzClassLibrary.FizzBuzz f = new FizzBuzzClassLibrary.FizzBuzz(100);

            string[] result = f.RunFizzBuzz();

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();

        }
    }
}
