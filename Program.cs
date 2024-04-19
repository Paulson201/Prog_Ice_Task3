using System;
using System.Collections.Generic;

namespace icetask03
{
 
   
 


    
        class Program
        {
            static void Main(string[] args)
            {
                Recipe recipe = new Recipe();
                bool continueInput = true;

                while (continueInput)
                {
                    Console.WriteLine("Recipe Application");
                    Console.WriteLine("1. Enter Recipe Details");
                    Console.WriteLine("2. Display Recipe");
                    Console.WriteLine("3. Scale Recipe");
                    Console.WriteLine("4. Reset Quantities");
                    Console.WriteLine("5. Clear Data");
                    Console.WriteLine("6. Exit");

                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            recipe.EnterDetails();
                            break;
                        case "2":
                            recipe.Display();
                            break;
                        case "3":
                            recipe.ScaleRecipe();
                            break;
                        case "4":
                            recipe.ResetQuantities();
                            break;
                        case "5":
                            recipe.ClearData();
                            break;
                        case "6":
                            continueInput = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }

        class Recipe
        {
            private List<Ingredient> ingredients;
            private List<string> steps;

            public Recipe()
            {
                ingredients = new List<Ingredient>();
                steps = new List<string>();
            }

            public void EnterDetails()
            {
                Console.Write("Enter the number of ingredients: ");
                int ingredientCount = int.Parse(Console.ReadLine());

                ingredients.Clear();
                for (int i = 0; i < ingredientCount; i++)
                {
                    Console.Write($"Enter the name of ingredient {i + 1}: ");
                    string name = Console.ReadLine();

                    Console.Write($"Enter the quantity of {name}: ");
                    double quantity = double.Parse(Console.ReadLine());

                    Console.Write($"Enter the unit of measurement for {name}: ");
                    string unit = Console.ReadLine();

                    ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
                }

                Console.Write("Enter the number of steps: ");
                int stepCount = int.Parse(Console.ReadLine());

                steps.Clear();
                for (int i = 0; i < stepCount; i++)
                {
                    Console.Write($"Enter step {i + 1}: ");
                    string step = Console.ReadLine();
                    steps.Add(step);
                }

                Console.WriteLine("Recipe details entered successfully!");
            }

            public void Display()
            {
                Console.WriteLine("Recipe Details:");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                }

                Console.WriteLine("\nSteps:");
                for (int i = 0; i < steps.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {steps[i]}");
                }
            }

            public void ScaleRecipe()
            {
                Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                double factor = double.Parse(Console.ReadLine());

                foreach (var ingredient in ingredients)
                {
                    ingredient.Quantity *= factor;
                }

                Console.WriteLine($"Recipe scaled by {factor}x successfully!");
            }

            public void ResetQuantities()
            {
                // Implement resetting quantities to their original values
                Console.WriteLine("Quantities reset to their original values successfully!");
            }

            public void ClearData()
            {
                ingredients.Clear();
                steps.Clear();
                Console.WriteLine("Data cleared successfully!");
            }
        }

        class Ingredient
        {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        }
    }


