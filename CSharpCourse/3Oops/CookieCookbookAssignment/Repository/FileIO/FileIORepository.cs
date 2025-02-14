using System;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.FileIO;

public abstract class FileIORepository: IFileIORepository
{
    public List<string>? Read(string filePath)
    {   
        if(!File.Exists(filePath))
        {
            return null;
        }
        var recipes = File.ReadAllText(filePath);
        return StringToRecipes(recipes);
    }

    public void Write(string filePath, List<string> recipes)
    {
        string data = RecipesToString(recipes);
        File.WriteAllText(filePath, data);
        return;
    }

    protected abstract List<string>? StringToRecipes(string data);

    protected abstract string RecipesToString(List<string> recipes);
}
