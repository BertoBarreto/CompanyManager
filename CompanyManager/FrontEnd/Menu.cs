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
                Console.WriteLine("** Add Information            **");
                Console.WriteLine("**  3 - Edit client           **");
                Console.WriteLine("**  4 - Edit Supplier         **");
                Console.WriteLine("** Get Information            **");
                Console.WriteLine("**  5 - Company Information   **");
                Console.WriteLine("**  6 - Client Information    **");
                Console.WriteLine("**  7 - Supplier Information  **");
                Console.WriteLine("**  0 - Back                  **");
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
                        ClientMenu();
                        break;
                    case 4:
                        SupplierMenu();
                        break;
                    case 5:
                        InformationRules.GetCompanyInfo();
                        break;
                    case 6:
                        InformationRules.SearchClient();
                        break;
                    case 7:
                        InformationRules.SearchSupplier();
                        break;
                    case 0: return;
                    default: DataRules.ErrorMsg("Thats not a valid option!"); break;
                }
            }

            
        }

        /// <summary>
        /// This method allows to show the clients edit menu
        /// </summary>
        public static void ClientMenu()
        {
            while (choice >= 0)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("**  1 - Name                  **");
                Console.WriteLine("**  2 - Address               **");
                Console.WriteLine("**  3 - Nif                   **");
                Console.WriteLine("**  4 - Mobile Contact        **");
                Console.WriteLine("**  5 - Email                 **");
                Console.WriteLine("**  6 - Country               **");
                Console.WriteLine("**  7 - Credit limit          **");
                Console.WriteLine("**  8 - Payment Conditions    **");
                Console.WriteLine("**  0 - Back                  **");
                Console.WriteLine("********************************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        InformationRules.ChangeClientName();
                        break;
                    case 2:
                        InformationRules.ChangeClientAddress();
                        break;
                    case 3:
                        InformationRules.ChangeClientNif();
                        break;
                    case 4:
                        InformationRules.ChangeClientMobileContact();
                        break;
                    case 5:
                        InformationRules.ChangeClientEmail();
                        break;
                    case 6:
                        InformationRules.ChangeClientCountry();
                        break;
                    case 7:
                        InformationRules.ChangeClientCreditLimit();
                        break;
                    case 8:
                        InformationRules.ChangeClientPaymentConditions();
                        break;
                    case 0: return;
                    default: DataRules.ErrorMsg("Thats not a valid option!"); break;
                }
            }


        }

        /// <summary>
        /// This method allows to show the suppliers edit menu
        /// </summary>
        public static void SupplierMenu()
        {
            while (choice >= 0)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("**  1 - Name                  **");
                Console.WriteLine("**  2 - Address               **");
                Console.WriteLine("**  3 - Nif                   **");
                Console.WriteLine("**  4 - Mobile Contact        **");
                Console.WriteLine("**  5 - Email                 **");
                Console.WriteLine("**  6 - Country               **");
                Console.WriteLine("**  7 - Credit limit          **");
                Console.WriteLine("**  8 - Payment Conditions    **");
                Console.WriteLine("**  0 - Back                  **");
                Console.WriteLine("********************************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        InformationRules.ChangeSupplierName();
                        break;
                    case 2:
                        InformationRules.ChangeSupplierAddress();
                        break;
                    case 3:
                        InformationRules.ChangeSupplierNif();
                        break;
                    case 4:
                        InformationRules.ChangeSupplierMobileContact();
                        break;
                    case 5:
                        InformationRules.ChangeSupplierEmail();
                        break;
                    case 6:
                        InformationRules.ChangeSupplierCountry();
                        break;
                    
                    case 8:
                        InformationRules.ChangeSupplierPaymentConditions();
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
                Console.WriteLine("**    0 - Back       **");
                Console.WriteLine("***********************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        ItemsRules.GetPrimaryStock();
                        break;
                    case 2:

                        ItemsRules.AddPrimaryItem();
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
                Console.WriteLine("**    0 - Back       **");
                Console.WriteLine("***********************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        ItemsRules.GetFinalStock();
                        break;
                    case 2:

                        ItemsRules.AddFinalItem();
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
                Console.WriteLine("**    0 - Back                       **");
                Console.WriteLine("***************************************");
                choice = DataRules.GetInt("Option: ");
                switch (choice)
                {
                    case 1:
                        ItemsRules.GetRecipe();
                        break;
                    case 2:
                        ItemsRules.GetRecipes();
                        break;
                    case 3:
                        ItemsRules.AddRecipe();
                        break;
                    case 4:
                        ItemsRules.RecipesCanBeMade();
                        //fazer com que diga a quantidade que é possivel fazer
                        //não está a fazer o seu trabalho
                        break;
                    case 5:
                        ItemsRules.RecipeCanBeMade();
                        //fazer com que diga a quantidade que é possivel fazer
                        //não está a fazer o seu trabalho
                        break;
                    case 0: return;
                    default: DataRules.ErrorMsg("Thats not a valid option!"); break;
                }
            }
        }
        #endregion

    }

}
