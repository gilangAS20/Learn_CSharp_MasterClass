// See https://aka.ms/new-console-template for more information

namespace TodoList;

class Program
{
    static void Main()
    {
        // S A R E
        Console.WriteLine("Hello!");

        ToDo toDo = new ToDo();

        string menuInput = String.Empty;
        do
        {
            Messages.ShowMenu();
            menuInput = Console.ReadLine();

            switch (menuInput)
            {
                case "S":
                case "s":
                    toDo.SeeTodo();
                    break;

                case "a":
                case "A":
                    string? todoInput = string.Empty;
                    bool isSuccess = false;
                    do
                    {
                        Console.WriteLine("Add ToDo:");
                        todoInput = Console.ReadLine();
                        if (string.IsNullOrEmpty(todoInput))
                        {
                            Console.WriteLine("The description cannot be empty.");
                        }
                        else
                        {
                            toDo.AddTodo(todoInput, out isSuccess);
                        }
                    } while (!isSuccess);
                    break;

                case "R":
                case "r":
                    break;

                case "E":
                case "e":
                    Console.WriteLine("Program closed");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        } while (menuInput?.ToLower() != "e");
    }
}