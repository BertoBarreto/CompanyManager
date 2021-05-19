using System;
using IItemDLL;

namespace PrimaryItemDLL
{
    public class PrimaryItem:IItem
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
        public PrimaryItem(double amount, string itemName,int id)
        {
            this.id = id;
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
            return string.Format($"\nItem: {itemName}\nId: {id}\nStock: {amount}");
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
