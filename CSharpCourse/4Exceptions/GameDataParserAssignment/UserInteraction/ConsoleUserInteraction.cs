using System;
using CSharpCourse._4Exceptions.GameDataParserAssignment.Games;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.UserInteraction;

public class ConsoleUserInteraction: IUserInteraction
{
    public string? Read()
    {
        var input = Console.ReadLine();
        return input;
    }

    public void Show(string message)
    {
        Console.WriteLine(message);
        return;
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void ShowGames(IEnumerable<Game> games)
    {
        Console.WriteLine("Loaded games are:");
        foreach(var game in games)
        {
            Console.WriteLine(game);
        } 
        return;
    }

    public void ShowExceptionRaised(string filepath, string invalidJson)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"JSON in the {filepath} was not in a valid format. JSON body: ");
        Console.WriteLine(invalidJson);
        Console.ResetColor();
    }
}
