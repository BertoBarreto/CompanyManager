using System;
//using System.IO;
using DataCheckDLL;
namespace CompanyDLL
{
    public class Company
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
            //string data = CheckForCompany();

            //if (data != null)
            //{

            //    string[] getData = data.Split(',');
            //    name = getData[0];
            //    address = getData[1];
            //    nif = int.Parse(getData[2]);
            //    mobileContact = int.Parse(getData[3]);
            //    email = getData[4];
            //    country = getData[5];
            //}
            //else
            //{
                Console.Write("\nCompany Name: ");
                Name = Console.ReadLine();


                Console.Write("\nCompany Address: ");
                Address = Console.ReadLine();

                Nif = DataCheck.TryReadInt("Company Nif: ");

                MobileContact = DataCheck.TryReadInt("Company Mobile Contact: ");


                Console.Write("\nCompany Email: ");
                Email = Console.ReadLine();


                Console.Write("\nCompany Country: ");
                Country = Console.ReadLine();

            //    SaveCompany();
            //}

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

        //private static void SaveCompany()
        //{
        //    try
        //    {
        //        string data = string.Format($"{name},{address},{Nif},{MobileContact},{Email},{Country}");

        //        File.WriteAllText("D:\\vscode\\Escola\\2Semestre\\LP2\\CompanyManager\\CompanyManager\\Files\\company.csv", data);


        //    }
        //    catch
        //    {
        //        Console.WriteLine("Error saving in the data file");
        //    }
        //}

        //private static string CheckForCompany()
        //{
        //    try
        //    {
        //        string data;


        //        data = File.ReadAllText("D:\\vscode\\Escola\\2Semestre\\LP2\\CompanyManager\\CompanyManager\\Files\\company.csv");

        //        return data;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        #endregion

    }
}
