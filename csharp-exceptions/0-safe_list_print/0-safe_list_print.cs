using System;
using System.Collections.Generic;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            List<int> new_list = new List<int>();
            int i = 0;
            try{

                for(i = 0; i < n; i++)
                    {
                        Console.WriteLine(myList[i]);
                    }
            }
            catch{}
            return (i);
        }
    }
