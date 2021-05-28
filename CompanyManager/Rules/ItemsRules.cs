/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 8:37:31 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using CompanyManager.Data.Items;
using CompanyManager.Rules;

namespace CompanyManager.Rules
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public static class ItemsRules
    {
        #region PRIMARYSTOCK

        /// <summary>
        /// This method allows to print all the primary stock
        /// </summary>
        public static void GetPrimaryStock()
        {
            PrimaryStock.GetStock();
        }

        /// <summary>
        /// This method allows to create a primary item and add it to the primary stock
        /// </summary>
        public static void AddPrimaryItem()
        {
            Console.WriteLine("Item Name:");
            string itemName = Console.ReadLine();
            double amount = DataRules.GetDouble("Amount: ");
            PrimaryItem item = new PrimaryItem(amount, itemName);
            PrimaryStock.AddItem(item);
        }

        /// <summary>
        /// This method allows to get information about a primary item in stock
        /// </summary>
        public static void GetPrimaryitem()
        {
            PrimaryStock.GetItem(DataRules.GetInt("Item id: "));
        }
        /// <summary>
        /// This method allows to get information about a primary item in stock
        /// </summary>
        public static void GetPrimaryitem(int id)
        {
            PrimaryStock.GetItem(id);
        }

        #endregion

        #region FINALSTOCK

        /// <summary>
        /// This method allows to print all the final stock
        /// </summary>
        public static void GetFinalStock()
        {
            FinalStock.GetStock();
        }

        /// <summary>
        /// This method allows to create a primary item and add it to the primary stock
        /// </summary>
        public static void AddFinalItem()
        {
            Console.WriteLine("Item Name:");
            string itemName = Console.ReadLine();
            double amount = DataRules.GetDouble("Amount: ");
            double price = DataRules.GetDouble("Price: ");
            FinalItem item = new FinalItem(price, amount, itemName);
            DataBase.InsertFinalItem(item);
        }

        /// <summary>
        /// This method allows to get information about a primary item in stock
        /// </summary>
        public static void GetFinalitem()
        {
            FinalStock.GetItem(DataRules.GetInt("Item id: "));
        }
        #endregion

        #region RECIPES
        /// <summary>
        /// This method allows to get a recipe
        /// </summary>
        public static void GetRecipe()
        {
            int id = DataRules.GetInt("Item id: ");
            Recipes.GetRecipe(id);
        }

        /// <summary>
        /// This method allows to get all the recipes
        /// </summary>
        public static void GetRecipes()
        {
            Recipes.GetRecipes();
        }

        /// <summary>
        /// This method allows to add a recipe
        /// </summary>
        public static void AddRecipe()
        {
            int fId, pId;
            double amount;
            List<RecipeItem> lst = new List<RecipeItem>();
            fId = DataRules.GetFinalItemId("Final item id: ");
            string decision;
            do
            {

                pId = DataRules.GetPrimaryItemId("Primary item id: ");


                amount = DataRules.GetDouble("Amount: ");

                RecipeItem i = new RecipeItem(amount, fId, pId);

                if (!Recipes.Contains(i))
                    lst.Add(i);
                else
                    DataRules.ErrorMsg("This Recipe Already Has this item");

                do
                {
                    Console.WriteLine("Do you wish to add more items?[Yes/No]");
                    decision = Console.ReadLine();

                } while (decision.ToLower() != "yes" && decision.ToLower() != "no");

            } while (decision.ToLower() == "yes");
            foreach (RecipeItem i in lst)
            {
                DataBase.InsertRecipeItem(i);
            }
        }

        /// <summary>
        /// This method allows to Check if a recipe can be made
        /// </summary>
        public static void RecipeCanBeMade()
        {
            int id = DataRules.GetFinalItemId("Final item id: ");
            Recipes.CanBeMade(id);
        }

        /// <summary>
        /// This method allows to get all the recipes that can be made
        /// </summary>
        public static void RecipesCanBeMade()
        {
            Recipes.RecipesCanBeMade();
            
        }
        #endregion

    }
}
