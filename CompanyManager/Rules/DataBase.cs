/// <summary>
/// Purpose: 
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

namespace CompanyManager.Rules
{

    /// <summary>
    /// Purpose: 
    /// </summary>
    public static class DataBase
    {


        static LinqToSqlDataClassesDataContext dataContext;
        public static void StartConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CompanyManager.Properties.Settings.CompanyManagerDBConnectionString1"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
        }

        public static void InsertClient(Client yale)
        {
            //Client yale = new Client();
            yale.Name = "Yale";
            yale.Address = "Viana do Castelo";
            yale.Country = "Portugal";
            yale.CreditLimit = 90000;
            yale.Email = "yale@gmail.com";
            yale.Nif = 99999999;
            yale.MobileContact = 969494110;
            yale.PaymentConditions = "2 meses";
            dataContext.Clients.InsertOnSubmit(yale);
            dataContext.SubmitChanges();

            foreach(Client c in dataContext.Clients)
            {
                Console.WriteLine(c);
            }
        }

    }
}
