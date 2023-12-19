using System;

namespace _7_islower
{
    class Character
    {
        public static bool IsLower(char c)
        {
	int character = (int)c;
	if(character >= 97 && character <= 122) {
		return true;
		}
	else {
		return false;
		}
    }
    }
}
