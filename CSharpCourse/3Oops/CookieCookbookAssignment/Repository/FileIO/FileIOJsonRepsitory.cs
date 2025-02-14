using System.Text.Json;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.FileIO;

public class FileIOJsonRepsitory : FileIORepository
{
    protected override string RecipesToString(List<string> recipes)
    {
        return JsonSerializer.Serialize(recipes);
    }

    protected override List<string>? StringToRecipes(string data)
    {
        return JsonSerializer.Deserialize<List<string>>(data);
    }
}
