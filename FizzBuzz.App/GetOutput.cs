using System;

namespace FizzBuzz.App
{
    public class GetOutput : IGetOutput
    {
        public string Get(int value)
        {
            var disibleBy3 = (value % 3 == 0);
            var disibleBy5 = (value % 5 == 0);

            return (disibleBy3 && disibleBy5)
                ? "FizzBuzz"
                : (disibleBy3)
                    ? "Fizz"
                    : (disibleBy5)
                        ? "Buzz"
                        : value.ToString();
        }
            
    }
}