using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	int digit = number % 10;
	string output = "";
	Console.Write($"The last digit of {number} is {digit} ");
	if (digit > 5) {
			output = "and is greater than 5";
			}
	else if (digit == 0) {
				output = "and is 0";
				}
	else {
		output = "and is less than 6 and not 0";
		}
	Console.WriteLine(output);
    }
}
