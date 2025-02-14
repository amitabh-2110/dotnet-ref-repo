using System;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.DataSourceConfig;

public interface IDataSourceConfig
{
    public bool Exists(string connectionString);
}
