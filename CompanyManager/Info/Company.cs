/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/31/2021 2:40:48 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: This class manages all the Company information
    /// </summary>
    public static class Company
    {
        #region PROPERTIES
        private static string name;
        private static string address;
        private static int nif;
        private static int mobileContact;
        private static string email;
        private static string country;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static string Address
        {
            get { return address; }
            set { address = value; }
        }
        public static int Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public static int MobileContact
        {
            get { return mobileContact; }
            set { mobileContact = value; }
        }
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }
        public static string Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion


        #region METHODS
        /// <summary>
        /// This function has the purpose to create a company getting all the necessary information
        /// </summary>
        public static void CreateCompany()
        {
            
            Console.Write("\nCompany Name: ");
            Name = Console.ReadLine();

            
            Console.Write("\nCompany Address: ");
            Address = Console.ReadLine();

            Nif = DataCheck.TryReadInt("Company Nif");
            
            MobileContact = DataCheck.TryReadInt("Company Mobile Contact");

            
            Console.Write("\nCompany Email: ");
            Email = Console.ReadLine();

            
            Console.Write("\nCompany Country: ");
            Country = Console.ReadLine();
            
        }

        /// <summary>
        /// This method returns all company information
        /// </summary>
        /// <returns>Formated String<returns>
        public static string GetCompanyInfo()
        {
            return string.Format($" Name: {Name}\n Address: {Address}\n Nif: " +
                $"{Nif}\n Mobile Contact: {MobileContact}\n Email: {Email}\n Country: {Country}");

        }


        #endregion
    }
}
