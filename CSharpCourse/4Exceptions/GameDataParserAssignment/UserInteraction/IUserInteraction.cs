using System;
using CSharpCourse._4Exceptions.GameDataParserAssignment.Games;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.UserInteraction;

public interface IUserInteraction
{
    string? Read();

    void Show(string message);

    public void Exit();

    public void ShowGames(IEnumerable<Game> games);

    public void ShowExceptionRaised(string filepath, string invalidJson);
}
