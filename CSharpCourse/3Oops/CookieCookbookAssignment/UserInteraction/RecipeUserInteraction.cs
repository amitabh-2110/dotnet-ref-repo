
using CSharpCourse._3Oops.CookieCookbookAssignment.Ingredient;
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Ingredient;
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Recipe;
using CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction.interfaces;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction;

public class RecipeUserInteraction: IRecipeUserInteraction
{
    private readonly IUserInteraction _userInteraction;
    private readonly IIngredientRepository _ingredientRepository;
    private readonly IRecipeRepository _recipeRepository;

    public RecipeUserInteraction(IUserInteraction userInteraction, IIngredientRepository ingredientRepository, IRecipeRepository recipeRepository)
    {
        _userInteraction = userInteraction;
        _ingredientRepository = ingredientRepository;
        _recipeRepository = recipeRepository;
    }

    public void PrintExistingRecipes(string filePath)
    {
        var listOfRecipes = _recipeRepository.ReadAll(filePath);
        if(listOfRecipes == null)
        {
            _userInteraction.ShowMessage("No Recipes are found !!!");
            return;
        }
        for(int i = 0; i < listOfRecipes.Count; i++)
        {
            var recipe = listOfRecipes[i];
            _userInteraction.ShowMessage($"***** {i+1} *****");
            foreach(var ingredientId in recipe)
            {
                UserIngredient ingredient = _ingredientRepository.GetIngredientById(ingredientId);
                _userInteraction.ShowMessage($"{ingredient.Name}. {ingredient.Instruction}");
            }
        }
        _userInteraction.ShowMessage("");
        return;
    }

    public void ShowIngredients()
    {
        string message = "Create a new cookie recipe! Available ingredients are:";
        _userInteraction.ShowMessage(message);

        foreach(var ingredient in _ingredientRepository.Ingredients)
        {
            string ingredientItem = $"{ingredient.Id}. {ingredient.Name}";
            _userInteraction.ShowMessage(ingredientItem);
        }
        return;
    }

    public List<int> GetUserRecipe()
    {
        var listOfIngredientIds = new List<int>();
        while(int.TryParse(_userInteraction.GetUserResponse(), out int id) && id >= 1 && id <= 8)
        {
            listOfIngredientIds.Add(id);
        }
        return listOfIngredientIds;
    }
}
