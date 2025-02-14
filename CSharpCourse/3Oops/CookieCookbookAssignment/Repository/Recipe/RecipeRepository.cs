using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.FileIO;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Recipe;

public class RecipeRepository: IRecipeRepository
{
    private readonly IFileIORepository _fileIORepository;

    private const string Separator = ",";

    public RecipeRepository(IFileIORepository fileIORepository)
    {
        _fileIORepository = fileIORepository;
    }

    public List<List<int>>? ReadAll(string filePath)
    {
        var recipes = _fileIORepository.Read(filePath);
        if(recipes == null)
        {
            return null;
        }
        return recipes
            .Select(recipe => recipe.Split(Separator)
            .Select(ingredient => int.Parse(ingredient))
            .ToList())
            .ToList();
    }

    public void Write(string filePath, List<int> recipe)
    {
        var recipes = ReadAll(filePath) ?? [];
        recipes.Add(recipe);
        var recipesAsString = recipes
            .Select(recipe => string.Join(Separator, recipe))
            .ToList();
        _fileIORepository.Write(filePath, recipesAsString);
        return;
    }
}
