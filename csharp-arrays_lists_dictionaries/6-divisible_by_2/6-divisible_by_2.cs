using System;
using System.Collections.Generic;

    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
             int i;
            List<bool> list = new List<bool>();
            for (i = 0; i < myList.Count; i++)
            {
                if (myList[i] % 2 == 0)
                    list.Add(true);
                else
                    list.Add(false);
            }
            return list;
        }
    }
