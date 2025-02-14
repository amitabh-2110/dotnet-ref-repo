using System;

namespace CSharpCourse._1Basics;

public class TodoListAssignment
{
    public static void TodoListDriverMethod()
    {
        var todoList = new List<string>();

        while(true)
        {
            var userAction = AskUserAction();
            if(userAction == "s")
            {
                ListAllTodos(todoList);
            }
            else if(userAction == "a")
            {
                AddTodo(todoList);
            }
            else if(userAction == "r")
            {
                RemoveTodo(todoList);
            }
            else
            {
                break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Press any key exit..");
        Console.ReadKey();
    }

    public static string AskUserAction()
    {
        while(true)
        {
            Console.WriteLine("S A R E");
            var userInput = Console.ReadLine()?.Trim().ToLower();
            if(userInput == "s" || userInput == "a" || userInput == "r" || userInput == "e")
            {
                return userInput;
            }
            else 
            {
                Console.WriteLine("incorrect input");
            }
        }
    }

    public static void ListAllTodos(List<string> todos)
    {
        int n = todos.Count;
        if(n == 0)
        {
            Console.WriteLine("No TODOs has been added yet");
            return;
        }
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}. {todos[i-1]}");
        }
        return;
    }

    public static void AddTodo(List<string> todos)
    {
        while(true)
        {
            Console.WriteLine("Enter Description:");
            var userInput = Console.ReadLine()?.Trim();
            if(!string.IsNullOrEmpty(userInput) && !todos.Contains(userInput))
            {
                todos.Add(userInput);
                Console.WriteLine($"TODO added successfully: {userInput}");
                return;
            }
            else
            {
                Console.WriteLine("Please enter unique and non-empty description");
            }
        }
    }

    public static void RemoveTodo(List<string> todos)
    {
        while(true)
        {
            int n = todos.Count;
            ListAllTodos(todos);
            if(n == 0)
            {
                return;
            }
            Console.WriteLine("Select index");
            var userInput = Console.ReadLine()?.Trim();
            _ = int.TryParse(userInput, out int todoInd);
            if(string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Selected index cannot be empty");
            }
            else if(todoInd < 1 || todoInd > n)
            {
                Console.WriteLine("The given index is not valid");
            }
            else
            {
                Console.WriteLine($"TODO removed: {todos[todoInd-1]}");
                todos.RemoveAt(todoInd-1);
                return;
            }
        }
    }
}
