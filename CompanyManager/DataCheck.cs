/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/30/2021 5:57:41 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: This class does all the data checking when reading and writing values
    /// </summary>
    public static class DataCheck
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

            Console.Write($"\n{msg}: ");

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Não colocou um número valido!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{msg}: ");
                tryInfo = int.TryParse(Console.ReadLine(), out info);
            }
            return info;

        }
        #endregion

    }
}
