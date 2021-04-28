/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 4/27/2021 12:21:30 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public static class Suppliers
    {
        #region PROPERTIES
        static List<Supplier> suppliers = new List<Supplier>();
        #endregion

        #region METHODS

        #region SETTERS
        public static void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
        }
        #endregion

        #region GETTERS
        public static void SearchSupplier(string name)
        {
            foreach(Supplier sup in suppliers)
            {
                //fazer um equals
            }
        }

        public static void ListSuppliers()
        {
            foreach(Supplier sup in suppliers)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine(sup.ToString());
            }
        }
        #endregion

        #endregion

    }
}
