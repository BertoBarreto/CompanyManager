using System;

namespace IInformationDLL
{
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
