using System;

namespace FizzBuzz.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IGetOutput output = new GetOutput();

            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(output.Get(i));
            }
        }
    }
}
