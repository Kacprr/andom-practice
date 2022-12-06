// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");
void FizzBuzz (int n)
{
    for (int i = 1; i <= n; i++)
    {     
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("fizzbuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("fizz");
        }
        else
        if (i % 5 == 0)
        {
            Console.WriteLine("buzz");
        }
        else {
        Console.WriteLine(i);
        }
    }
}
int userinput = int.Parse(Console.ReadLine());
FizzBuzz(userinput);