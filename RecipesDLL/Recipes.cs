using System;
using System.Collections.Generic;
using DataCheckDLL;
using RecipeItemDLL;
using FinalStockDLL;
using PrimaryStockDLL;

namespace RecipesDLL
{
    public static class Recipes
    {
        #region PROPERTIES
        private static Dictionary<int, List<RecipeItem>> recipes = new Dictionary<int, List<RecipeItem>>();
        #endregion


        #region METHODS

        #region SETTERS
        public static void AddRecipe(int id)
        {
            char decision;
            List<RecipeItem> recipeItems = new List<RecipeItem>();
            Console.WriteLine("*********Recipe items*********");
            do
            {

                RecipeItem item = new RecipeItem();
                recipeItems.Add(item);

                Console.WriteLine("Do you wish to add more?[Y/N]");

                decision = Console.ReadLine()[0];

            } while (char.ToLower(decision) != 'n');
            recipes.Add(id, recipeItems);
            //FileManager.SaveRecipe(recipes);
        }
        #endregion

        #region GETTERS
        /// <summary>
        /// This method allows to Get items recipes
        /// </summary>
        public static void GetRecipes()
        {
            int lastId = -1;

            foreach (KeyValuePair<int, List<RecipeItem>> pair in recipes)
            {

                if (lastId != pair.Key)
                {

                    FinalStock.GetItem(pair.Key);
                    lastId = pair.Key;
                    Console.WriteLine("***************RECIPE****************");

                }
                foreach (RecipeItem i in pair.Value)
                {
                    PrimaryStock.GetItem(i.ItemId);
                    Console.WriteLine($"Quantity: {i.Amount}");
                }
                Console.WriteLine("*************************************");
            }

        }

        /// <summary>
        /// This method allows to Get item recipe
        /// </summary>
        public static void GetRecipe(int id)
        {
            if (recipes.ContainsKey(id))
            {
                List<RecipeItem> recipe = recipes[id];
                foreach (RecipeItem r in recipe)
                {
                    Console.WriteLine(r);
                }
            }

        }

        /// <summary>
        /// This method allows to list to the user all the final items that can be made
        /// </summary>
        public static void RecipesCanBeMade()
        {
            List<int> items = new List<int>();
            bool canDo = true;
            foreach (KeyValuePair<int, List<RecipeItem>> pair in recipes)
            {
                foreach (RecipeItem i in pair.Value)
                {
                    if (!PrimaryStock.HasEnough(i.Amount,i.ItemId))
                        canDo = false;
                }
                if (canDo)
                    items.Add(pair.Key);
            }
            DataCheck.ShowList(items);

        }
        /// <summary>
        /// This method allows to check if a recipe can be made
        /// </summary>
        /// <param name="id">Final item id</param>
        public static void CanBeMade(int id)
        {

            bool canDo = true;
            foreach (KeyValuePair<int, List<RecipeItem>> pair in recipes)
            {
                if (pair.Key == id)
                {

                    foreach (RecipeItem i in pair.Value)
                    {
                        if (!PrimaryStock.HasEnough(i.Amount, i.ItemId))
                            canDo = false;
                    }
                    if (canDo)
                    {
                        FinalStock.GetItem(id);
                        Console.WriteLine("There is enought stock to make this item");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("There isn't enough stock to make this item");
                        return;
                    }
                }
            }


        }
        #endregion

        #endregion
    }
}
