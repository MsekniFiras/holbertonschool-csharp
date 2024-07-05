using System;

    class Int
    {
        public static void divide(int a, int b)
        {
            int x = 0;
            try 
            {
               x = a / b;
            }

            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine($"{a} / {b} = {x}");
            }
        }
    }
