﻿using System;
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

            PrimaryItem Pitem1 = new PrimaryItem(33, "Farinha");
            PrimaryItem Pitem2 = new PrimaryItem(10, "Areia");
            PrimaryItem Pitem3 = new PrimaryItem(2, "Silica");
            PrimaryItem Pitem4 = new PrimaryItem(1, "Tecido");
            PrimaryItem Pitem5 = new PrimaryItem(50, "Fio");
            Stock.AddItem(Pitem1);
            Stock.AddItem(Pitem2);
            Stock.AddItem(Pitem3);
            Stock.AddItem(Pitem4);
            Stock.AddItem(Pitem5);

            FinalItem item1 = new FinalItem(35,1, "Atum");
            FinalItem item2 = new FinalItem(35, 2, "Pc");
            FinalItem item3 = new FinalItem(35, 3, "telemovel");
            FinalItem item4 = new FinalItem(35, 4, "teste");
            FinalItem item5 = new FinalItem(35, 5, "dinheiro");
            Stock.AddItem(item1);
            Stock.AddItem(item2);
            Stock.AddItem(item3);
            Stock.AddItem(item4);
            Stock.AddItem(item5);

            Console.WriteLine("***************Suppliers***************");
            Suppliers.ListSuppliers();
            Console.WriteLine("****************Clients****************");
            InformationManager.List(clients);
            /*Console.WriteLine("****************Company****************");
            InformationManager.List(company);*/
            Console.WriteLine("*************Primary Stock*****************");
            Stock.GetPrimaryStock();
            Stock.GetPrimaryItem(2);

            Console.WriteLine("**************Final Stock******************");
            Stock.GetFinalStock();
            Stock.GetFinalItem(2);

            Menu.OpenMenu();
            Console.ReadKey();
        }



    }

}
