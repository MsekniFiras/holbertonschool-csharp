using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		string str2 = $"{str}{str}{str}";
		ConsoleWriteLine(str2);
		ConsoleWriteLine(str.SubString(0,9));
        }
}
