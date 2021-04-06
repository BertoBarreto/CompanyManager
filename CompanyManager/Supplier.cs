/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/30/2021 11:59:25 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class Supplier : Information
    {
        #region PROPERTIES
        private string paymentConditions;

        public string PaymentConditions
        {
            get { return paymentConditions; }
            set { paymentConditions = value; }
        }
        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Basic Class constructor with no parameters
        /// </summary>
        public Supplier()
        {
            Name = null;
            Address = null;
            Nif = -1;
            MobileContact = -1;
            Email = null;
            Country = null;
            paymentConditions = null;
        }
        /// <summary>
        /// Class Constructor with parameters
        /// </summary>
        /// <param name="Name">Supplier name</param>
        /// <param name="Address">Supplier address</param>
        /// <param name="Nif">Supplier nif</param>
        /// <param name="MobileContact">Supplier mobile contact</param>
        /// <param name="Email">Supplier email</param>
        /// <param name="Country">Supplier country</param>
        /// <param name="paymentConditions">Supplier payment Conditions</param>
        public Supplier(string Name, string Address, int Nif, int MobileContact, string Email, string Country, string paymentConditions)
        {
            this.Name = Name;
            this.Address = Address;
            this.Nif = Nif;
            this.MobileContact = MobileContact;
            this.Email = Email;
            this.Country = Country;
            this.paymentConditions = paymentConditions;
        }

        #endregion

        #region METHODS
        /// <summary>
        /// This method overrides the ToString Method of the Client
        /// </summary>
        /// <returns>Formated String<returns>
        public override string ToString() {

            return string.Format($" Name:{Name}\n Address: {Address}\n Nif:" +
                $"{Nif}\n Mobile Contact: {MobileContact}\n Email:{Email}\n Country:{Country}"+
                $"\n Payment conditions: {PaymentConditions}");
        }

        

        #region SETTERS

        #endregion

        #region GETTERS

        #endregion

        #endregion

    }
}
