/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:08:12 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager.Data.Items
{
    public class FinalStock
    {
        #region PROPERTIES
        private static List<FinalItem> stock = new List<FinalItem>();

        static int id = -1;
        #endregion

        #region METHODS

        #region SETTERS
        /// <summary>
        /// This fucntion allows to add a primary item to the stocks list
        /// </summary>
        /// <param name="item"></param>
        public static void AddItem(FinalItem item)
        {
            stock.Add(item);
        }
        #endregion

        #region GETTERS
        /// <summary>
        /// This function allows to get the current id count
        /// </summary>
        /// <returns>int -> id</returns>
        public static int GetNextId()
        {
            id++;
            return id;
        }

        /// <summary> 
        /// This method allows to get the stock listed in the console
        /// </summary>
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
        public static bool GetItem(int id)
        {
            foreach (FinalItem i in stock)
            {
                if (i.Id == id)
                {
                    Console.WriteLine($"{i}");
                    return true;
                }
            }
            Console.WriteLine("The item you are looking for doesnt exist");
            return false;
        }
        #endregion

        #endregion

    }
}
