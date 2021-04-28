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
        
        
        private static List<Client> clients = new List<Client>();
        
        
        static void Main(string[] args)
        {
            Company.CreateCompany();

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
            Suppliers.AddSupplier(atum);
            Suppliers.AddSupplier(barcos);

            //Company company = InformationManager.CreateCompany();

            PrimaryItem Pitem1 = new PrimaryItem(1, 33, "Farinha");
            PrimaryItem Pitem2 = new PrimaryItem(2, 10, "Areia");
            PrimaryItem Pitem3 = new PrimaryItem(3, 2, "Silica");
            PrimaryItem Pitem4 = new PrimaryItem(4, 1, "Tecido");
            PrimaryItem Pitem5 = new PrimaryItem(5, 50, "Fio");
            PrimaryStock.AddItem(Pitem1);
            PrimaryStock.AddItem(Pitem2);
            PrimaryStock.AddItem(Pitem3);
            PrimaryStock.AddItem(Pitem4);
            PrimaryStock.AddItem(Pitem5);

            FinalItem item1 = new FinalItem(35,1, "Atum", 33);
            FinalItem item2 = new FinalItem(35, 2, "Pc", 10);
            FinalItem item3 = new FinalItem(35, 3, "telemovel", 2);
            FinalItem item4 = new FinalItem(35, 4, "teste", 1);
            FinalItem item5 = new FinalItem(35, 5, "dinheiro", 50);
            FinalStock.AddItem(item1);
            FinalStock.AddItem(item2);
            FinalStock.AddItem(item3);
            FinalStock.AddItem(item4);
            FinalStock.AddItem(item5);

            Console.WriteLine("***************Suppliers***************");
            Suppliers.ListSuppliers();
            Console.WriteLine("****************Clients****************");
            InformationManager.List(clients);
            /*Console.WriteLine("****************Company****************");
            InformationManager.List(company);*/
            Console.WriteLine("*************Primary Stock*****************");
            PrimaryStock.GetStock();
            PrimaryStock.GetItem(2);

            Console.WriteLine("**************Final Stock******************");
            FinalStock.GetStock();
            FinalStock.GetItem(2);

            Menu.OpenMenu();
            Console.ReadKey();
        }



    }

}
