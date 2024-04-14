using System;

namespace _8_number_keys
{
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
}
