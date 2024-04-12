using System;

namespace RecipeProgram
{
    //ST10403748 Olwethu Blessing Biyase

    class Recipe
    {
        private string[] ingredients;
        private string[] steps;
        private double[] quantities;
        private string[] units;

        public Recipe()
        {
            Console.WriteLine("Enter the number of ingredients:");
            int numOfIngredients = Convert.ToInt32(Console.ReadLine());

            ingredients = new string[numOfIngredients];
            quantities = new double[numOfIngredients];
            units = new string[numOfIngredients];

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.WriteLine($"Enter the name of ingredient #{i + 1}:");
                ingredients[i] = Console.ReadLine();

                Console.WriteLine($"Enter the quantity of ingredient #{i + 1}:");
                quantities[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter the unit of measurement for ingredient #{i + 1}:");
                units[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the number of steps:");
            int numOfSteps = Convert.ToInt32(Console.ReadLine());

            steps = new string[numOfSteps];

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine($"Enter step #{i + 1}:");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe(double factor)
        {
            Console.WriteLine("Ingredients:");

            for (int i = 0; i < ingredients.Length; i++)
            {
                double scaledQuantity = quantities[i] * factor;
                Console.WriteLine($"{i + 1}. {scaledQuantity} {units[i]} {ingredients[i]}");
            }

            Console.WriteLine("\nSteps:");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        public void ResetQuantities()
        {
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] = quantities[i] / quantities[i];
            }
        }

        public void ResetRecipe()
        {
            ingredients = null;
            quantities = null;
            units = null;
            steps = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nEnter the number of the option you would like to choose:");
                Console.WriteLine("1. Display recipe");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Reset quantities");
                Console.WriteLine("4. Reset recipe");
                Console.WriteLine("5. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        recipe.DisplayRecipe(1);
                        break;
                    case 2:
                        Console.WriteLine("Enter scaling factor:");
                        double factor = Convert.ToDouble(Console.ReadLine());
                        recipe.DisplayRecipe(factor);
                        break;
                    case 3:
                        recipe.ResetQuantities();
                        Console.WriteLine("Quantities reset.");
                        break;
                    case 4:
                        recipe.ResetRecipe();
                        Console.WriteLine("Recipe reset.");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                        //ST10403748 Olwethu Blessing Biyase
                }
            }
        }
    }
}

