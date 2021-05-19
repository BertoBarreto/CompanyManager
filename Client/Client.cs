using System;

namespace Client
{
    /// <summary>
    /// Purpose: This class manages all the client information
    /// </summary>
    public class Client
    {
        #region PROPERTIES
        private string name;
        public string Name
        {
            get { return name; }
        }

        private string address;
        public string Address
        {
            get { return address; }
        }

        private int nif;
        public int Nif
        {
            get { return nif; }
        }

        private int mobileContact;
        public int MobileContact
        {
            get { return mobileContact; }
        }

        private string email;
        public string Email
        {
            get { return email; }
        }

        private string country;
        public string Country
        {
            get { return country; }
        }

        private double creditLimit;
        public double CreditLimit
        {
            get { return creditLimit; }
        }

        private string paymentConditions;
        public string PaymentConditions
        {
            get { return paymentConditions; }
        }

        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// This constructor allows to get all the client information
        /// </summary>
        public Client()
        {
            Console.Write("\nClient Name: ");
            name = Console.ReadLine();

            Console.Write("\nClient Address: ");
            address = Console.ReadLine();

            nif = DataCheck.TryReadInt("Client Nif: ");

            mobileContact = DataCheck.TryReadInt("Client Mobile Contact: ");

            Console.Write("\nClient Email: ");
            email = Console.ReadLine();

            Console.Write("\nClient Country: ");
            country = Console.ReadLine();

            Console.Write("\nClient Payment Conditions: ");
            paymentConditions = Console.ReadLine();

            Console.Write("\nClient credit limit: ");
            creditLimit = DataCheck("Client Credit Limit");
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
        /// <param name="creditLimit">Client creditLimit</param>
        public Client(string Name, string Address, int Nif, int MobileContact, string Email, string Country, string paymentConditions, int creditLimit)
        {
            this.name = Name;
            this.address = Address;
            this.nif = Nif;
            this.mobileContact = MobileContact;
            this.email = Email;
            this.country = Country;
            this.paymentConditions = paymentConditions;
            this.creditLimit = creditLimit;
        }

        #endregion

        #region METHODS

        #region SETTERS

        /// <summary>
        /// This function allows to set the client name
        /// </summary>
        /// <param name="name">New Name</param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// This function allows to set the client address
        /// </summary>
        /// <param name="address">New Address</param>
        public void SetAddress(string address)
        {
            this.address = address;
        }

        /// <summary>
        /// This function allows to set the client nif
        /// </summary>
        /// <param name="nif">New Nif</param>
        public void SetNif(int nif)
        {
            this.nif = nif;
        }

        /// <summary>
        /// This function allows to set the client mobile contact
        /// </summary>
        /// <param name="contact">New mobile contact</param>
        public void SetMobileContact(int contact)
        {
            mobileContact = contact;
        }

        /// <summary>
        /// This function allows to set the client email
        /// </summary>
        /// <param name="email">New email</param>
        public void SetEmail(string email)
        {
            this.email = email;
        }

        /// <summary>
        /// This function allows ot set the client country
        /// </summary>
        /// <param name="country"></param>
        public void SetCountry(string country)
        {
            this.country = country;
        }

        /// <summary>
        /// This function allows to set the client credit limit
        /// </summary>
        /// <param name="limit"></param>
        public void SetCreditLimit(double limit)
        {
            this.creditLimit = limit;
        }

        /// <summary>
        /// This function allows to set the client payment conditions
        /// </summary>
        /// <param name="conditions"></param>
        public void SetPaymentConditions(string conditions)
        {
            this.paymentConditions = conditions;
        }
        #endregion

        #region GETTERS

        #endregion

        #region OVERRRIDES
        /// <summary>
        /// This method overrides the ToString Method of the Client
        /// </summary>
        /// <returns>Formated String<returns>
        public override string ToString()
        {
            return string.Format($" Name: {Name}\n Address: {Address}\n Nif: " +
                $"{Nif}\n Mobile Contact: {MobileContact}\n Email: {Email}\n Country: {Country}" +
                $" \n Payment Conditions: {paymentConditions}\n CreditLimit: {creditLimit}€");
        }

        /// <summary>
        /// This method allows to compare a client object to other object
        /// </summary>
        /// <param name="obj">Object to compare</param>
        /// <returns>true/false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Client c1)
            {
                if (c1.name != this.name)
                    return false;
                if (c1.address != this.address)
                    return false;
                if (c1.Email != this.email)
                    return false;
                if (c1.nif != this.nif)
                    return false;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #endregion

    }
}
