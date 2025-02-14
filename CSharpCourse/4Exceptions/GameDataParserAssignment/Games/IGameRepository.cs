using System;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.Games;

public interface IGameRepository
{
    public IEnumerable<Game> FetchGames(string filepath);
}
