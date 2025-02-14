using System;

namespace CSharpCourse._3Oops.CookieCookbookAssignment.Repository.Recipe;

public interface IRecipeRepository
{
    List<List<int>>? ReadAll(string filePath);

    void Write(string filePath, List<int> recipe);
}
