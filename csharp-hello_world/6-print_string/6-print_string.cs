using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		string str2 = $"{str}{str}{str}";
		Console.WriteLine(str2);
		Console.WriteLine($"{str.SubString(0,9)}");
        }
}
