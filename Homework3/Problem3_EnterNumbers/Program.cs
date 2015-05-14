using System;

class Program
{
    static void Main()
    {
        ReadNumber(10, 100);
    }

    static void ReadNumber(int start, int end)
    {
        int n = 0;
        int m = 0;
        Console.WriteLine("Enter a number between {0} and {1}", start, end);
        for (int i = 0; i < 10; i++)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n > start && n < end)
                {
                    m = n;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format! Enter an integer.");
                i--;
                Console.WriteLine("Enter a number between {0} and {1}", m, end);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big! Enter a 32-bit integer.");
                i--;
                Console.WriteLine("Enter a number between {0} and {1}", m, end);
            }
            finally
            {
                if (n <= start || n >= end) 
                {
                    Console.WriteLine("The number you just entered isn't between between {0} and {1}", m, end);
                    i--;
                    Console.WriteLine("Please enter a number between {0} and {1}", m, end);
                }
            }
        }
    }
}