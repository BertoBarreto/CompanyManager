/// <summary>
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
    /// Purpose: This class is the primary item management class, it has all the information about the item
    /// </summary>
    public class PrimaryItem:Iitem
    {
        #region PROPERTIES
        private string itemName;
        private int id;
        private double amount;

        public int Id
        {
            get { return id; }
        }

        public double Amount
        {
            get { return amount; }
        }

        public string ItemName
        {
            get { return itemName; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// This is the class constructor
        /// </summary>
        /// <param name="itemId">Item id</param>
        /// <param name="amount">Amount of item in stock</param>
        /// <param name="itemName">Item name</param>
        public PrimaryItem(double amount,string itemName)
        {
            this.id = Stock.GetPrimaryNextId();
            this.amount = amount;
            this.itemName = itemName;
        }
        #endregion

        #region METHODS

        /// <summary>
        /// This method allows to turn this item into a string
        /// </summary>
        /// <returns>String -> formated string with item information</returns>
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

        /// <summary>
        /// This method allows to edit the item name
        /// </summary>
        /// <param name="name">The new item name</param>
        public void EditItem(string name)
        {
            this.itemName = name;
        }
        #endregion

        #region GETTERS
        #endregion

        #endregion

    }
}
