// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
StreamReader sr = new StreamReader("C:\\Users\\Student\\Desktop\\data.txt");
// or sr = new StreamReader(@"C:\Users\Student\Desktop\data.txt");\
int wordcount = 0;
int[] results = new int[20];
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    string[] words = line.Split(" ");
    for (int i = 0; i < words.Length; i++)
    {
        results[words[i].Length]++;
        wordcount++;
    }
}
for (int i = 0; i < 20; i++)
{
    Console.WriteLine(results[i]);
}
Console.WriteLine(wordcount);
sr.Close();