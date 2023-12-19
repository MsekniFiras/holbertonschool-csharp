using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
	for (int i = 0; i <= 99; i++) {
		if (i == 99) {
			Console.WriteLine($"{i:D2}");
				}
		else {
            Console.Write($"{i:D2}, ");
        }
	}
	}
    }
}
