/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:15:12 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using CompanyManager.Data.Information;

namespace CompanyManager.Rules
{
    public class InformationRules
    {
        

        #region CLIENT
        /// <summary>
        /// This Function allows to Create and add a new client
        /// </summary>
        public static void AddNewClient()
        {
            Client client = new Client();
            Clients.AddClient(client);

        }
        /// <summary>
        /// This Function allows to Create and add a new supplier
        /// </summary>
        public static void AddNewSupplier()
        {
            Supplier supplier = new Supplier();
            Suppliers.AddSupplier(supplier);

        }
        #endregion

        #region COMPANY
        /// <summary>
        /// This method allows to print the company info
        /// </summary>
        public static void GetCompanyInfo()
        {
            Console.WriteLine($"\n{Company.GetCompanyInfo()}");
        }


        /// <summary>
        /// this method allows to search for a client
        /// </summary>
        public static void SearchClient()
        {
            Console.WriteLine("\nClient Name: ");
            string name = Console.ReadLine();
            Clients.SearchClient(name);
        }
        #endregion

        #region SUPPLIER
        /// <summary>
        /// This method allows to search for a supplier
        /// </summary>
        public static void SearchSupplier()
        {
            Console.WriteLine("\nSupplier Name: ");
            string name = Console.ReadLine();
            Suppliers.SearchSupplier(name);
        }
        #endregion

    }
}
