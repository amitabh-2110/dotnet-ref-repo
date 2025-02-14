using System;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.ExceptionLogger;

public interface ILoggerRepository
{
    public string ReadLogs();

    public void WriteLog(string logs);
}
