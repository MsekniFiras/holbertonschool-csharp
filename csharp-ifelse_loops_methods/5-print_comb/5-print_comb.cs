﻿using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
	for (i = 0; i <= 99; i++) {
		if (i == 99) {
			Console.WriteLine($"{0:D2}", i);
				}
		else {
            Console.WriteLine($"{0:D2}, ", i);
        }
	}
	}
    }
}
