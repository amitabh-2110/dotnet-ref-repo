using System;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction.interfaces;

public interface IUserInteraction
{
    void ShowMessage(string message);

    string? GetUserResponse();

    void Exit();
}
