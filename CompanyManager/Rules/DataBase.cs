/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 9:46:26 PM
/// </summary>
using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using CompanyManager.Data.Information;
using CompanyManager.Data.Items;

namespace CompanyManager.Rules
{

    /// <summary>
    /// Purpose: This class manages the database
    /// </summary>
    public static class DataBase
    {


        static LinqToSqlDataClassesDataContext dataContext;
        /// <summary>
        /// This method allows to start a connection to the database and load all the database information
        /// </summary>
        public static void StartConnection()
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["CompanyManager.Properties.Settings.CompanyManagerDBConnectionString1"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            if (dataContext.Companies == null)
                InsertCompany(InformationRules.CreateCompany());

            foreach (Client c in dataContext.Clients)
            {
                Clients.AddClient(c);
                FileManager.SaveRecipe(c);
            }
            
            foreach (Supplier s in dataContext.Suppliers)
            {
                Suppliers.AddSupplier(s);
            }

            foreach (PrimaryItem i in dataContext.PrimaryItems)
            {
                PrimaryStock.AddItem(i);
            }

            foreach (FinalItem i in dataContext.FinalItems)
            {
                FinalStock.AddItem(i);
            }

            foreach(RecipeItem i in dataContext.RecipeItems)
            {
                Recipes.AddRecipe(i, i.FinalItem);
            }
        }

        #region INSERTIONS
        /// <summary>
        /// This method allows to insert a client in the clients class and in the database
        /// </summary>
        /// <param name="c">Client to insert</param>
        public static void InsertClient(Client c)
        { 
            dataContext.Clients.InsertOnSubmit(c);
            dataContext.SubmitChanges();
            Clients.AddClient(c);
        }

        /// <summary>
        /// This method allows to insert a supplier in the suppliers class and in the database
        /// </summary>
        /// <param name="s">Supplier to add</param>
        public static void InsertSupplier(Supplier s)
        {
            dataContext.Suppliers.InsertOnSubmit(s);
            dataContext.SubmitChanges();
            Suppliers.AddSupplier(s);
        }

        /// <summary>
        /// This method allows to insert a company in the database
        /// </summary>
        /// <param name="c">Company to insert</param>
        public static void InsertCompany(Company c)
        {
            dataContext.Companies.InsertOnSubmit(c);
            dataContext.SubmitChanges();

        }

        /// <summary>
        /// This method allows to print the company info that is stored in the database
        /// </summary>
        public static void GetCompanyInfo()
        {
            Console.WriteLine(dataContext.Companies.Single());
        }

        /// <summary>
        /// This method allows to insert a PRimary Item in the primary stock class and in the database
        /// </summary>
        /// <param name="i">Item do insert</param>
        public static void InsertPrimaryItem(PrimaryItem i)
        {
            Console.WriteLine(i.ToString());
            dataContext.PrimaryItems.InsertOnSubmit(i);
            dataContext.SubmitChanges();
            PrimaryStock.AddItem(i);
        }

        /// <summary>
        /// This method allows to insert a Final Item in the Final stock class and in the database
        /// </summary>
        /// <param name="i">Item do insert</param>
        public static void InsertFinalItem(FinalItem i)
        {
            Console.WriteLine(i.ToString());
            dataContext.FinalItems.InsertOnSubmit(i);
            dataContext.SubmitChanges();
            FinalStock.AddItem(i);
        }
        /// <summary>
        /// This method allows to insert a Recipe Item in the recipes class and in the database
        /// </summary>
        /// <param name="i">Item do insert</param>
        public static void InsertRecipeItem(RecipeItem i)
        {
            dataContext.RecipeItems.InsertOnSubmit(i);
            dataContext.SubmitChanges();
            Recipes.AddRecipe(i, i.FinalItem);
                
        }
        #endregion

        #region UPDATES

        #region CLIENTS
        /// <summary>
        /// This method allows to Update the Client name
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="name">New client name</param>
        public static void UpdateClientName(int id, string name)
        {
           
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.Name = name;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Client address
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="address">New client Address</param>
        public static void UpdateClientAddress(int id, string address)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.Address = address;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Client nif
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="nis">New client nif</param>
        public static void UpdateClientNif(int id, int nif)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.Nif = nif;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Client Mobile Contact
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="MobileContact">New client Mobile Contact</param>
        public static void UpdateClientMobileContact(int id, int mobileContact)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.MobileContact = mobileContact;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }


        /// <summary>
        /// This method allows to Update the Client Email
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="email">New client email</param>
        public static void UpdateClientEmail(int id, string email)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.Email = email;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Client Country
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="country">New client country</param>
        public static void UpdateClientCountry(int id, string country)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.Country = country;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the client Credit Limit
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="creditLimit">New client credit limit</param>
        public static void UpdateClientCreditLimit(int id, int creditLimit)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.CreditLimit = creditLimit;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Client payment Conditions
        /// </summary>
        /// <param name="id">Client id</param>
        /// <param name="paymentConditions">New client Address</param>
        public static void UpdateClientPaymentConditions(int id, string paymentConditions)
        {
            //Get Single course which need to update  
            Client client = dataContext.Clients.Single(c => c.Id == id);
            //Field which will be updated  
            client.PaymentConditions = paymentConditions;
            // executes the appropriate commands to implement the changes to the database  
            dataContext.SubmitChanges();
        }
        #endregion

        #region SUPPLIER
        /// <summary>
        /// This method allows to Update the Supplier name
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="name">New Supplier name</param>
        public static void UpdateSupplierName(int id, string name)
        {
     
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);
            
            Supplier.Name = name;
            
            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Supplier address
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="address">New Supplier Address</param>
        public static void UpdateSupplierAddress(int id, string address)
        {
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);

            Supplier.Address = address;

            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Supplier nif
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="nif">New Supplier Nif</param>
        public static void UpdateSupplierNif(int id, int nif)
        {
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);

            Supplier.nif = nif;

            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Supplier Mobile Contact
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="mobileContact">New Supplier mobile contact</param>
        public static void UpdateSupplierMobileContact(int id, int mobileContact)
        {
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);

            Supplier.MobileContact = mobileContact;

            dataContext.SubmitChanges();
        }


        /// <summary>
        /// This method allows to Update the Supplier Email
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="email">New Supplier email</param>
        public static void UpdateSupplierEmail(int id, string email)
        {
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);

            Supplier.Email = email;

            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Supplier Country
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="country">New Supplier country</param>
        public static void UpdateSupplierCountry(int id, string country)
        {
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);

            Supplier.Country = country;

            dataContext.SubmitChanges();
        }

        /// <summary>
        /// This method allows to Update the Supplier payment Conditions
        /// </summary>
        /// <param name="id">Supplier id</param>
        /// <param name="paymentConditions">New Supplier payment conditions</param>
        public static void UpdateSupplierPaymentConditions(int id, string paymentConditions)
        {
            Supplier Supplier = dataContext.Suppliers.Single(c => c.Id == id);

            Supplier.PaymentConditions = paymentConditions;

            dataContext.SubmitChanges();
        }
        #endregion

        #endregion
    }
}
