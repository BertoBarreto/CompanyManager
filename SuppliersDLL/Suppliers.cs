using System;
using System.Collections.Generic;
using SupplierDLL;

namespace SuppliersDLL
{
    public class Suppliers
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
            foreach (Supplier sup in suppliers)
            {
                if (sup.Name == name)
                {
                    Console.WriteLine($"{sup}");
                    return;
                }
            }
        }
        /// <summary>
        /// This method allows to list all the suppliers in the suppliers list
        /// </summary>
        public static void ListSuppliers()
        {
            foreach (Supplier sup in suppliers)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine(sup.ToString());
            }
        }
        #endregion

        #endregion

    }
}
