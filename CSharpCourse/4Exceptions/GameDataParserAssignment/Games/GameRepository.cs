using System;
using System.Text.Json;
using CSharpCourse._4Exceptions.GameDataParserAssignment.UserInteraction;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.Games;

public class GameRepository: IGameRepository
{
    private readonly IUserInteraction _userInteraction;

    public GameRepository(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public IEnumerable<Game> FetchGames(string filepath)
    {
        var data = File.ReadAllText(filepath);
        try
        {
            var json = JsonSerializer.Deserialize<List<Game>>(data);
            return json;
        }
        catch (JsonException ex)
        {
            _userInteraction.ShowExceptionRaised(filepath, data);
            // here we throwing a new exception instead of original one in the try block, but preserving the original exception as inner exception
            throw new JsonException($"{ex.Message} The file is: {filepath}", ex);
        }
    }
}
