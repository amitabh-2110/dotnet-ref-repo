using System;
using CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction.interfaces;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction;

public class ConsoleUserInteraction: IUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string? GetUserResponse()
    {
        var resp = Console.ReadLine();
        return resp;
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }
}
