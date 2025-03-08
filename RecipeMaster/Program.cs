using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeMaster
{
    class Recipe
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<Step> Steps { get; set; } = new List<Step>();

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            foreach (var step in Steps.OrderBy(s => s.Order))
            {
                Console.WriteLine($"{step.Order}. {step.Description}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var recipe = new Recipe();

            // Capture ingredients
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                var ingredient = new Ingredient();
                Console.Write("Enter the name of the ingredient: ");
                ingredient.Name = Console.ReadLine();
                Console.Write("Enter the quantity of the ingredient: ");
                ingredient.Quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter the unit of measurement: ");
                ingredient.Unit = Console.ReadLine();
                recipe.Ingredients.Add(ingredient);
            }

            // Capture steps
            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                var step = new Step();
                step.Order = i + 1;
                Console.Write($"Enter the description for step {step.Order}: ");
                step.Description = Console.ReadLine();
                recipe.Steps.Add(step);
            }

            // Display the recipe
            recipe.DisplayRecipe();
        }
    }
}
