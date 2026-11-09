namespace TodoList;

public static class Messages
{
    /// <summary>
    /// Show default menu for TodoList
    /// </summary>
    public static void ShowMenu()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");
    }
}