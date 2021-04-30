﻿/// <summary>
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 3/30/2021 11:44:16 AM
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManager
{
    /// <summary>
    /// This class gives all the rules to the client and supplier classes
    /// </summary>
    public interface IInformation
    {
        #region PROPERTIES
        string Name { get; }
        string Address { get; }
        int Nif { get; }
        int MobileContact { get; }
        string Email { get; }
        string Country { get; }
        #endregion

        #region METHODS
        #region SETTERS
        void SetName(string name);
        void SetAddress(string address);
        void SetNif(int nif);
        void SetMobileContact(int Contact);
        void SetEmail(string email);
        void SetCountry(string country);
        #endregion

        #endregion

    }
}
