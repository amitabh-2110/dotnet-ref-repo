using System;

namespace CSharpCourse._3Oops.CookieCookbookAssignment;

public enum FileFormat
{
    Json,
    Text
}

public static class FileFormatExtension
{
    public static string GetExtension(this FileFormat fileFormat)
    {
        return fileFormat == FileFormat.Json ? 
            "json" :
            "txt";
    }
}

public class FileMetaData
{
    public string FileName { get; }

    public FileFormat Format { get; }

    public FileMetaData(string fileName, FileFormat format)
    {
        FileName = fileName;
        Format = format;
    }

    public string ToPath()
        => $"{FileName}.{Format.GetExtension()}";
}
