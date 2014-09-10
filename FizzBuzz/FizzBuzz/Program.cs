using System;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FizzBuzzClassLibrary.FizzBuzz(54735699);

            string[] result = f.RunFizzBuzz();

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();

        }
    }
}
