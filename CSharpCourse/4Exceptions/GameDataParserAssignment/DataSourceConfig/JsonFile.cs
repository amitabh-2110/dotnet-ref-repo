using System;
using CSharpCourse._4Exceptions.GameDataParserAssignment.UserInteraction;

namespace CSharpCourse._4Exceptions.GameDataParserAssignment.DataSourceConfig;

public class JsonFile: IDataSourceConfig
{
    private readonly IUserInteraction _userInteraction;

    public JsonFile(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public bool Exists(string filepath)
    {
        if(filepath is null)
        {
            _userInteraction.Show("File name cannot be null.");
            return false;
        }
        if(filepath == string.Empty)
        {
            _userInteraction.Show("File name cannot be empty.");
            return false;
        }
        if(!File.Exists(filepath))
        {
            _userInteraction.Show("File not found.");
            return false;
        }
        return true;
    }
}
