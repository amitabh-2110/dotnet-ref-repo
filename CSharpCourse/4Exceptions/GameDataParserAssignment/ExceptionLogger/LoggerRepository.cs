using System;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.ExceptionLogger;

public class LoggerRepository: ILoggerRepository
{
    public const string logFilePath = "logs.txt";

    public string ReadLogs()
    {
        if(!File.Exists(logFilePath))
        {
            return string.Empty;
        }
        var logs = File.ReadAllText(logFilePath);
        return logs;
    }

    public void WriteLog(string logs)
    {
        File.WriteAllText(logFilePath, logs);
        return;
    }
}
