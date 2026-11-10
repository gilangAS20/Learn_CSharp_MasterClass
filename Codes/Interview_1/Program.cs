// See https://aka.ms/new-console-template for more information

/*
Menghitung jumlah total dari 3 nilai teratas, 
input : [1,2,3,4,5,6] 
output : 15

Input: array of int [2,4,6,5,3,1,7,9,10,8] 
Hasil:  2,4,6,8,10 
            2,4,6,8 
            2,4,6 
            2,4 
            2 

Bilangan Prima, 
input n = 6.
Output :
2, 3, 5, 7, 11, 13
*/


// no 1
int[] numbers = new[] {1,2,3,4,5,6};
int[] sortedNumbers = numbers.OrderByDescending(x => x).ToArray();
int result = 0;
for (int i = 0; i <= 2; i++)
{
    result += sortedNumbers[i];
}
Console.WriteLine($"output: {result}");

// no 2
int[] numbers2 = {2,4,6,5,3,1,7,9,10,8};
Array.Sort(numbers2);
int[] sortedArr = numbers2.Where(x => x % 2 == 0).ToArray();

for (int i = sortedArr.Length; i >= 0; i--)
{
    List<int> item = new List<int>();
    for (int j = 0; j < i; j++)
    {
        item.Add(sortedArr[j]);
    }

    Console.WriteLine(String.Join(",", item));
}

// no 3
int input = 6;
List<int> prime = new List<int>();
int x = 2;

do
{
    if (x == 2)
    {
        prime.Add(x);
    }
    else
    {
        bool isPrime = true;
        for (int j = 2; j < x; j++)
        {
            if (x % j == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            prime.Add(x);
        }
    }

    x++;

} while (prime.Count != input);
Console.WriteLine(String.Join(", ", prime));