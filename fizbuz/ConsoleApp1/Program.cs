// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
Random rnd = new Random();
int computernum = rnd.Next(1 , 100);
bool guessfalse = true;
while (guessfalse)
{
    int userinput = int.Parse(Console.ReadLine());
    if (userinput == computernum)
    {
        Console.WriteLine("correct");
        guessfalse = false;
    }
    if (userinput < computernum)
    {
        Console.WriteLine("higher");
    }
    if (userinput > computernum)
    {
        Console.WriteLine("lower");
    }
}



