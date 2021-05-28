using System;
using CompanyManager.Rules;

using CompanyManager.FronEnd;
/*
 * SQL Name: COMPANYMNGSQL
 * String: CompanyManagerDBConnectionString1
 */

namespace CompanyManager
{
    static class Program
    {
        
        static void Main(string[] args)
        {
            DataBase.StartConnection();

            //Client c1 = new Client("Roberto Barreto", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c2 = new Client("Windoh", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c3 = new Client("Henrique Cartucho", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c4 = new Client("Manuel Farpas", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c5 = new Client("Raminhos", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c6 = new Client("Alberto Junior", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c7 = new Client("Quim Roscas", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c8 = new Client("Rosinha", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c9 = new Client("Zé Manuel", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c10 = new Client("Hugo Cruz", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c11 = new Client("Adalberto Teste", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c12 = new Client("Maria Antónia", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c13 = new Client("Marcia Melo", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c14 = new Client("Marta Coiso", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c15 = new Client("Rita Dantas", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c16 = new Client("Albertina", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c17 = new Client("Mariana Filpa", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client c18 = new Client("Estevao Gomes", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);

            //DataBase.InsertClient(c1);
            //DataBase.InsertClient(c2);
            //DataBase.InsertClient(c3);
            //DataBase.InsertClient(c4);
            //DataBase.InsertClient(c5);
            //DataBase.InsertClient(c6);
            //DataBase.InsertClient(c7);
            //DataBase.InsertClient(c8);
            //DataBase.InsertClient(c9);
            //DataBase.InsertClient(c10);
            //DataBase.InsertClient(c11);
            //DataBase.InsertClient(c12);
            //DataBase.InsertClient(c13);
            //DataBase.InsertClient(c14);
            //DataBase.InsertClient(c15);
            //DataBase.InsertClient(c16);
            //DataBase.InsertClient(c17);
            //DataBase.InsertClient(c18);

            // Company.CreateCompany();
            //Console.WriteLine("Here");

            //Client roberto = new Client("Roberto Barreto", "Rua da esquina Nº 3", 12345, 969494105, "robertocontato@geral.pt", "Portugal", "60 dias", 50000);
            //Client henrique = new Client("Antonio","Rua errada",9999999,999999999,"emailErrado@errado.pt","Pais Errado","não sei",0);

            //henrique.SetName("Henrique Cartucho");
            //henrique.SetAddress("Rua da outra esquina nº5");
            //henrique.SetNif(67890);
            //henrique.SetMobileContact(96957687);
            //henrique.SetEmail("henriquecontato@geral.pt");
            //henrique.SetCountry("Portugal");
            //henrique.SetPaymentConditions("30 dias");
            //henrique.SetCreditLimit(10000);

            //Clients.AddClient(roberto);
            //Clients.AddClient(henrique);

            //Supplier atum = new Supplier("atum", "rua de viana n 6", 25634, 965211, "atum@geral.pt", "Espanha", "30 dias");
            //Supplier barcos = new Supplier("barcos", "rua de guima n 6", 29834, 942551, "barcos@geral.pt", "Noruega", "60 dias");
            //DataBase.InsertSupplier(atum);
            //DataBase.InsertSupplier(barcos);

            //PrimaryItem Pitem1 = new PrimaryItem(33, "Farinha");
            //PrimaryItem Pitem2 = new PrimaryItem(10, "Areia");
            //PrimaryItem Pitem3 = new PrimaryItem(2, "Silica");
            //PrimaryItem Pitem4 = new PrimaryItem(1, "Tecido");
            //PrimaryItem Pitem5 = new PrimaryItem(50, "Fio");
            //DataBase.InsertPrimaryItem(Pitem1);
            //DataBase.InsertPrimaryItem(Pitem2);
            //DataBase.InsertPrimaryItem(Pitem3);
            //DataBase.InsertPrimaryItem(Pitem4);
            //DataBase.InsertPrimaryItem(Pitem5);

            //FinalItem item1 = new FinalItem(35, 1, "Atum");
            //FinalItem item2 = new FinalItem(35, 2, "Pc");
            //FinalItem item3 = new FinalItem(35, 3, "telemovel");
            //FinalItem item4 = new FinalItem(35, 4, "teste");
            //FinalItem item5 = new FinalItem(35, 5, "dinheiro");
            //DataBase.InsertFinalItem(item1);
            //DataBase.InsertFinalItem(item2);
            //DataBase.InsertFinalItem(item3);
            //DataBase.InsertFinalItem(item4);
            //DataBase.InsertFinalItem(item5);

            Data.Information.Clients.SaveClients();
            Data.Information.Suppliers.SaveSupplier();
            Data.Items.FinalStock.SaveFinalStock();
            Data.Items.PrimaryStock.SavePrimaryStock();
            Data.Items.Recipes.SaveRecipe();

            Menu.MainMenu();
        }



    }

}
