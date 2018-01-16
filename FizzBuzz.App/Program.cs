using System;

namespace FizzBuzz.App
{
    internal class Program
    {
        //Extend version
        private static void Main(string[] args)
        {
            var low = 1;
            var hi = 100;
            if (args.Length > 0)
                int.TryParse(args[0], out low);
            if (args.Length > 1)
                int.TryParse(args[1], out hi);

            IGetOutput output = new GetOutput();

            for (var i = low; i <= hi; i++)
            {
                Console.WriteLine(output.Get(i));
            }
            Console.Write("Press any key to end");
            Console.ReadKey();
        }


    }
}
