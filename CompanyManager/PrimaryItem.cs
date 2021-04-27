/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/6/2021 11:43:00 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class PrimaryItem:Iitem
    {
        #region PROPERTIES
        private string itemName;
        private int id;
        private double amount;

        public int Id
        {
            //to remove
            set { id = value; }
            get { return id; }
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

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// This is the class constructor
        /// </summary>
        /// <param name="itemId">Item id</param>
        /// <param name="amount">Amount of item in stock</param>
        /// <param name="itemName">Item name</param>
        public PrimaryItem(int itemId, double amount,string itemName)
        {
            this.id = itemId;
            this.amount = amount;
            this.itemName = itemName;
        }
        #endregion

        #region METHODS


        public override string ToString()
        {
            return string.Format($"\nItem: {itemName}\nId: {id}\nAmount: {amount}");
        }
        #region SETTERS
        /// <summary>
        /// This method allows to remove an amount to the stock
        /// </summary>
        /// <param name="amount">Amount to remove</param>
        public void RemoveAmount(double amount)
        {
            this.amount -= amount;
        }

        /// <summary>
        /// This method allows to add a amount to the stock
        /// </summary>
        /// <param name="amount">Amount to add</param>
        public void AddAmount(double amount)
        {
            this.amount += amount;
        }
        #endregion

        #region GETTERS
        /// <summary>
        /// This function checks if a item isnt null
        /// </summary>
        /// <param name="item">Item to check</param>
        /// <returns>True/False</returns>
        public bool IsNull()
        {
            if (itemName == null)
                return false;
            if (id < 0)
                return false;
            if (amount < 0)
                return false;
            return true;
        }
        #endregion

        #endregion

    }
}
