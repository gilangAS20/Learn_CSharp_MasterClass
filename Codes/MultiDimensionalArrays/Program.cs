// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

char[,] letters = new char[2,3];

letters[0,0] = 'A';
letters[0,1] = 'B';
letters[0,2] = 'C';
letters[1,0] = 'D';
letters[1,1] = 'E';
letters[1,2] = 'F';

Console.WriteLine("using foreach loop");
foreach (var item in letters)
{
    Console.WriteLine(item);
}

Console.WriteLine("using for loop");
for (int i = 0; i < letters.GetLength(0); i++)
{
    for (int j = 0; j < letters.GetLength(1); j++)
    {
        Console.WriteLine(letters[i,j]);
    }
}
