/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/18/2021 7:16:54 PM
/// </summary>
using CompanyManager.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompanyManager.Data.Information
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
        public static bool SearchSupplier(string name)
        {
            foreach (Supplier sup in suppliers)
            {
                if (sup.Name == name)
                {
                    Console.WriteLine($"{sup}");
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method allows ot search a supplier by id
        /// </summary>
        /// <param name="name">Name of the supplier</param>
        public static bool SearchSupplier(int id)
        {
            foreach (Supplier sup in suppliers)
            {
                if (sup.Id == id)
                {
                    Console.WriteLine($"{sup}");
                    return true;
                }
            }
            return false;
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
        /// <summary>
        /// This method allows to save Supplier data
        /// </summary>
        public static void SaveSupplier()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CompanyManager\Data\Information";
             
            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (Supplier supplier in suppliers)
                {

                    sb.AppendFormat($"{supplier.Id},{supplier.Name},{supplier.nif},{supplier.Address},{supplier.Country},{supplier.MobileContact},{supplier.PaymentConditions},{supplier.Email},");
                    sb.Remove(sb.Length - 1, 1);
                    sb.AppendLine();
                }
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                File.WriteAllText(path + @"\suppliers.csv", sb.ToString(), Encoding.UTF8);


            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }
        #endregion

    }
}
