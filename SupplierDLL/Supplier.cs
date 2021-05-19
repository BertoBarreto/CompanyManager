using System;
using DataCheckDLL;
namespace SupplierDLL
{
    public class Supplier
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

        private string paymentConditions;

        public string PaymentConditions
        {
            get { return paymentConditions; }
        }
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// This constructor allows to get all the supplier needed information
        /// </summary>
        public Supplier()
        {
           
            Console.Write("\nSupplier Name: ");
            name = Console.ReadLine();

            Console.Write("\nSupplier Address: ");
            address = Console.ReadLine();

            nif = DataCheck.TryReadInt("Supplier Nif: ");

            mobileContact = DataCheck.TryReadInt("Supplier Mobile Contact: ");

            Console.Write("\nSupplier Email: ");
            email = Console.ReadLine();

            Console.Write("\nSupplier Country: ");
            country = Console.ReadLine();

            Console.Write("\nSupplier Payment Conditions: ");
            paymentConditions = Console.ReadLine();
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
            this.name = Name;
            this.address = Address;
            this.nif = Nif;
            this.mobileContact = MobileContact;
            this.email = Email;
            this.country = Country;
            this.paymentConditions = paymentConditions;
        }

        #endregion

        #region METHODS
        /// <summary>
        /// This method overrides the ToString Method 
        /// </summary>
        /// <returns>Formated String<returns>
        public override string ToString()
        {

            return string.Format($" Name:{Name}\n Address: {Address}\n Nif:" +
                $"{Nif}\n Mobile Contact: {MobileContact}\n Email:{Email}\n Country:{Country}\n Payment Conditions:{paymentConditions}");
        }

        #region SETTERS


        /// <summary>
        /// This function allows to set the Supplier name
        /// </summary>
        /// <param name="name">New Name</param>
        public void SetName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// This function allows to set the Supplier address
        /// </summary>
        /// <param name="address">New Address</param>
        public void SetAddress(string address)
        {
            this.address = address;
        }

        /// <summary>
        /// This function allows to set the Supplier nif
        /// </summary>
        /// <param name="nif">New Nif</param>
        public void SetNif(int nif)
        {
            this.nif = nif;
        }

        /// <summary>
        /// This function allows to set the Supplier mobile contact
        /// </summary>
        /// <param name="contact">New mobile contact</param>
        public void SetMobileContact(int contact)
        {
            mobileContact = contact;
        }

        /// <summary>
        /// This function allows to set the Supplier email
        /// </summary>
        /// <param name="email">New email</param>
        public void SetEmail(string email)
        {
            this.email = email;
        }

        /// <summary>
        /// This function allows ot set the Supplier country
        /// </summary>
        /// <param name="country"></param>
        public void SetCountry(string country)
        {
            this.country = country;
        }
        #endregion

        #region GETTERS

        #endregion

        #endregion
    }
}
