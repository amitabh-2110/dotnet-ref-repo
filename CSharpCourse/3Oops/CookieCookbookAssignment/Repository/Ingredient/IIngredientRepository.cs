
using CSharpCourse._3Oops.CookieCookbookAssignment.Ingredient;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Ingredient;

public interface IIngredientRepository
{
    IEnumerable<UserIngredient> Ingredients { get; }
    
    UserIngredient GetIngredientById(int id);
}
