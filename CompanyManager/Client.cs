/// <summary>
/// Purpose: This method has the client information
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/30/2021 11:54:39 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class Client : Information
    {
        #region PROPERTIES
        private string paymentConditions;
        private double creditLimit;

        public double CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }

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
        public Client()
        {
            Name = null;
            Address = null;
            Nif = -1;
            MobileContact = -1;
            Email = null;
            Country = null;
            paymentConditions = null;
            creditLimit = -1;
        }
        /// <summary>
        /// Class constructor with parameters
        /// </summary>
        /// <param name="Name">Client name</param>
        /// <param name="Address">Client address</param>
        /// <param name="Nif">Client nif</param>
        /// <param name="MobileContact">Client mobile contact</param>
        /// <param name="Email">Client email</param>
        /// <param name="Country">Client country</param>
        /// <param name="paymentConditions">Client payment Conditions</param>
        public Client(string Name, string Address, int Nif, int MobileContact, string Email, string Country, string paymentConditions, int creditLimit)
        {
            this.Name = Name;
            this.Address = Address;
            this.Nif = Nif;
            this.MobileContact = MobileContact;
            this.Email = Email;
            this.Country = Country;
            this.paymentConditions = paymentConditions;
            this.creditLimit = creditLimit;
        }

        #endregion

        #region METHODS

        #region SETTERS

        #endregion

        #region GETTERS

        #endregion

        public override string ToString()
        {
            return string.Format($"Name: {Name}\n Address: {Address}\n Nif: " +
                $"{Nif}\n Mobile Contact: {MobileContact}\n Email: {Email}\n Country: {Country}" +
                $" \n Payment Conditions: {paymentConditions}\n CreditLimit: {creditLimit}€");
        }

        #endregion

    }
}
