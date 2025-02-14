namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.FileIO;

public class FileIOTextualRepository : FileIORepository
{
    protected override string RecipesToString(List<string> recipes)
    {
        return string.Join(Environment.NewLine, recipes);
    }

    protected override List<string>? StringToRecipes(string data)
    {
        return [.. data.Split(Environment.NewLine)];
    }
}
