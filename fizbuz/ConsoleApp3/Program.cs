// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool guessfalse = true;
int maxval = 100;
int minval = 0;
bool user = 
while (guessfalse)
{
    int middleval = (maxval + minval) / 2;
    if (middleval == user)
    {
        Console.WriteLine($"your number is {middleval}");
        guessfalse = false;
    }
    else if (middleval > user)
    {
        maxval = middleval;
    }
    else if (middleval < user)
    {
        minval = middleval;
    }
}



