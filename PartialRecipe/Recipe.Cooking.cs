using System;

partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if (ingredientsCount == ingredients.Length)
        {
            Console.WriteLine("최대 재료 수에 도달함.");
        }

        else
        {
            ingredients[ingredientsCount++] = ingredient;
        }
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine($"재료:");

        for(int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine($"  {i + 1}. {ingredients[i]}");
        }
    }

    public bool HasIngredient(string ingredient)
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i] == ingredient) return true;
        }

        return false;
    }
}