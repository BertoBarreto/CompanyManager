using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CompanyManager
{
    static class Program
    {
        
        private static List<Supplier> suppliers = new List<Supplier>();
        private static List<Client> clients = new List<Client>();
        private static List<PrimaryItem> items = new List<PrimaryItem>();
        
        
        static void Main(string[] args)
        {
            Client roberto = new Client("Roberto Barreto", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            Client henrique = new Client();

            henrique.Name = "Henrique Cartucho";
            henrique.Address = "Rua da outra esquina nº5";
            henrique.Nif = 67890;
            henrique.MobileContact = 96957687;
            henrique.Email = "henriquecontato@geral.pt";
            henrique.Country = "Portugal";
            henrique.PaymentConditions = "30 dias";
            henrique.CreditLimit = 10000;


            clients.Add(roberto);
            clients.Add(henrique);

            Supplier atum = new Supplier("atum", "rua de viana n 6", 25634, 965211, "atum@geral.pt", "Espanha", "30 dias");
            Supplier barcos = new Supplier("barcos", "rua de guima n 6", 29834, 942551, "barcos@geral.pt", "Noruega", "60 dias");
            suppliers.Add(atum);
            suppliers.Add(barcos);

            //Company company = InformationManager.CreateCompany();

            PrimaryItem item1 = new PrimaryItem(1, 33, "Atum");
            PrimaryItem item2 = new PrimaryItem(1, 10, "Pc");
            PrimaryItem item3 = new PrimaryItem(1, 2, "telemovel");
            PrimaryItem item4 = new PrimaryItem(1, 1, "teste");
            PrimaryItem item5 = new PrimaryItem(1, 50, "dinheiro");
            PrimaryStock.AddItem(item1);
            PrimaryStock.AddItem(item2);
            PrimaryStock.AddItem(item3);
            PrimaryStock.AddItem(item4);
            PrimaryStock.AddItem(item5);

            Console.WriteLine("***************Suppliers***************");
            InformationManager.List(suppliers);
            Console.WriteLine("****************Clients****************");
            InformationManager.List(clients);
            /*Console.WriteLine("****************Company****************");
            InformationManager.List(company);*/
            Console.WriteLine("*************Primary Stock*****************");
            PrimaryStock.GetStock();
            Console.ReadKey();
        }



    }

}
