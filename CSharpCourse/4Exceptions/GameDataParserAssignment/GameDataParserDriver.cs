using System;
using CSharpCourse._4Exceptions.GameDataParserAssignment.DataSourceConfig;
using CSharpCourse._4Exceptions.GameDataParserAssignment.ExceptionLogger;
using CSharpCourse._4Exceptions.GameDataParserAssignment.Games;
using CSharpCourse._4Exceptions.GameDataParserAssignment.UserInteraction;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment;

public class GameDataParserDriver
{
    public static void GameDataParserDriverMain()
    {
        var userInteraction = new ConsoleUserInteraction();
        var gameDataParser = new GameDataParser(
            userInteraction,
            new JsonFile(userInteraction),
            new GameRepository(userInteraction),
            new Logger(new LoggerRepository())
        );
        gameDataParser.Run();
    }
}