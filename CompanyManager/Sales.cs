/// <summary>
/// Purpose: This class manages the sales of the company
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/30/2021 11:14:54 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class Sales
    {
        #region PROPERTIES
        FinalItem item;
        Client client;

        public string Client
        {
            get { return client.ToString(); }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Basic Class constructor with no parameters
        /// </summary>
        public Sales()
        {
            item = null;
            client = null;
        }

        /// <summary>
        /// Basic Class constructor with parameters
        /// </summary>
        public Sales(string itemName, int itemId, double amount, double price)
        {
            this.item.ItemName = itemName;
            //this.item.ItemId = itemId;
            this.item.Amount = amount;
            this.item.Price = price;
            client = InformationManager.CreateClient();
        }

        /// <summary>
        /// Basic Class constructor with parameters
        /// </summary>
        public Sales(string itemName, int itemId, double amount, double price, Client client)
        {
            this.item.ItemName = itemName;
            //this.item.itemId = itemId;
            this.item.Amount = amount;
            this.item.Price = price;
            this.client = client;
        }
        #endregion

        #region METHODS

        #region SETTERS
        /// <summary>
        /// This method allows to create and set the sale client
        /// </summary>
        public void SetClient()
        {
            client = InformationManager.CreateClient();
        }

        /// <summary>
        /// This method allows to set a client to a sale
        /// </summary>
        /// <param name="client">Client to set to sale</param>
        public void SetClient(Client client)
        {
            this.client = client;
        }

        #endregion

        #region GETTERS

        #endregion
        /// <summary>
        /// This method checks if the client has information and the sale aswell
        /// </summary>
        /// <returns>Bool</returns>
        public bool CompleteSale()
        {
            if (!client.CheckInfo())
                return false;
            if (!client.CheckClientInfo())
                return false;
            if (!item.CheckInfo())
                return false;

            return true;
        }

        #endregion

    }
}