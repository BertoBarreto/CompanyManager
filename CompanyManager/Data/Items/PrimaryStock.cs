/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:11:21 PM
/// </summary>
using CompanyManager.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompanyManager.Data.Items
{

    public class PrimaryStock
    {
        private static List<PrimaryItem> stock = new List<PrimaryItem>();

        static int id = -1;


        #region METHODS

        #region SETTERS
        /// <summary>
        /// This fucntion allows to add a primary item to the stocks list
        /// </summary>
        /// <param name="item"></param>
        public static void AddItem(PrimaryItem item)
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
        /// This method allows to get the stock listed in the stock
        /// </summary>
        public static void GetStock()
        {
            foreach (PrimaryItem i in stock)
            {
                Console.WriteLine($"{i}");
            }
        }
        /// <summary>
        /// This method allows to get the stock of a primary item with his id
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>Stock -> double</returns>
        public static double GetStock(int id)
        {
            foreach (PrimaryItem i in stock)
            {
                if (i.Id == id)
                {
                    return i.Amount;
                }
            }
            return -1;
        }

        /// <summary>
        /// This method allows to search for an item in the stock
        /// </summary>
        /// <param name="id">Item id</param>
        /// <returns>PrimaryItem</returns>
        public static bool GetItem(int id)
        {
            foreach (PrimaryItem i in stock)
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

        /// <summary>
        /// This method allows to check is there is enough stock for a amount needed in the Primary stock
        /// </summary>
        /// <returns>bool</returns>
        public static bool HasEnough(double amount, int itemId)
        {
            
            if (GetStock(itemId) >= amount)
                return true;

            return false;
        }
        #endregion
        /// <summary>
        /// This method allows so save PrimaryStock data
        /// </summary>
        public static void SavePrimaryStock()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CompanyManager\Data\Items";
             
            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (PrimaryItem primaryItem in stock)
                {

                    sb.AppendFormat($"{primaryItem.Id},{primaryItem.Name},{primaryItem.Amount},");
                    sb.Remove(sb.Length - 1, 1);
                    sb.AppendLine();
                }
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                File.WriteAllText(path + @"\PrimaryStock.csv", sb.ToString(), Encoding.UTF8);


            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }
        #endregion

    }
}
