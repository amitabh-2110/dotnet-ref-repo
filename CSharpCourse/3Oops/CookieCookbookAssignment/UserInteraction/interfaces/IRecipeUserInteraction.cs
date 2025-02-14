using System;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.UserInteraction.interfaces;

public interface IRecipeUserInteraction
{
    void PrintExistingRecipes(string filePath);

    void ShowIngredients();

    List<int> GetUserRecipe();
}
