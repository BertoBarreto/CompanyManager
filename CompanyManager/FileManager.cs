///// <summary>
///// Purpose: 
///// Created By: Roberto Barreto - 21123 || Henrique Cartucho - 21122
///// Email: a21123@alunos.ipca.pt || a21122@alunos.ipca.pt
///// Created On: 5/12/2021 12:10:13 PM
///// </summary>
//using System;
//using System.IO;
//using System.Text;
//using RecipeItemDLL;
//using System.Collections.Generic;

//namespace CompanyManager
//{
//    /// <summary>
//    /// Purpose: 
//    /// </summary>
//    public static class FileManager
//    {

//        public static void SaveRecipe(Dictionary<int,List<RecipeItem>> lst) {
//            try
//            {
//                StringBuilder sb = new StringBuilder();

//                foreach(KeyValuePair<int,List<RecipeItem>> pair in lst)
//                {
//                    sb.AppendFormat($"{pair.Key}");
//                    foreach(RecipeItem item in pair.Value)
//                    {
//                        sb.AppendFormat($"{item.ItemId},");
//                    }
//                    sb.Remove(sb.Length - 1, 1);
//                    sb.AppendLine();
//                }

//                File.WriteAllText("D:\\vscode\\Escola\\2Semestre\\LP2\\CompanyManager\\CompanyManager\\recipes.csv", sb.ToString());


//            }
//            catch
//            {
//                Console.WriteLine("Error saving in the data file");
//            }
//        }
     
//    }
//}
