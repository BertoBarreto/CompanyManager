/// <summary>
/// Purpose: 
/// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
/// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
/// Created On: 5/12/2021 12:10:13 PM
/// </summary>
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using CompanyManager.Rules;

namespace CompanyManager
{
    /// <summary>
    /// Purpose: 
    /// </summary>
    public static class FileManager
    {

        public static void SaveRecipe(Dictionary<int, List<RecipeItem>> lst)
        {
            try
            {
                StringBuilder sb = new StringBuilder();//""

                foreach (KeyValuePair<int, List<RecipeItem>> pair in lst)
                {
                    
                    foreach (RecipeItem item in pair.Value)
                    {
                        sb.AppendFormat($"{item.Id},");//"1,2,3,4,"
                        
                    }
                    sb.AppendFormat($"{pair.Key},");//"1," + "1,2,3,4,"
                    sb.Remove(sb.Length - 1, 1);//"1,1,2,3,4"
                    sb.AppendLine();//"\n1,1,2,3,4"
                }
                
                File.WriteAllText(@"C:\Users\rober\Desktop\recipes.csv", sb.ToString());


            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }
        public static void SaveRecipe(Client c)
        {
            try
            {
                StringBuilder sb = new StringBuilder();//""

                sb.AppendFormat($"{c.Id},");
                sb.AppendFormat($"{c.Name},");
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();

                //foreach (KeyValuePair<int, List<RecipeItem>> pair in lst)
                //{

                //    foreach (RecipeItem item in pair.Value)
                //    {
                //        sb.AppendFormat($"{item.Id},");//"1,2,3,4,"

                //    }
                //    sb.AppendFormat($"{pair.Key},");//"1," + "1,2,3,4,"
                //    sb.Remove(sb.Length - 1, 1);//"1,1,2,3,4"
                //    sb.AppendLine();//"\n1,1,2,3,4"
                //}

                //File.WriteAllText(@"C:\Users\rober\Desktop\Clients.csv", sb.ToString());
                if(File.Exists(@"C:\Users\rober\Desktop\Clients.csv"))
                    File.AppendAllText(@"C:\Users\rober\Desktop\Clients.csv", sb.ToString());


            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }

        public static void LoadRecipe(string path)
        {
            
            try
            {
                StringBuilder sb = new StringBuilder();

                //caminho
                string dt = File.ReadAllText(@"C:\Users\rober\Desktop\recipes.csv");
                string[] data =  dt.Split('\n');

                //string itemDt = File.ReadAllText(@"C:\Users\rober\Desktop\recipes.csv");
                //string[] itemData = itemDt.Split('\n');

                //aqui obtem-se cada linha
                for (int i=0; i <= data.Length; i++)
                {
                    string[] d = data[i].Split(',');
                    int key;
                    List<RecipeItem> value = new List<RecipeItem>();

                    //aqui obtem-se a informação dentro de cada linha
                    for (int j = 0; j <= d.Length; j++)
                    {
                        if (j == 0)
                            key = int.Parse(d[j]);
                        else
                        {
                            //ler ficheiro de recipe items
                        }
                    }
                }

            }
            catch
            {
                DataRules.ErrorMsg("Error saving in the data file");
            }
        }
    }
}
