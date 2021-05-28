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
    public static class InformationRules
    {


        #region CLIENT


        /// <summary>
        /// This Function allows to read an int and a clinet, allowing only id's of clients that exist to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Int -> id read</returns>
        public static int GetClientId(string msg)
        {
            int info;
            bool exists = true;
            Console.Write(msg);

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo || !exists)
            {
                if (!exists)
                    DataRules.ErrorMsg("Not a valid Number!");

                exists = true;
                Console.Write(msg);
                tryInfo = int.TryParse(Console.ReadLine(), out info);
                if (tryInfo)
                {
                    if (!Clients.SearchClient(info))
                    {
                        DataRules.ErrorMsg("Client doesnt Exist");
                        exists = false;
                    }
                }
            }
            return info;

        }
       


        /// <summary>
        /// This method allows to change the client name
        /// </summary>
        public static void ChangeClientName()
        {
            int id = GetClientId("Client id:");

            Console.WriteLine("New Client Name: ");
            string Name = Console.ReadLine();

            DataBase.UpdateClientName(id, Name);
        }

        /// <summary>
        /// This method allows to change the client address
        /// </summary>
        public static void ChangeClientAddress()
        {
            int id = GetClientId("Client id:");

            Console.WriteLine("New Client address: ");
            string address = Console.ReadLine();

            DataBase.UpdateClientAddress(id, address);
        }

        /// <summary>
        /// This method allows to change the client nif
        /// </summary>
        public static void ChangeClientNif()
        {
            int id = GetClientId("Client id:");

            int nif = DataRules.GetInt("New Client NIF: ");

            DataBase.UpdateClientNif(id, nif);
        }

        /// <summary>
        /// This method allows to change the client Mobile Contact
        /// </summary>
        public static void ChangeClientMobileContact()
        {
            int id = GetClientId("Client id:");

            int contact = DataRules.GetInt("New Client Mobile Contact: ");

            DataBase.UpdateClientMobileContact(id, contact);
        }


        /// <summary>
        /// This method allows to change the client Email
        /// </summary>
        public static void ChangeClientEmail()
        {
            int id = GetClientId("Client id:");

            Console.WriteLine("New Client Email: ");
            string email = Console.ReadLine();

            DataBase.UpdateClientEmail(id, email);
        }

        /// <summary>
        /// This method allows to change the client Country
        /// </summary>
        public static void ChangeClientCountry()
        {
            int id = GetClientId("Client id:");

            Console.WriteLine("New Client Country: ");
            string country = Console.ReadLine();

            DataBase.UpdateClientCountry(id, country);
        }

        /// <summary>
        /// This method allows to change the client Credit Limit
        /// </summary>
        public static void ChangeClientCreditLimit()
        {
            int id = GetClientId("Client id:");

            int credit = DataRules.GetInt("New Client Credit Limit: ");

            DataBase.UpdateClientCreditLimit(id, credit);
        }

        /// <summary>
        /// This method allows to change the client payment Conditions
        /// </summary>
        public static void ChangeClientPaymentConditions()
        {
            int id = GetClientId("Client id:");

            Console.WriteLine("New Client Payment Conditions: ");
            string paymentConditions = Console.ReadLine();

            DataBase.UpdateClientPaymentConditions(id, paymentConditions);
        }




        /// <summary>
        /// This Function allows to Create and add a new client
        /// </summary>
        public static void AddNewClient()
        {
            
			Console.Write("\nClient Name: ");
			string Name = Console.ReadLine();

			Console.Write("\nClient Address: ");
			string Address = Console.ReadLine();

			int Nif = DataRules.GetInt("Client Nif: ");

			int MobileContact = DataRules.GetInt("Client Mobile Contact: ");

			Console.Write("\nClient Email: ");
			string Email = Console.ReadLine();

			Console.Write("\nClient Country: ");
			string Country = Console.ReadLine();

			Console.Write("\nClient Payment Conditions: ");
			string PaymentConditions = Console.ReadLine();

			int CreditLimit = DataRules.GetInt("Client Credit Limit: "); 
			
            Client client = new Client(Name,Address,Nif,MobileContact,Email,Country,PaymentConditions,CreditLimit);
            DataBase.InsertClient(client);

        }

        #endregion

        #region SUPPLIERS
        /// <summary>
        /// This Function allows to read an int and a clinet, allowing only id's of Suppliers that exist to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Int -> id read</returns>
        public static int GetSupplierId(string msg)
        {
            int info;
            bool exists = true;
            Console.Write(msg);

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo || !exists)
            {
                if (!exists)
                    DataRules.ErrorMsg("Not a valid Number!");

                exists = true;
                Console.Write(msg);
                tryInfo = int.TryParse(Console.ReadLine(), out info);
                if (tryInfo)
                {
                    if (!Suppliers.SearchSupplier(info))
                    {
                        DataRules.ErrorMsg("Supplier doesnt Exist");
                        exists = false;
                    }
                }
            }
            return info;

        }

        /// <summary>
        /// This method allows to change the Supplier name
        /// </summary>
        public static void ChangeSupplierName()
        {
            int id = GetSupplierId("Supplier id:");

            Console.WriteLine("New Supplier Name: ");
            string Name = Console.ReadLine();

            DataBase.UpdateSupplierName(id, Name);
        }

        /// <summary>
        /// This method allows to change the Supplier address
        /// </summary>
        public static void ChangeSupplierAddress()
        {
            int id = GetSupplierId("Supplier id:");

            Console.WriteLine("New Supplier address: ");
            string address = Console.ReadLine();

            DataBase.UpdateSupplierAddress(id, address);
        }

        /// <summary>
        /// This method allows to change the Supplier nif
        /// </summary>
        public static void ChangeSupplierNif()
        {
            int id = GetSupplierId("Supplier id:");

            int nif = DataRules.GetInt("New Supplier NIF: ");

            DataBase.UpdateSupplierNif(id, nif);
        }

        /// <summary>
        /// This method allows to change the Supplier Mobile Contact
        /// </summary>
        public static void ChangeSupplierMobileContact()
        {
            int id = GetSupplierId("Supplier id:");

            int contact = DataRules.GetInt("New Supplier Mobile Contact: ");

            DataBase.UpdateSupplierMobileContact(id, contact);
        }


        /// <summary>
        /// This method allows to change the Supplier Email
        /// </summary>
        public static void ChangeSupplierEmail()
        {
            int id = GetSupplierId("Supplier id:");

            Console.WriteLine("New Supplier Email: ");
            string email = Console.ReadLine();

            DataBase.UpdateSupplierEmail(id, email);
        }

        /// <summary>
        /// This method allows to change the Supplier Country
        /// </summary>
        public static void ChangeSupplierCountry()
        {
            int id = GetSupplierId("Supplier id:");

            Console.WriteLine("New Supplier Country: ");
            string country = Console.ReadLine();

            DataBase.UpdateSupplierCountry(id, country);
        }

        /// <summary>
        /// This method allows to change the Supplier payment Conditions
        /// </summary>
        public static void ChangeSupplierPaymentConditions()
        {
            int id = GetSupplierId("Supplier id:");

            Console.WriteLine("New Supplier Payment Conditions: ");
            string paymentConditions = Console.ReadLine();

            DataBase.UpdateSupplierPaymentConditions(id, paymentConditions);
        }


        /// <summary>
        /// This Function allows to Create and add a new supplier
        /// </summary>
        public static void AddNewSupplier()
        {
            Console.Write("\nSupplier Name: ");
            string name = Console.ReadLine();

            Console.Write("\nSupplier Address: ");
            string address = Console.ReadLine();

            int nif = DataRules.GetInt("Supplier Nif: ");

            int mobileContact = DataRules.GetInt("Supplier Mobile Contact: ");

            Console.Write("\nSupplier Email: ");
            string email = Console.ReadLine();

            Console.Write("\nSupplier Country: ");
            string country = Console.ReadLine();

            Console.Write("\nSupplier Payment Conditions: ");
            string paymentConditions = Console.ReadLine();

            Supplier supplier = new Supplier(name,address,nif,mobileContact,email,country,paymentConditions);
            Suppliers.AddSupplier(supplier);

        }

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

        #region COMPANY
        /// <summary>
        /// This method allows to print the company info
        /// </summary>
        public static void GetCompanyInfo()
        {
            DataBase.GetCompanyInfo();
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

        /// <summary>
        /// This method allows to create a company and return it
        /// </summary>
        /// <returns>Company</returns>
        public static Company CreateCompany()
        {

            Console.Write("\nCompany Name: ");
            string Name = Console.ReadLine();

            Console.Write("\nCompany Address: ");
            string Address = Console.ReadLine();

            int Nif = DataRules.GetInt("Company Nif: ");

            int MobileContact = DataRules.GetInt("Company Mobile Contact: ");

            Console.Write("\nCompany Email: ");
            string Email = Console.ReadLine();

            Console.Write("\nCompany Country: ");
            string Country = Console.ReadLine();

            Company c = new Company(Name, Address, Nif, MobileContact, Email, Country);

            return c;
        }
        #endregion


    }
}
