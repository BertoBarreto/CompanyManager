/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 8:37:45 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using CompanyManager.Data;

namespace CompanyManager.Rules
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class DataRules
    {
        #region DATACHECK
        /// <summary>
        /// This method allows to get a integer
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>Int</returns>
        public static int GetInt(string msg)
        {
            return DataCheck.TryReadInt(msg);
        }

        /// <summary>
        /// This method allows to get a double
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>double</returns>
        public static double GetDouble(string msg)
        {
            return DataCheck.TryReadDouble(msg);
        }


        /// <summary>
        /// This method allows to get a primary item id
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>Int -> id</returns>
        public static int GetPrimaryItemId(string msg)
        {
            return DataCheck.TryReadPrimaryItemId(msg);
        }

        /// <summary>
        /// This method allows to get a final item id
        /// </summary>
        /// <param name="msg">Message to write</param>
        /// <returns>Int -> id</returns>
        public static int GetFinalItemId(string msg)
        {
            return DataCheck.TryReadFinalItemId(msg);
        }

        /// <summary>
        /// This method allows to print a error message to the user in red
        /// </summary>
        /// <param name="msg">Message to print</param>
        public static void ErrorMsg(string msg)
        {
            DataCheck.ErrorMsg(msg);
        }
        #endregion

    }
}
