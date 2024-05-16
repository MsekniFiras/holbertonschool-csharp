using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            LinkedList<int> nlist = new LinkedList<int>();
        if (size < 0)
        {
            return nlist;
        }
        for (int i = 0; i < size; i++)
        {
            nlist.AddLast(i);
        }
        foreach (int item in nlist) 
        {

            Console.WriteLine(item);
        }
        return nlist;
        }
    }
