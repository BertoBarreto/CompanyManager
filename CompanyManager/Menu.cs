/// <summary>
/// Purpose: 
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
    /// Purpose: 
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
            Console.WriteLine("**********************************");
            Console.WriteLine("** Add Information              **");
            Console.WriteLine("**     1 - New client           **");
            Console.WriteLine("**     2 - New Supplier         **");
            Console.WriteLine("** Get Information              **");
            Console.WriteLine("**     3 - Company Information  **");
            Console.WriteLine("**     4 - Client Information   **");
            Console.WriteLine("**     5 - Supplier Information **");
            Console.WriteLine("**       Stock Management       **");
            Console.WriteLine("** Primary Stock                **");
            Console.WriteLine("**         6 - Get Stock        **");
            Console.WriteLine("**         7 - Add Stock        **");
            Console.WriteLine("**         8 - Get Item         **");
            Console.WriteLine("**         9 - Add Item         **");
            Console.WriteLine("**********************************");
            choice = Console.Read();
            switch (choice)
            {
                case 1:
                    clients.Add(InformationManager.CreateClient());
                    break;
                case 2:
                    Suppliers.AddSupplier(InformationManager.CreateSupplier());
                    break;
                case 3:
                    Console.WriteLine($"\n{Company.GetCompanyInfo()}");
                    break;
                case 4:
                    Console.WriteLine("\nClient Id: ");
                    
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
