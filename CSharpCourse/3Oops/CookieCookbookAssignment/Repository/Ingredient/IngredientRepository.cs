
using CSharpCourse._3Oops.CookieCookbookAssignment.Ingredient;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Ingredient;

public class IngredientRepository: IIngredientRepository
{
    public IEnumerable<UserIngredient> Ingredients { get; } = [
        new UserIngredient
        {
            Id = 1,
            Name = "Wheat flour",
            Instruction = "Sieve. Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 2,
            Name = "Cocunut flour",
            Instruction = "Sieve. Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 3,
            Name = "Butter",
            Instruction = "Melt on low heat. Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 4,
            Name = "Chocolate",
            Instruction = "Melt in a water bath. Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 5,
            Name = "Sugar",
            Instruction = "Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 6,
            Name = "Cardamom",
            Instruction = "Take half a teaspoon. Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 7,
            Name = "Cinnamon",
            Instruction = "Take half a teaspoon. Add to other ingredients."
        },
        new UserIngredient
        {
            Id = 8,
            Name = "Cocoa powder",
            Instruction = "Add to other ingredients."
        }
    ];

    public UserIngredient GetIngredientById(int id)
    {
        UserIngredient ingredient = Ingredients
            .Where(ingredient => ingredient.Id == id)
            .First();
        return ingredient;
    }
}
