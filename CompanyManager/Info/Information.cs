/// <summary>
/// Purpose: This class has the basic information of clients, suppliers and company
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/30/2021 11:44:16 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    public class Information
    {
        #region PROPERTIES
        private string name;
        private string address;
        private int nif;
        private int mobileContact;
        private string email;
        private string country;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public int MobileContact
        {
            get { return mobileContact; }
            set { mobileContact = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method checks if information class has information
        /// </summary>
        /// <returns>Bool</returns>
        public bool CheckInfo()
        {
            if (name == null)
                return false;

            if (address == null)
                return false;

            if (nif <= 0)//verifiar se é nif
                return false;

            if (mobileContact <= 0) // verificar se tem 9 numeros
                return false;

            if (email == null)//verificar se é email
                return false;

            if (country == null) // verifiar base de dados de países
                return false;

            return true;
        }
        #region SETTERS

        #endregion

        #region GETTERS

        #endregion

        #endregion

    }
}
