/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:18:25 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CompanyManager.Rules;

namespace CompanyManager.Data.Information
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class Clients
    {
        #region PROPERTIES
        private static List<Client> clients = new List<Client>();
        #endregion
        #region METHODS


        #region LIST

        /// <summary>
        /// This method allows to list all the clients inside a list of clients
        /// </summary>
        /// <param name="clients">List of clients</param>
        public static void List()
        {
            foreach (Client client in clients)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine(client.ToString());
            }
        }

        /// <summary>
        /// This method allows to add a client to the list of clients
        /// </summary>
        /// <param name="client">Client to add</param>
        public static void AddClient(Client client)
        {
            clients.Add(client);
        }

        /// <summary>
        /// This method allows to search for a client by its name
        /// </summary>
        /// <param name="name">Client Name</param>
        /// <returns>bool</returns>
        public static bool SearchClient(string name)
        {
            foreach (Client c in clients)
            {
                if (c.Name == name)
                {
                    Console.WriteLine($"\n{c}");
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method allows to search for a client by its id
        /// </summary>
        /// <param name="name">Client Name</param>
        /// <returns>bool</returns>
        public static bool SearchClient(int id)
        {
            foreach (Client c in clients)
            {
                if (c.Id == id)
                {
                    Console.WriteLine($"\n{c}");
                    return true;
                }
            }
            return false;
        }
        #endregion

        /// <summary>
        /// This method allows so save Clients data
        /// </summary>
        public static void SaveClients()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CompanyManager\Data\Information";
             
            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (Client client in clients)
                {

                    sb.AppendFormat($"{client.Id},{client.Name},{client.MobileContact},{client.Nif},{client.Address},{client.Country},{client.CreditLimit},{client.Email},{client.PaymentConditions},");
                    sb.Remove(sb.Length - 1, 1);
                    sb.AppendLine();
                }
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                File.WriteAllText(path + @"\clients.csv", sb.ToString(), Encoding.UTF8);


            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }

        #endregion

    }
}
