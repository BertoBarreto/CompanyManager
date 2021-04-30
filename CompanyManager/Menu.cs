/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/27/2021 11:48:18 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    
    /// <summary>
    /// Purpose: This class has the menu and all the decisions needed for the menu to work
    /// </summary>
    public static class Menu
    {
        #region PROPERTIES
        static int choice;
        
        static List<Client> clients = new List<Client>();
        #endregion

        #region METHODS
        public static void OpenMenu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("** Add IInformation              **");
            Console.WriteLine("**     1 - New client            **");
            Console.WriteLine("**     2 - New Supplier          **");
            Console.WriteLine("** Get IInformation              **");
            Console.WriteLine("**     3 - Company Information  **");
            Console.WriteLine("**     4 - Client Information   **");
            Console.WriteLine("**     5 - Supplier Information **");
            Console.WriteLine("**       Stock Management        **");
            Console.WriteLine("** Primary Stock                 **");
            Console.WriteLine("**         6 - Get Stock         **");
            Console.WriteLine("**         7 - Add Stock         **");
            Console.WriteLine("**         8 - Get Item          **");
            Console.WriteLine("**         9 - Add Item          **");
            Console.WriteLine("***********************************");
            choice = Console.Read();
            switch (choice)
            {
                case 1:
                    Client client =  new Client();
                    Clients.AddClient(client);
                    break;
                case 2:
                    Supplier supplier = new Supplier();
                    Suppliers.AddSupplier(supplier);
                    break;
                case 3:
                    Console.WriteLine($"\n{Company.GetCompanyInfo()}");
                    break;
                case 4:
                    //DataCheck.TryReadInt("Client Id:");
                    break;
                default:break;
            }

            
        }
        #region SETTERS

        #endregion

        #region GETTERS

        #endregion

        #endregion

    }
}
