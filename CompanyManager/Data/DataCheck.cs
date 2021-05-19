/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 5:44:47 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using CompanyManager.Data.Items;

namespace CompanyManager.Data
{
    public class DataCheck
    {
        #region METHODS
        /// <summary>
        /// This Function allows to read an int, allowing only int values to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Int -> value read</returns>
        public static int TryReadInt(string msg)
        {
            int info;

            Console.Write(msg);

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo)
            {
                ErrorMsg("Not a valid Number!");
                Console.WriteLine(msg);
                tryInfo = int.TryParse(Console.ReadLine(), out info);
            }
            return info;

        }

        /// <summary>
        /// This Function allows to read a double, allowing only double values to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Double -> value read</returns>
        public static double TryReadDouble(string msg)
        {
            double info;

            Console.Write(msg);

            bool tryInfo = double.TryParse(Console.ReadLine(), out info);

            while (!tryInfo)
            {
                ErrorMsg("Not a valid Number!");
                Console.Write(msg);
                tryInfo = double.TryParse(Console.ReadLine(), out info);
            }
            return info;

        }

        /// <summary>
        /// This Function allows to read an int and a primary stock item, allowing only id's of items that exist to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Int -> id read</returns>
        public static int TryReadPrimaryItemId(string msg)
        {
            int info;
            bool exists = true;
            Console.Write(msg);

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo || !exists)
            {
                if (exists)
                    ErrorMsg("Not a valid Number!");

                exists = true;
                Console.Write(msg);
                tryInfo = int.TryParse(Console.ReadLine(), out info);
                if (tryInfo)
                {
                    if (!PrimaryStock.GetItem(info))
                    {
                        ErrorMsg("Item doesnt Exist");
                    }
                }
            }
            return info;

        }

        /// <summary>
        /// This Function allows to read an int and a primary stock item, allowing only id's of items that exist to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Int -> id read</returns>
        public static int TryReadFinalItemId(string msg)
        {
            int info;
            bool exists = true;

            Console.Write(msg);

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo || !exists)
            {
                if (exists)
                    ErrorMsg("Not a valid Number!");
                exists = true;
                Console.WriteLine($"{msg} ");
                tryInfo = int.TryParse(Console.ReadLine(), out info);
                if (tryInfo && !FinalStock.GetItem(info))
                {
                    exists = false;
                }
            }
            return info;

        }

        /// <summary>
        /// This method allows to get final item id's list and show information of all the items in final stock
        /// </summary>
        /// <param name="lst">List of final itme id's</param>
        public static void ShowList(List<int> lst)
        {
            foreach (int i in lst)
            {
                PrimaryStock.GetItem(i);
            }
        }

        public static void ErrorMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}
