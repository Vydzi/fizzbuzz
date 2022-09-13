using System;

public class Program
{
    public static void Main()
    {
        FizzBuzz(40);
    }

    public static void FizzBuzz(int num)
    {
        for ( var i = 0; i <= num; i++)

        if (i %3 == 0 && i % 5 == 0)

            {
                Console.WriteLine(@"FizzBuzz{0}", i);
            }
        else if (i % 3 == 0)
            {
                Console.WriteLine(@"Fizz{0}", i);
            }
        else
            {
                Console.WriteLine(@"Buzz{0}", i);
            }
    }
}
