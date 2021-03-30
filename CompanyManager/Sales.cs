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
        //client

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
            //client null
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
            //client
        }
        #endregion

        #region METHODS

        #region SETTERS

        #endregion

        #region GETTERS

        #endregion

        #endregion

    }
}
