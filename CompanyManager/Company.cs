/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/31/2021 2:40:48 PM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public class Company : Information
    {
        #region PROPERTIES





        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Basic Class constructor with no parameters
        /// </summary>
        public Company()
        {
            Name = null;
            Address = null;
            Nif = -1;
            MobileContact = -1;
            Email = null;
            Country = null;

        }
        /// <summary>
        /// Class constructor with parameters
        /// </summary>
        /// <param name="Name">Company name</param>
        /// <param name="Address">Company address</param>
        /// <param name="Nif">Company nif</param>
        /// <param name="MobileContact">Company mobile contact</param>
        /// <param name="Email">Company email</param>
        /// <param name="Country">Company country</param>

        public Company(string Name, string Address, int Nif, int MobileContact, string Email, string Country)
        {
            this.Name = Name;
            this.Address = Address;
            this.Nif = Nif;
            this.MobileContact = MobileContact;
            this.Email = Email;
            this.Country = Country;

        }

        #endregion

        #region METHODS
        /// <summary>
        /// This method overrides the ToString Method of the Client
        /// </summary>
        /// <returns>Formated String<returns>
        public override string ToString()
        {
            return string.Format($" Name: {Name}\n Address: {Address}\n Nif: " +
                $"{Nif}\n Mobile Contact: {MobileContact}\n Email: {Email}\n Country: {Country}");

        }
        #endregion
    }
}
