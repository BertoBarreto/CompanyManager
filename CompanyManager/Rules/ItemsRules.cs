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
        /// <param name="itemName">Primary item name</param>
        /// <param name="amount">Primary item amount</param>
        public static void AddPrimaryItem(string itemName, double amount)
        {
            PrimaryItem item = new PrimaryItem(amount, itemName, PrimaryStock.GetNextId());
            PrimaryStock.AddItem(item);
        }

        /// <summary>
        /// This method allows to get information about a primary item in stock
        /// </summary>
        public static void GetPrimaryitem()
        {
            PrimaryStock.GetItem(DataRules.GetInt("Item id: "));
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
        /// <param name="itemName">Primary item name</param>
        /// <param name="amount">Primary item amount</param>
        public static void AddFinalItem(string itemName, double amount, double price)
        {
            FinalItem item = new FinalItem(price, amount, itemName, FinalStock.GetNextId());
            FinalStock.AddItem(item);
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
        /// <param name="id">Final Item id</param>
        public static void GetRecipe(int id)
        {
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
        /// <param name="id">Final item id</param>
        public static void AddRecipe(int id)
        {
            FinalStock.GetItem(id);
            Recipes.AddRecipe(id);
            Recipes.GetRecipe(id);
        }

        /// <summary>
        /// This method allows to Check if a recipe can be made
        /// </summary>
        /// <param name="id">Final item id</param>
        public static void RecipeCanBeMade(int id)
        {
            Recipes.CanBeMade(id);
        }
        #endregion

    }
}
