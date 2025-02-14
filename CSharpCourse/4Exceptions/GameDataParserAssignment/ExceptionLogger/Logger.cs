
namespace CSharpCourse._4Exceptions.GameDataParserAssignment.ExceptionLogger;

public class Logger: ILogger
{
    private readonly ILoggerRepository _loggerRepository;

    public Logger(ILoggerRepository loggerRepository)
    {
        _loggerRepository = loggerRepository;
    }

    public void Log(Exception ex)
    {
        var prevLogs = _loggerRepository.ReadLogs();
        string currLog = 
$@"[{DateTime.Now:g}]
Exception message: {ex.Message}
Stack trace: {ex.StackTrace}";

        List<string> logs = [
            prevLogs,
            string.Empty,
            currLog
        ];
        _loggerRepository.WriteLog(string.Join(Environment.NewLine, logs));
        return;
    }
}
