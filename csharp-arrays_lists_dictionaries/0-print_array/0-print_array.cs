﻿using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
        if (size < 0) {
		Console.WriteLine("Size cannot be negative");
		return null;
			}

		else if (size == 0) {
		Console.WriteLine();
		return new int[size];
				}
		else {
		int[] arr = new int[size];
		for (int i = 0; i < size; i++) {
			arr[i] = i;
			}
				
					}
		Console.WriteLine(string.Join(" ", arr);
		return arr;
		
    }    
    }
}
