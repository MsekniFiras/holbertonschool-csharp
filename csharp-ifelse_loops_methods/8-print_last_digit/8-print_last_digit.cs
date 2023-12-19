using System;
using Math;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
		int lastdigit = Abs.(number) % 10;
            Console.Write(lastdigit);
        }
    }
}
