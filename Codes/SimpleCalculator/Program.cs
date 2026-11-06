// See https://aka.ms/new-console-template for more information

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            Message.PrintMenu();
            
            Console.Write("Operation: ");
            string? operation = Console.ReadLine().ToLower();
            
            Console.WriteLine("First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            
            if (!string.IsNullOrEmpty(operation) && firstNumber != null && secondNumber != null)
            {
                int? result = calc.Calculate(firstNumber, secondNumber, operation);
                if (result != null)
                {
                    Console.WriteLine($"Result {result}");
                }
                else
                {
                    Message.PrintInvalidInput();
                }
            }
            else
            {
                Message.PrintInvalidInput();
            }
        }
    }

    static class Message
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubstract");
            Console.WriteLine("[M]ultiply");
        }

        public static void PrintInvalidInput()
        {
            Console.WriteLine("invalid input");
        }
    }

    class Calculator
    {
        public int? Calculate(int firstNumber, int secondNumber, string operation)
        {
            operation = operation.ToLower();
            switch (operation)
            {
                case "a":
                    return firstNumber + secondNumber;
                case "s":
                    return firstNumber - secondNumber;
                case "m":
                    return firstNumber * secondNumber;
            }

            return null;
        }


    }
}