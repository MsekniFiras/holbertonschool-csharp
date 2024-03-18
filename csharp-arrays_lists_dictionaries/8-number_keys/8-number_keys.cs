using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static int NumberOfKeys(Dictionary<string, string> myDict)
        {
             int i = 0;
            foreach(var elemnet in myDict)
                i++;
            return i;
        }
    }

