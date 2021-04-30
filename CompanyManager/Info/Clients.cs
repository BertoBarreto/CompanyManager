/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/31/2021 3:15:04 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: This class allows to manage the clients list
    /// </summary>
    public static class Clients
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
        #endregion



        #endregion

    }
}
