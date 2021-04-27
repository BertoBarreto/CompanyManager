/// <summary>
/// Purpose: This class allows to create and manage the information of clients, suppliers and company
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/31/2021 3:15:04 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public static class InformationManager
    {
        #region METHODS

        #region BASIC_INFO
        /// <summary>
        /// This method allows to get basic information of a client
        /// </summary>
        /// <param name="c">Client to get the information</param>
        private static void BasicInfo(Client c)
        {
            Console.Write("\nClient Name: ");
            c.Name = Console.ReadLine();

            Console.Write("\nClient Address: ");
            c.Address = Console.ReadLine();

            c.Nif = TryReadInt("Client Nif");

            c.MobileContact = TryReadInt("Client Mobile Contact");

            Console.Write("\nClient Email: ");
            c.Email = Console.ReadLine();

            Console.Write("\nClient Country: ");
            c.Country = Console.ReadLine();
        }
        /// <summary>
        /// This method allows to get basic information of a Supplier
        /// </summary>
        /// <param name="c">Supplier to get the information</param>
        private static void BasicInfo(Supplier s)
        {
            Console.Write("\nSupplier Name: ");
            s.Name = Console.ReadLine();

            Console.Write("\nSupplier Address: ");
            s.Address = Console.ReadLine();

            s.Nif = TryReadInt("Supplier Nif");

            s.MobileContact = TryReadInt("Supplier Mobile Contact");

            Console.Write("\nSupplier Email: ");
            s.Email = Console.ReadLine();

            Console.Write("\nSupplier Country: ");
            s.Country = Console.ReadLine();
        }
        /// <summary>
        /// This method allows to get basic information of a company
        /// </summary>
        /// <param name="c">Company to get the information</param>
        private static void BasicInfo(Company c)
        {
            Console.Write("\nCompany Name: ");
            c.Name = Console.ReadLine();

            Console.Write("\nCompany Address: ");
            c.Address = Console.ReadLine();

            c.Nif = TryReadInt("Company Nif");

            c.MobileContact = TryReadInt("Company Mobile Contact");

            Console.Write("\nCompanyt Email: ");
            c.Email = Console.ReadLine();

            Console.Write("\nCompany Country: ");
            c.Country = Console.ReadLine();
        }
        #endregion

        #region CREATE
        public static Company CreateCompany()
        {
            Company company = new Company();

            BasicInfo(company);

            return company;
        }

        public static Supplier CreateSupplier()
        {
            Supplier supplier = new Supplier();

            BasicInfo(supplier);

            Console.Write("\nSupplier Payment Conditions: ");
            supplier.PaymentConditions = Console.ReadLine();

            return supplier;
        }

        public static Client CreateClient()
        {
            Client client = new Client();

            BasicInfo(client);

            Console.Write("\nClient Payment Conditions: ");
            client.PaymentConditions = Console.ReadLine();

            client.CreditLimit = TryReadInt("Client Credit Limit");

            return client;
        }
        #endregion

        #region LIST

        /// <summary>
        /// This method allows to list all the clients inside a list of clients
        /// </summary>
        /// <param name="clients">List of clients</param>
        public static void List(List<Client> clients)
        {
            foreach(Client client in clients)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine(client.ToString());
                Console.WriteLine("***************************************");
            }
        }

        /// <summary>
        /// This method allows to list all the suppliers inside a list of suppliers
        /// </summary>
        /// <param name="suppliers">Suppliers of clients</param>
        public static void List(List<Supplier> suppliers)
        {
            foreach (Supplier supplier in suppliers)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine(supplier.ToString());
                Console.WriteLine("***************************************");
            }
        }

        /// <summary>
        /// This method allows to list the company
        /// </summary>
        /// <param name="company">Company to list</param>
        public static void List(Company company)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine(company.ToString());
            Console.WriteLine("***************************************");
            
        }

        #endregion

        private static int TryReadInt(string msg)
        {
            int info;

            Console.Write($"\n{msg}: ");

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Não colocou um número valido!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{msg}: ");
                tryInfo = int.TryParse(Console.ReadLine(), out info);
            }
            return info;

        }

        #endregion

    }
}
