using System;
partial class Recipe
{
    public string[] ingredients;
    public int ingredientsCount = 0;

    public string Name { get; }
    public int Servings { get; }

    public Recipe(string name, int servings, int limit)
    {
        Name = name;
        Servings = servings;
        ingredients = new string[limit];
    }
}