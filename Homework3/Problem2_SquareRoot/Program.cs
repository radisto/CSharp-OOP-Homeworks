using System;

class Program
{
    static void Main()
    {
        int n = 0;
        try
        {
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                throw new FormatException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine(root(n));
            Console.WriteLine("Good bye");
        }
    }

    static double root(int n)
    {
        return Math.Sqrt(n);
    }
}
