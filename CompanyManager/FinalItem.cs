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
    public class FinalItem : Item
    {
        #region PROPERTIES
        private double price;


        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        
        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Basic Class constructor
        /// </summary>
        public FinalItem()
        {

        }

        #endregion

        #region METHODS
        public bool CheckInfo()
        {
            if (ItemName == null)
                return false;
            if (ItemId < 0)
                return false;
            if (Amount < 0)
                return false;
            if (price < 0)
                return false;

            return true;
        }


        #region SETTERS

        #endregion

        #region GETTERS

        #endregion

        #endregion

    }
}
