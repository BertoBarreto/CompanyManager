using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager
{
    class Program
    {
        static List<Supplier> suppliers = new List<Supplier>();
        static List<Client> clients = new List<Client>();
        static void Main(string[] args)
        {
            //Client roberto = new Client("Roberto Barreto", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client henrique = new Client();

            //henrique.Name = "Henrique Cartucho";
            //henrique.Address = "Rua da outra esquina nº5";
            //henrique.Nif = 67890;
            //henrique.MobileContact = 96957687;
            //henrique.Email = "henriquecontato@geral.pt";
            //henrique.Country = "Portugal";
            //henrique.PaymentConditions = "30 dias";
            //henrique.CreditLimit = 10000;

            //Console.WriteLine(henrique.ToString());
            //Console.WriteLine(roberto.ToString());

            //clients.Add(roberto);
            //clients.Add(henrique);

            //CreateClient();

            //foreach(Client c in clients)
            //{
            //    Console.WriteLine("***************************************");
            //    Console.WriteLine(c.ToString());
            //    Console.WriteLine("***************************************");
            //}
            //public Supplier(string Name, string Address, int Nif, int MobileContact, string Email, string Country, string paymentConditions)

            Supplier atum = new Supplier("atum", "rua de viana n 6", 25634, 965211, "atum@geral.pt", "Espanha", "30 dias");
            Supplier barcos = new Supplier("barcos", "rua de guima n 6", 29834, 942551, "barcos@geral.pt", "Noruega", "60 dias");
            suppliers.Add(atum);
            suppliers.Add(barcos);
            CreateSupplier();

            foreach (Supplier s in suppliers)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine(s.ToString());
                Console.WriteLine("***************************************");
            }

            Console.ReadKey();
        }
        public static void CreateSupplier()
        {
            Supplier supplier = new Supplier();

            Console.Write("\nSupplier Name: ");
            supplier.Name = Console.ReadLine();

            Console.Write("\nCliente Address: ");
            supplier.Address  = Console.ReadLine();

            supplier.Nif  = TryReadInt("Supplier Nif: ");

            supplier.MobileContact  = TryReadInt("Supplier Mobile Number: ");

            Console.Write("\nSuppiler Email: ");
            supplier.Email = Console.ReadLine();

            Console.Write("\nSupplier Country: ");
            supplier.Country = Console.ReadLine();

            Console.Write("\nSupplier Payment Conditions: ");
            supplier.PaymentConditions = Console.ReadLine();

            suppliers.Add(supplier);
        }

        public static void CreateClient()
        {
            Client client = new Client();

            Console.Write("\nClient Name: ");
            client.Name = Console.ReadLine();

            Console.Write("\nClient Address: ");
            client.Address = Console.ReadLine();

            client.Nif = TryReadInt("Client Nif");

            client.MobileContact = TryReadInt("Client Mobile Contact");

            Console.Write("\nClient Email: ");
            client.Email = Console.ReadLine();

            Console.Write("\nClient Country: ");
            client.Country = Console.ReadLine();

            Console.Write("\nClient Payment Conditions: ");
            client.PaymentConditions = Console.ReadLine();

            client.CreditLimit = TryReadInt("Client Credit Limit");

            clients.Add(client); 
        }

        private static int TryReadInt(string msg)
        {
            int info;

            Console.Write($"\n{msg}: ");

            bool tryInfo = int.TryParse(Console.ReadLine(), out info);

            while (!tryInfo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Não colocou um número valido!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{msg}: ");
                tryInfo = int.TryParse(Console.ReadLine(), out info);
            }
            return info;

        }
    }

}
