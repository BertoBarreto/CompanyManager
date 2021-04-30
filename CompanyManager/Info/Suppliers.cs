/// <summary>
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
    /// Purpose: This class manages the suppliers list
    /// </summary>
    public static class Suppliers
    {
        #region PROPERTIES
        static List<Supplier> suppliers = new List<Supplier>();
        #endregion

        #region METHODS

        #region SETTERS
        /// <summary>
        /// This method allows to add a supplier to the suppliers list
        /// </summary>
        /// <param name="supplier">Supplier to add</param>
        public static void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
        }
        #endregion

        #region GETTERS
        /// <summary>
        /// This method allows ot search a supplier by name
        /// </summary>
        /// <param name="name">Name of the supplier</param>
        public static void SearchSupplier(string name)
        {
            foreach(Supplier sup in suppliers)
            {
                if (sup.Name == name)
                {
                    Console.WriteLine($"{sup.ToString()}");
                    return;
                }
            }
        }
        /// <summary>
        /// This method allows to list all the suppliers in the suppliers list
        /// </summary>
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
