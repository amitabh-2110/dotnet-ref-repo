
using CSharpCourse._4Exceptions.GameDataParserAssignment.DataSourceConfig;
using CSharpCourse._4Exceptions.GameDataParserAssignment.ExceptionLogger;
using CSharpCourse._4Exceptions.GameDataParserAssignment.Games;
using CSharpCourse._4Exceptions.GameDataParserAssignment.UserInteraction;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment;

public class GameDataParser
{
    private readonly IUserInteraction _userInteraction;
    private readonly IDataSourceConfig _dataSourceConfig;
    private readonly IGameRepository _gameRepository;
    private readonly ILogger _logger;

    public GameDataParser(IUserInteraction userInteraction, IDataSourceConfig dataSourceConfig, IGameRepository gameRepository, ILogger logger)
    {
        _userInteraction = userInteraction;
        _dataSourceConfig = dataSourceConfig;
        _gameRepository = gameRepository;
        _logger = logger;
    }
 
    public void Run()
    {
        try
        {
            string filepath;
            do
            {
                _userInteraction.Show("Enter the name of the file you want to read:");
                filepath = _userInteraction.Read();
            }
            while(!_dataSourceConfig.Exists(filepath));
            var games = _gameRepository.FetchGames(filepath);
            if(games.Count() > 0)
            {
                _userInteraction.ShowGames(games);
            }
            else
            {
                _userInteraction.Show("No games are present in the input file.");
            }
            _userInteraction.Exit();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            _userInteraction.Show("Sorry! The application has experienced an unexpected error and will have to be closed.");
        }
    }
}
