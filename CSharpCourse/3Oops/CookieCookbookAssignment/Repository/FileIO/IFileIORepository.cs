namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.FileIO;

public interface IFileIORepository
{
    List<string>? Read(string filePath);
    
    void Write(string filePath, List<string> recipes);
}
