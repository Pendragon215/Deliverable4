using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int I = 0;
        int num= 25;
        int[] fib = new int[num];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 0; i < num; i++)
        {

            if (i >= 2)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
        }

            Console.WriteLine("");
            foreach (int number in fib)
            {

            I++;
            Console.WriteLine("Fibonacci number (" + I.ToString() + ") = " + number.ToString());
            
        }
        
        Console.WriteLine("");
    }
}