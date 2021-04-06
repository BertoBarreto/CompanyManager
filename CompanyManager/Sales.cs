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
        private string itemName;
        private int itemId;
        private double amount;
        private double price;
        Client client;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

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
            itemName = null;
            itemId = -1;
            amount = -1;
            price = -1;
            client = null;
        }

        /// <summary>
        /// Basic Class constructor with parameters
        /// </summary>
        public Sales(string itemName, int itemId, double amount, double price)
        {
            this.itemName = itemName;
            this.itemId = itemId;
            this.amount = amount;
            this.price = price;
            client = InformationManager.CreateClient();
        }

        /// <summary>
        /// Basic Class constructor with parameters
        /// </summary>
        public Sales(string itemName, int itemId, double amount, double price, Client client)
        {
            this.itemName = itemName;
            this.itemId = itemId;
            this.amount = amount;
            this.price = price;
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
            if (itemName == null)
                return false;
            if (itemId < 0)
                return false;
            if(amount < 0)
                return false;
            if (price < 0)
                return false;
            


            return true;
        }

        #endregion

    }
}
