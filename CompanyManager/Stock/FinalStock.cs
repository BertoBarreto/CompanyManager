/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/27/2021 11:16:37 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class FinalStock
    {
        #region PROPERTIES
        private static List<FinalItem> stock = new List<FinalItem>();
        #endregion



        #region METHODS

        #region SETTERS
        public static void AddItem(FinalItem item)
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
            foreach (FinalItem i in stock)
            {
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
            foreach (FinalItem i in stock)
            {
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
