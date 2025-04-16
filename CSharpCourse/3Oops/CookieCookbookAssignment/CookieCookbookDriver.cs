
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.FileIO;
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Ingredient;
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Recipe;
using CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction;

namespace CSharpCourse._3Oops.CookieCookbookAssignment;

public class CookieCookbookDriver
{
    public static void CookieCookbookDriverMethod()
    {
        // in this project we included template design pattern in file IO, dependency inversion principle and dependency injection design pattern everywhere.

        const FileFormat fileFormat = FileFormat.Text;

        IFileIORepository fileIORepository = fileFormat == FileFormat.Json ? 
            new FileIOJsonRepsitory() :
            new FileIOTextualRepository();

        var fileMetaData = new FileMetaData("result", fileFormat);

        var consoleUserInteraction = new ConsoleUserInteraction();
        var fetchIngredients = new IngredientRepository();
        var recipeRepository = new RecipeRepository(fileIORepository);

        var cookieCookbook = new CookieCookbook(
            consoleUserInteraction,
            new RecipeUserInteraction(
                consoleUserInteraction,
                fetchIngredients,
                recipeRepository
            ),
            fetchIngredients,
            recipeRepository
        );
        
        cookieCookbook.Run(fileMetaData.ToPath());
    }
}


