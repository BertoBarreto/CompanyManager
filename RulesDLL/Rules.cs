using System;
using DataCheckDLL;

namespace RulesDLL
{
    public static class Rules
    {
        #region DATACHECK
        /// <summary>
        /// This method allows to get a integer
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>Int</returns>
        public static int GetInt(string msg)
        {
            return DataCheck.TryReadInt(msg);
        }

        /// <summary>
        /// This method allows to get a double
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>double</returns>
        public static double GetDouble(string msg)
        {
            return DataCheck.TryReadDouble(msg);
        }


        /// <summary>
        /// This method allows to get a primary item id
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>Int -> id</returns>
        public static int GetPrimaryItemId(string msg)
        {
            return DataCheck.TryReadPrimaryItemId(msg);
        }

        /// <summary>
        /// This method allows to get a final item id
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>Int -> id</returns>
        public static int GetFinalItemId(string msg)
        {
            return DataCheck.TryReadFinalItemId(msg);
        }

        /// <summary>
        /// This method allows to print a error message to the user in red
        /// </summary>
        /// <param name="msg">Message to print</param>
        public static void ErrorMsg(string msg)
        {
            DataCheck.ErrorMsg(msg);
        }
        #endregion

        //#region CLIENT
        ///// <summary>
        ///// This Function allows to Create and add a new client
        ///// </summary>
        //public static void AddNewClient()
        //{
        //    Client client = new Client();
        //    Clients.AddClient(client);

        //}
        ///// <summary>
        ///// This Function allows to Create and add a new supplier
        ///// </summary>
        //public static void AddNewSupplier()
        //{
        //    Supplier supplier = new Supplier();
        //    Suppliers.AddSupplier(supplier);

        //}
        //#endregion

        
        //#region COMPANY
        ///// <summary>
        ///// This method allows to print the company info
        ///// </summary>
        //public static void GetCompanyInfo()
        //{
        //    Console.WriteLine($"\n{Company.GetCompanyInfo()}");
        //}


        ///// <summary>
        ///// this method allows to search for a client
        ///// </summary>
        //public static void SearchClient()
        //{
        //    Console.WriteLine("\nClient Name: ");
        //    string name = Console.ReadLine();
        //    Clients.SearchClient(name);
        //}
        //#endregion
        //#region SUPPLIER
        ///// <summary>
        ///// This method allows to search for a supplier
        ///// </summary>
        //public static void SearchSupplier()
        //{
        //    Console.WriteLine("\nSupplier Name: ");
        //    string name = Console.ReadLine();
        //    Suppliers.SearchSupplier(name);
        //}
        //#endregion

        //#region PRIMARYSTOCK
         
        ///// <summary>
        ///// This method allows to print all the primary stock
        ///// </summary>
        //public static void GetPrimaryStock()
        //{
        //    PrimaryStock.GetStock();
        //}

        ///// <summary>
        ///// This method allows to create a primary item and add it to the primary stock
        ///// </summary>
        ///// <param name="itemName">Primary item name</param>
        ///// <param name="amount">Primary item amount</param>
        //public static void AddPrimaryItem(string itemName, double amount)
        //{
        //    PrimaryItem item = new PrimaryItem(amount,itemName,PrimaryStock.GetNextId());
        //    PrimaryStock.AddItem(item);
        //}

        ///// <summary>
        ///// This method allows to get information about a primary item in stock
        ///// </summary>
        //public static void GetPrimaryitem()
        //{
        //    PrimaryStock.GetItem(DataCheck.TryReadInt("Item id: "));
        //}

        //#endregion
        //#region FINALSTOCK

        ///// <summary>
        ///// This method allows to print all the final stock
        ///// </summary>
        //public static void GetFinalStock()
        //{
        //    FinalStock.GetStock();
        //}

        ///// <summary>
        ///// This method allows to create a primary item and add it to the primary stock
        ///// </summary>
        ///// <param name="itemName">Primary item name</param>
        ///// <param name="amount">Primary item amount</param>
        //public static void AddFinalItem(string itemName, double amount, double price)
        //{
        //    FinalItem item = new FinalItem(price, amount, itemName, FinalStock.GetNextId());
        //    FinalStock.AddItem(item);
        //}

        ///// <summary>
        ///// This method allows to get information about a primary item in stock
        ///// </summary>
        //public static void GetFinalitem()
        //{
        //    FinalStock.GetItem(DataCheck.TryReadInt("Item id: "));
        //}
        //#endregion

        //#region RECIPES
        ///// <summary>
        ///// This method allows to get a recipe
        ///// </summary>
        ///// <param name="id">Final Item id</param>
        //public static void GetRecipe(int id)
        //{
        //    Recipes.GetRecipe(id);
        //}

        ///// <summary>
        ///// This method allows to get all the recipes
        ///// </summary>
        //public static void GetRecipes()
        //{
        //    Recipes.GetRecipes();
        //}

        ///// <summary>
        ///// This method allows to add a recipe
        ///// </summary>
        ///// <param name="id">Final item id</param>
        //public static void AddRecipe(int id)
        //{
        //    FinalStock.GetItem(id);
        //    Recipes.AddRecipe(id);
        //    Recipes.GetRecipe(id);
        //}

        ///// <summary>
        ///// This method allows to Check if a recipe can be made
        ///// </summary>
        ///// <param name="id">Final item id</param>
        //public static void RecipeCanBeMade(int id)
        //{
        //    Recipes.CanBeMade(id);
        //}
        //#endregion
    }
}
