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
    public class Item
    {
        #region PROPERTIES
        private string itemName;
        private int itemId;
        private double amount;

        public int ItemId
        {
            get { return itemId; }
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
        /// Basic Class constructor
        /// </summary>
        public Item()
        {

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
