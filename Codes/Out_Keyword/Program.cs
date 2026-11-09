// See https://aka.ms/new-console-template for more information

int[] numbers = {10, -8, 2, 12, -17};
int negativeNumberCount = 0;
var onlyPositive = GetOnlyPositive(numbers, negativeNumberCount);
foreach (var item in onlyPositive)
{
    Console.WriteLine($"positive item: {item}");
}

Console.WriteLine($"Count of negative numbers: {negativeNumberCount}");

List<int> GetOnlyPositive(int[] numbers, int negativeNumberCount)
{
    List<int> result = new List<int>();
    negativeNumberCount = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            negativeNumberCount++;
        }
    }

    return result;
}