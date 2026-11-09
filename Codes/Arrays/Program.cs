// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Hello, World!");

int[] latianArray1 = new int[5];
latianArray1[0] = 1;
latianArray1[1] = 2;
latianArray1[2] = 3;
latianArray1[3] = 4;
latianArray1[4] = 5;

Console.WriteLine($"first from the end {latianArray1[^1]}");
Console.WriteLine($"second from the end {latianArray1[^2]}");

int[] coba = {1,2,3,4};

foreach (var item in coba)
{
    Console.WriteLine(item);
}
