/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/27/2021 11:48:18 AM
/// </summary>
using System;
using System.Text;
using CompanyManager.Rules;


namespace CompanyManager.FronEnd
{
    
    /// <summary>
    /// Purpose: This class has the menu and all the decisions needed for the menu to work
    /// </summary>
    public static class Menu
    {
        #region PROPERTIES
        static int choice;
        static string name;
        static int id;
        #endregion

        #region METHODS
        /// <summary>
        /// Main program menu
        /// </summary>
        public static void MainMenu()
        {
            while (choice >= 0)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("**  1 - Information/Clients/Suppliers  **");
                Console.WriteLine("**  2 - Primary Stock                  **");
                Console.WriteLine("**  3 - Final Stock                    **");
                Console.WriteLine("**  4 - Recipes                        **");
                Console.WriteLine("**  0 - Exit                           **");
                Console.WriteLine("*****************************************");
                
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        InformationMenu();
                        break;
                    case 2:
                        PrimaryStockMenu();
                        break;
                    case 3:
                        FinalStockMenu();
                        break;
                    case 4:
                        RecipeMenu();
                        break;
                    case 0: return;

                    default:
                        DataRules.ErrorMsg("Thats not a valid option!");
                        break;
                }
            }


        }

        /// <summary>
        /// Information management menu
        /// </summary>
        public static void InformationMenu()
        {
            while (choice >= 0)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("** Add Information            **");
                Console.WriteLine("**  1 - New client            **");
                Console.WriteLine("**  2 - New Supplier          **");
                Console.WriteLine("** Get IInformation           **");
                Console.WriteLine("**  3 - Company Information   **");
                Console.WriteLine("**  4 - Client Information    **");
                Console.WriteLine("**  5 - Supplier Information  **");
                Console.WriteLine("**  0 - Exit                  **");
                Console.WriteLine("********************************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        InformationRules.AddNewClient();
                        break;
                    case 2:
                        InformationRules.AddNewSupplier();
                        break;
                    case 3:
                        InformationRules.GetCompanyInfo();
                        break;
                    case 4:
                        InformationRules.SearchClient();
                        break;
                    case 5:
                        InformationRules.SearchSupplier();
                        break;
                    case 0: return;
                    default: DataRules.ErrorMsg("Thats not a valid option!"); break;
                }
            }

            
        }

        /// <summary>
        /// Primary stock management menu
        /// </summary>
        public static void PrimaryStockMenu()
        {
            while (choice >= 0)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("**  PRIMARY STOCK    **");
                Console.WriteLine("**    1 - Get Stock  **");
                Console.WriteLine("**    2 - Add Stock  **");
                Console.WriteLine("**    3 - Get Item   **");
                Console.WriteLine("**    0 - Exit       **");
                Console.WriteLine("***********************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        ItemsRules.GetPrimaryStock();
                        break;
                    case 2:
                        Console.WriteLine("Item Name:");
                        string itemName = Console.ReadLine();
                        double amount = DataRules.GetDouble("Amount: ");
                        ItemsRules.AddPrimaryItem(itemName, amount);
                        break;
                    case 3:
                        ItemsRules.GetPrimaryitem();
                        break;
                    case 0: return;
                }
            }
        }

        /// <summary>
        /// Final Stock management menu 
        /// </summary>
        public static void FinalStockMenu()
        {
            while (choice >= 0)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("**  FINAL STOCK      **");
                Console.WriteLine("**    1 - Get Stock  **");
                Console.WriteLine("**    2 - Add Stock  **");
                Console.WriteLine("**    3 - Get Item   **");
                Console.WriteLine("**    0 - Exit       **");
                Console.WriteLine("***********************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        ItemsRules.GetFinalStock();
                        break;
                    case 2:
                        Console.WriteLine("Item Name:");
                        string itemName = Console.ReadLine();
                        double amount = DataRules.GetDouble("Amount: ");
                        double price = DataRules.GetDouble("Price: ");
                        ItemsRules.AddFinalItem(itemName, amount, price);
                        break;
                    case 3:
                        ItemsRules.GetFinalitem();
                        break;
                    case 0: return;
                    default: DataRules.ErrorMsg("Thats not a valid option!"); break;
                }
            }
        }

        /// <summary>
        /// Recipes management Menu
        /// </summary>
        public static void RecipeMenu()
        {

            while (choice >= 0)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("**  RECIPES                          **");
                Console.WriteLine("**    1 - Get Recipe                 **");
                Console.WriteLine("**    2 - Get all Recipes            **");
                Console.WriteLine("**    3 - Add Recipe                 **");
                Console.WriteLine("**    4 - Recipes that can be made   **");
                Console.WriteLine("**    5 - Check item can be made     **");
                Console.WriteLine("**    0 - Exit                       **");
                Console.WriteLine("***************************************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        id = DataRules.GetInt("Item id: ");
                        ItemsRules.GetRecipe(id);
                        break;
                    case 2:
                        ItemsRules.GetRecipes();
                        break;
                    case 3:

                        //wich item has this recipe
                        id = DataRules.GetFinalItemId("Final item id: ");
                        ItemsRules.AddRecipe(id);
                        break;
                    case 4:
                        //needs some things , talk to the teacher about how to aproach this method

                        //Recipes.RecipesCanBeMade();
                        break;
                    case 5:
                        id = DataRules.GetFinalItemId("Final item id: ");
                        ItemsRules.RecipeCanBeMade(id);
                        break;
                    case 0: return;
                    default: DataRules.ErrorMsg("Thats not a valid option!"); break;
                }
            }
        }
        #endregion

    }

}
