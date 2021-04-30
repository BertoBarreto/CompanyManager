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
        private static List<PrimaryItem> primaryStock = new List<PrimaryItem>();
        private static List<FinalItem> finalStock = new List<FinalItem>();
        static int idPrimary = -1;
        static int idFinal = -1;

        #region METHODS

        #region SETTERS
        /// <summary>
        /// This fucntion allows to add a primary item to the stocks list
        /// </summary>
        /// <param name="item"></param>
        public static void AddItem(PrimaryItem item)
        {
            primaryStock.Add(item);
        }

        /// <summary>
        /// This fucntion allows to add a primary item to the stocks list
        /// </summary>
        /// <param name="item"></param>
        public static void AddItem(FinalItem item)
        {
            primaryStock.Add(item);
        }

        #endregion

        #region GETTERS
        /// <summary>
        /// This function allows to get the current id count
        /// </summary>
        /// <returns>int -> id</returns>
        public static int GetPrimaryNextId()
        {
            idPrimary++;
            return idPrimary;
        }

        /// <summary>
        /// This function allows to get the current id count
        /// </summary>
        /// <returns>int -> id</returns>
        public static int GetFinalNextId()
        {
            idFinal++;
            return idFinal;
        }

        /// <summary>
        /// This method allows to get the stock listed in the stock
        /// </summary>
        public static void GetPrimaryStock()
        {
            foreach (PrimaryItem i in primaryStock)
            {
                Console.WriteLine($"{i.ToString()}");
            }
        }

        /// <summary>
        /// This method allows to get the stock listed in the console
        /// </summary>
        public static void GetFinalStock()
        {
            foreach (FinalItem i in finalStock)
            {
                Console.WriteLine($"{i.ToString()}");
            }
        }

        /// <summary>
        /// This method allows to search for an item in the stock
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>PrimaryItem</returns>
        public static void GetPrimaryItem(int id)
        {
            foreach (PrimaryItem i in primaryStock) {
                if (i.Id == id)
                {
                    Console.WriteLine($"{i.ToString()}");
                    return;
                }
            }
            Console.WriteLine("The item you are looking for doesnt exist");
        }

        /// <summary>
        /// This method allows to search for an item in the stock
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>PrimaryItem</returns>
        public static void GetFinalItem(int id)
        {
            foreach (FinalItem i in finalStock)
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
