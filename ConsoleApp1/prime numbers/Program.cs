using System.IO.Pipes;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

/* check if n can only be divided by 1 and itself
 n%n-1
 */
/*
int n = int.Parse(Console.ReadLine());
for (int i = n; i > 0; i--)
{
    int result = n % i;
    Console.WriteLine(result);
}
*/

int p = int.Parse(Console.ReadLine());
bool isprime = true;
for (int i = 2; i < p/2; i++)
{
    if (p%i == 0)
    {
        isprime = false;
        break;
    }
}
if (isprime)
{
    Console.WriteLine("true");
}else
{
    Console.WriteLine("false");
}