using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
        {
            List<int> list3 = new List<int>();
            int result = 0;

            for (int i = 0; i < listLength; i++)
            {
                try{
                    result = list1[i] / list2[i];
                    list3.Add(result);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    list3.Add(0);
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
            return (list3);
        }
    }
