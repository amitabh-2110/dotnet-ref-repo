
using CSharpCourse._3Oops.CookieCookbookAssignment.Recipe;
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Ingredient;
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Recipe;
using CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction.interfaces;

namespace CSharpCourse._3Oops.CookieCookbookAssignment;

public class CookieCookbook
{
    private readonly IUserInteraction _userInteraction;
    private readonly IRecipeUserInteraction _recipe;
    private readonly IIngredientRepository _ingredientRepository;
    private readonly IRecipeRepository _recipeRepository;

    public CookieCookbook(IUserInteraction userInteraction, IRecipeUserInteraction recipe, IIngredientRepository ingredientRepository, IRecipeRepository recipeRepository)
    {
        _userInteraction = userInteraction;
        _recipe = recipe;
        _ingredientRepository = ingredientRepository;
        _recipeRepository = recipeRepository;
    }

    public void Run(string filePath)
    {
        _recipe.PrintExistingRecipes(filePath);
        _recipe.ShowIngredients();
        var ingredients = _recipe.GetUserRecipe();
        if(ingredients.Count > 0)
        {
            var userRecipe = new UserRecipe(_ingredientRepository, ingredients);
            _userInteraction.ShowMessage("Recipe added:");
            var userRecipeMessage = userRecipe.ToString();
            _recipeRepository.Write(filePath, ingredients);
            _userInteraction.ShowMessage(userRecipeMessage);
        }
        else
        {
            _userInteraction.ShowMessage("No ingredients have been selected. Recipe will not be saved.");
        }
        _userInteraction.Exit();
    }
}
