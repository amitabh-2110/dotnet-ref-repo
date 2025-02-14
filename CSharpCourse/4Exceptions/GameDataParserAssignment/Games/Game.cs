using System;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.Games;

public class Game
{
    public string Title { get; init; }

    public int ReleaseYear { get; init; }

    public decimal Rating { get; init; }

    public override string ToString()
    {
        return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
    }
}
