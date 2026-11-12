namespace TodoList;

public class ToDo
{
    private Dictionary<int, string> _todoItem = new Dictionary<int, string>();

    public void SeeTodo()
    {
        if (_todoItem.Count == 0)
        {
            Console.WriteLine("Todo is empty");
        }
        else
        {
            foreach (var item in _todoItem)
            {
                Console.WriteLine($"{item.Key}. {item.Value}");
            }
        }
    }
    
    public void AddTodo(string? todo, out bool isSuccess)
    {
        isSuccess = false;
        
        if (_todoItem.ContainsValue(todo))
        {
            Console.WriteLine("The description must be unique");
            isSuccess = false;
        }
        else if (string.IsNullOrEmpty(todo))
        {
            Console.WriteLine("The description cannot be empty");
            isSuccess = false;
        }
        else
        {
            if (_todoItem.Count == 0)
            {
                _todoItem.Add(1, todo);
            }
            else
            {
                _todoItem.Add(_todoItem.Count + 1, todo);
            }

            isSuccess = true;
            Console.WriteLine($"TODO successfully added: {todo}");
        }
    }

    public void RemoveTodo(int id)
    {
        if (_todoItem.ContainsKey(id))
        {
            _todoItem.Remove(id);
            Console.WriteLine($"Remove TODO with id {id}");
        }
        else
        {
            Console.WriteLine($"Todo not contain id {id}");
        }
    }
}