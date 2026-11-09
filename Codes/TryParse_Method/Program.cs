// See https://aka.ms/new-console-template for more information

bool isParseSuccess = false;
do
{
    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();

    isParseSuccess = int.TryParse(userInput, out int number);
    if (isParseSuccess)
    {
        Console.WriteLine($"Parsing worked, value: {number}");
    }
    else
    {
        Console.WriteLine("Parse failed");
    }
} while(!isParseSuccess);