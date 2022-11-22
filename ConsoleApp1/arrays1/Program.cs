// See https://aka.ms/new-console-template for more information
int size = 20;
Console.WriteLine($"give {size} numbers");
int[] numberarray = new int[size];
for (int j = 0; j < numberarray.Length; j++)
{
    int x = int.Parse(Console.ReadLine());
    numberarray[j] = x;
}
Console.WriteLine("The reverse of the array is : ");
for (int i = size - 1; i >= 0; i--)
{
    Console.WriteLine(numberarray[i]);
}
