// See https://aka.ms/new-console-template for more information
//ask user for n , 
Console.WriteLine("n =");
int n = int.Parse(Console.ReadLine());
int result = 1;
for (int i = n; i > 0; i--)

{
    result *= i;
    //result = result * i

}
Console.WriteLine($"{n}! = {result}");

int result2 = 1;
for (int i = 1; i <= n; i++)
{
    result2 *= i;
}
Console.WriteLine($"{n}! = {result}");

/* THIS DOSENT WORK
int i = 1;
int result = n;
while (i <= n)
    i++;
*/