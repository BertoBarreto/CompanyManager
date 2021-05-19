using System;
using System.Collections.Generic;
using ClientDLL;

namespace ClientsDLL
{
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

        public static void SearchClient(string name)
        {
            foreach (Client c in clients)
            {
                if (c.Name == name)
                    Console.WriteLine($"\n{c}");
            }
        }
        #endregion



        #endregion
    }
}
