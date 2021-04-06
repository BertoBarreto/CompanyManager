/// <summary>
/// Purpose: This class manages the company stock
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/31/2021 4:00:23 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CompanyManager
{
    public static class Stock
    {
        #region PROPERTIES
        private static List<Item> stock;


        #endregion

        #region METHODS

        #region SETTERS

        #endregion

        #region GETTERS
        /// <summary>
        /// This method allows to get the stock
        /// </summary>
        /// <returns>List of Item</returns>
        public static List<Item> GetStock()
        {
            return stock;
        }

        /// <summary>
        /// This method allows to search for an item in the stock
        /// </summary>
        /// <param name="itemName">Item name</param>
        /// <returns>Item</returns>
        public static Item GetItem(string itemName)
        {
            foreach (Item i in stock) {
                if (i.ItemName == itemName)
                    return i;
            }

            return null;
        }
        #endregion

        #endregion

    }
}
