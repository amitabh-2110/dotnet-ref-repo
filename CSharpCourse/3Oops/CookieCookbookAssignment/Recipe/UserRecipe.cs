
using CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Ingredient;
using CSharpCourse._3Oops.CookieCookbookAssignment.Ingredient;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Recipe;

public class UserRecipe
{
    private readonly IIngredientRepository _ingredientRepository;
    public IEnumerable<int> ListOfIngredientIds { get; private set; } = [];

    public UserRecipe(IIngredientRepository ingredientRepository, List<int> ingredients)
    {
        _ingredientRepository = ingredientRepository;
        ListOfIngredientIds = ingredients;
    }

    public override string ToString()
    {
        var userRecipes = ListOfIngredientIds
            .Select(ingredientId => 
            {
                UserIngredient ingredient = _ingredientRepository.GetIngredientById(ingredientId);
                return $"{ingredient.Name}. {ingredient.Instruction}";
            });
        return string.Join(Environment.NewLine, userRecipes);
    }
}
