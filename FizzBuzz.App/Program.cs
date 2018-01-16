using System;

namespace FizzBuzz.App
{
    internal class Program
    {
        // version from 1 to 100
        private static void Main(string[] args)
        {
            IGetOutput output = new GetOutput();

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(output.Get(i));
            }
            Console.Write("Press any key to end");
            Console.ReadKey();
        }

        
    }
}
