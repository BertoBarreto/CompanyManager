/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 8:37:45 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using CompanyManager.Data.Items;

namespace CompanyManager.Rules
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class DataRules
    {
        #region DATACHECK
        #region METHODS
        /// <summary>
        /// This Function allows to read an int, allowing only int values to be stored
        /// </summary>
        /// <param name="msg">The message to show to the user to ask for the input</param>
        /// <returns>Int -> value read</returns>
        public static int GetInt(string msg)
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
        public static double GetDouble(string msg)
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
        public static int GetPrimaryItemId(string msg)
        {
            int info;
            bool exists = true;
            Console.Write(msg);

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo || !exists)
            {
                if (!exists)
                    ErrorMsg("Not a valid Number!");

                exists = true;
                Console.Write(msg);
                tryInfo = int.TryParse(Console.ReadLine(), out info);
                if (tryInfo)
                {
                    if (!PrimaryStock.GetItem(info))
                    {
                        ErrorMsg("Item doesnt Exist");
                        exists = false;
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
        public static int GetFinalItemId(string msg)
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
        /// This method allows to print a error message to the user in red
        /// </summary>
        /// <param name="msg">Message to print</param>
        public static void ErrorMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #endregion

    }
}
