/// <summary>
/// Purpose: This class has the company final product
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/6/2021 12:00:35 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class FinalItem : PrimaryItem, Iitem
    {
        #region PROPERTIES
        private double price;


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
        public FinalItem(double price, double amount, string itemName) : base(amount, itemName)
        {

            this.price = price;
        }

        #endregion

        #region METHODS
        public bool CheckInfo()
        {
            if (ItemName == null)
                return false;
            if (Id < 0)
                return false;
            if (Amount < 0)
                return false;
            if (price < 0)
                return false;

            return true;
        }


        #region SETTERS
        /// <summary>
        /// This method allows to edit the product price
        /// </summary>
        /// <param name="price">New price</param>
        public void EditPrice(double price)
        {
            this.price = price;
        }
        #endregion

        #region GETTERS

        #endregion

        #endregion

    }
}
