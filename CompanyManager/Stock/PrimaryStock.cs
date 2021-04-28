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
    public static class PrimaryStock
    {
        private static List<PrimaryItem> stock = new List<PrimaryItem>();

        #region METHODS

        #region SETTERS
        public static void AddItem(PrimaryItem item)
        {
            stock.Add(item);
        }

        
        #endregion

        #region GETTERS
        /// <summary>
        /// This method allows to get the stock
        /// </summary>
        /// <returns>List of PrimaryItems</returns>
        public static void GetStock()
        {
            foreach (PrimaryItem i in stock){
                Console.WriteLine($"{i}");
            }
        }

        /// <summary>
        /// This method allows to search for an item in the stock
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>PrimaryItem</returns>
        public static void GetItem(int id)
        {
            foreach (PrimaryItem i in stock) {
                if (i.Id == id)
                {
                    Console.WriteLine($"{i.ToString()}");
                    return;
                }
            }
            Console.WriteLine("The item you are looking for doesnt exist");
        }
        #endregion

        #endregion

    }
}
