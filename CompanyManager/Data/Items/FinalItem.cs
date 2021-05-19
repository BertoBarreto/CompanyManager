/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 5:45:49 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager.Data.Items
{
    public class FinalItem : IItem
    {
        #region PROPERTIES
        private string itemName;
        private int id;
        private double amount;
        private double price;

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
        public double Price
        {
            get { return price; }
        }


        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Basic constructo of FinalItem class
        /// </summary>
        /// <param name="price">Item price</param>
        /// <param name="amount">Item amount</param>
        /// <param name="itemName">Item name</param>
        public FinalItem(double price, double amount, string itemName, int id)
        {
            this.id = id;
            this.amount = amount;
            this.itemName = itemName;
            this.price = price;
        }

        #endregion

        #region METHODS

        #region SETTERS
        /// <summary>
        /// This method allows to edit the product price
        /// </summary>
        /// <param name="price">New price</param>
        public void EditPrice(double price)
        {
            this.price = price;
        }


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
        public override string ToString()
        {
            return string.Format($"\nItem: {itemName}\nId: {id}\nStock: {amount}\nPrice: {price}"); ;
        }
        #endregion
    }
}
